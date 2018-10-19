using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace DsaSoftPanel
{
    public partial class TriggerConfigForm : Form
    {
        private Point _titleMouseDownPosition;
        private SoftPanelGlobalInfo _globalInfo = SoftPanelGlobalInfo.GetInstance();

        public TriggerConfigForm()
        {
            InitializeComponent();
            //强制刷新Tab页面的背景色
            txTabControl_channel.BackColor = Color.FromArgb(64, 64, 64);
            AddWindowMoveMouseEvents();
        }

        private void AddWindowMoveMouseEvents()
        {
            panel_title.MouseDown += TitleMouseDown;
            panel_title.MouseMove += TitleMouseMove;
            panel_title.MouseUp += TitleMouseUp;

            label_title.MouseDown += TitleMouseDown;
            label_title.MouseMove += TitleMouseMove;
            label_title.MouseUp += TitleMouseUp;
        }

        private void TitleMouseDown(object sender, MouseEventArgs mouseEventArgs)
        {
            _titleMouseDownPosition = mouseEventArgs.Location;
        }

        private void TitleMouseMove(object sender, MouseEventArgs mouseEventArgs)
        {
            if (_titleMouseDownPosition != Point.Empty)
            {
                Point formLocation = this.Location;
                formLocation.Offset(mouseEventArgs.X - _titleMouseDownPosition.X,
                    mouseEventArgs.Y - _titleMouseDownPosition.Y);
                this.Location = formLocation;
            }
        }

        private void TitleMouseUp(object sender, MouseEventArgs mouseEventArgs)
        {
            _titleMouseDownPosition = Point.Empty;
        }

        private void textBox_threshold_TextChanged(object sender, EventArgs e)
        {
            // 如果输入非法字段应当取消输入
            double thresholdValue = 0;
            if (!double.TryParse(textBox_threshold.Text, out thresholdValue))
            {
                textBox_threshold.Text = _globalInfo.AITask.AnalogTriggerThreshold.ToString();
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            _globalInfo.AITask.TriggerType = metroComboBox_triggerType.Text;
            _globalInfo.AITask.TriggerMode = metroComboBox_triggerMode.Text;

            _globalInfo.AITask.AnalogTriggerSource = metroComboBox_analogTriggerChannel.Text;
            _globalInfo.AITask.AnalogTriggerCondition = metroComboBox_analogTriggerCondition.Text;
            _globalInfo.AITask.AnalogTriggerThreshold = double.Parse(textBox_threshold.Text);

            _globalInfo.AITask.DigitalTriggerSource = metroComboBox_digitalSource.Text;
            _globalInfo.AITask.DigitalTriggerEdge = metroComboBox_digitalEdge.Text;

            this.Dispose();
        }

        private void TriggerConfigForm_Load(object sender, EventArgs e)
        {
            AITask.AITask aiTask = _globalInfo.AITask;
            InitComboBoxItemsAndValue(metroComboBox_triggerType, aiTask.GetTriggerTypes(), aiTask.TriggerType);
            InitComboBoxItemsAndValue(metroComboBox_triggerMode, aiTask.GetTriggerModes(), aiTask.TriggerMode);

            InitComboBoxItemsAndValue(metroComboBox_analogTriggerChannel, aiTask.GetAnalogTriggerSources(), aiTask.AnalogTriggerSource);
            InitComboBoxItemsAndValue(metroComboBox_analogTriggerCondition, aiTask.GetAnalogTriggerConditions(), aiTask.AnalogTriggerCondition);
            InitTextBoxValue(textBox_threshold, double.IsNaN(aiTask.AnalogTriggerThreshold) ? null : aiTask.AnalogTriggerThreshold.ToString());

            InitComboBoxItemsAndValue(metroComboBox_digitalSource, aiTask.GetDigitalTriggerSources(), aiTask.DigitalTriggerSource);
            InitComboBoxItemsAndValue(metroComboBox_digitalEdge, aiTask.GetDigitalTriggerEdge(), aiTask.DigitalTriggerEdge);
        }

        private static void InitComboBoxItemsAndValue(ComboBox comboBox, string[] triggerTypes, string value)
        {
            if (null == triggerTypes)
            {
                comboBox.Enabled = false;
                comboBox.Text = "";
            }
            else
            {
                comboBox.Items.AddRange(triggerTypes);
                comboBox.Text = value;
            }
        }

        private static void InitTextBoxValue(TextBox textBox, string value)
        {
            if (null == value)
            {
                textBox.Enabled = false;
                textBox.Text = "";
            }
            else
            {
                textBox.Text = value;
            }
        }

        
    }
}
