using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing;
using System.Threading;

namespace EasyDAQ
{
    [DefaultEvent("DataReceived")] //双击组件生成的默认事件
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(EasyDAQ61902DI), "Components.EasyDI.bmp")]
    public partial class EasyDAQ61902DI : Component
    {
        #region Private Fields

        private DigitalInputEngine diTask;
        private int boardNum = 0;
        private List<int> selectedChannels = new List<int>();
        private bool[] readValue;
        public const int channelSize = 8;
        private bool _isRunning = false;
        Thread ReadThread;

        #endregion Private Fields

        #region Constructor

        public EasyDAQ61902DI()
        {
            InitializeComponent();
            diTask = new DigitalInputEngine();
            selectedChannels.Add(0);

        }

        public EasyDAQ61902DI(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            diTask = new DigitalInputEngine();
        }
        ~EasyDAQ61902DI()
        {
            _isRunning = false;
            DataReceived = null;
         
        }
        #endregion Constructor

        #region Public Properties

        //设置属性界面

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
            get { return diTask.IsDriverExisted; }
        }

        [Category("DAQ Status")]
        [Description("板卡初始化成功")]
        [DefaultValue(false)]
        [Browsable(false)]
        public bool IsConnected
        {
            get { return diTask.IsConnected; }
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

        #region Events

        public event EventHandler<EventArgs> DataReceived;
        protected virtual void OnDataReceived(EventArgs e)
        {
            DataReceived?.Invoke(this, e);
        }
        private void RemoveAllEventRegistration()
        {
            if (DataReceived != null)
            {
                Delegate[] invokeList = DataReceived.GetInvocationList();

                if (invokeList != null)
                {
                    foreach (var item in invokeList)
                    {
                        this.Events.RemoveHandler(this, item);
                    }
                }
            }

        }

        #endregion Events

        #region Public Methods

        public void Start()
        {
            try
            {
                if (IsDriverExisted)
                {
                    if (_isRunning == true)
                    {
                        _isRunning = false;
                       
                        Thread.Sleep(100);
                    }
                    if (!_isRunning)
                    {
                        diTask.Initialize(boardNum);
                        diTask.ConfigureChannel(selectedChannels.ToArray());
                        _isRunning = true;
                        ReadThread = new Thread(readDataTHD);
                        ReadThread.Start();//开始DataReceived事件
                    }
                   
                }
          

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        public void Stop()
        {
            
                if (IsDriverExisted)
                {
                  ReadThread?.Abort();

                  RemoveAllEventRegistration();
                }
        }
        /// <summary>
        /// Read the data for all channels
        /// </summary>
        public bool[] ReadData()
        {

            if (_isRunning)
            {
                readValue = diTask.ReadData();
                return readValue;
            }
            else
            {
                Start();
                readValue = diTask.ReadData();
                return readValue;
            }
         
           
        }

        public void readDataTHD()         //开始DataReceived事件
        {
            while (_isRunning)
            {
                if (_isRunning)
                {
                    OnDataReceived(new EventArgs());
                }
                if (_isRunning)
                {
                    Thread.Sleep(100);
                }
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
                return ChannelSelector.EditValue(value, DigitalInputEngine.channelCount);
            }
        }

        #endregion

    }
}