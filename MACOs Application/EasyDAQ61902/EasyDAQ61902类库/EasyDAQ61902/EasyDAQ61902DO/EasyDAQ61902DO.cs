using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing;


namespace EasyDAQ
{
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(EasyDAQ61902DO), "Components.EasyDO.bmp")]
    public partial class EasyDAQ61902DO : Component
    {
        #region Private Fields

        private DigitalOutputEngine doTask;
        private int boardNum = 0;
        private List<int> selectedChannels = new List<int>();
        private bool isContinuos = false;
        public const int channelSize = 4;

        #endregion Private Fields

        #region Constructor

        public EasyDAQ61902DO()
        {
            InitializeComponent();
            doTask = new DigitalOutputEngine();
            selectedChannels.Add(0);

        }

        public EasyDAQ61902DO(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            doTask = new DigitalOutputEngine();
        }

        #endregion Constructor

        #region Public Properties

        [Category("DAQ Setting")]
        [Description("板卡号")]
        public int BoardID
        {
            get { return boardNum; }
            set { boardNum = value; }
        }

        [Category("DAQ Status")]
        [Description("驱动安装成功")]
        [DefaultValue(false)]
        [Browsable(true)]
        public bool IsDriverExisted
        {
            get { return doTask.IsDriverExisted; }
        }

        [Category("DAQ Status")]
        [Description("板卡初始化成功")]
        [DefaultValue(false)]
        [Browsable(false)]
        public bool IsConnected
        {
            get { return doTask.IsConnected; }
        }

       
        
        [Category("DAQ Setting")]
        [Description("通道选择")]
        [Editor(typeof(PropertyEditor), typeof(UITypeEditor))]
        public List<int> Channels
        {
            get { return selectedChannels; }
            set { selectedChannels = value; }
        }
        
        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Write the data for all channels
        /// </summary>
        public void WriteData(bool[] writeValue)
        {
            try
            {
                if (IsDriverExisted)
                {

                    if (!isContinuos)
                    {
                        doTask.Initialize(boardNum);
                        doTask.ConfigureChannel(selectedChannels.ToArray());
                        isContinuos = true;
                    }

                  doTask.WriteData(writeValue);

                }
               // return writeValue;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message+"\r\n"+ex.StackTrace);
            }
        }

        #endregion Public Methods

        #region UI configurator 
     
        /// <summary>
        /// Open a popup window to confiure the AIChannels
        /// </summary>
        internal class PropertyEditor : UITypeEditor
        {
            public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
            {
                //指定为模式窗体属性编辑器类型
                return UITypeEditorEditStyle.Modal;
            }

            public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
            {
                //打开属性编辑器修改数据
                return ChannelSelector.EditValue(value,DigitalOutputEngine.channelCount);
            }
        }
        
        #endregion

    }
}