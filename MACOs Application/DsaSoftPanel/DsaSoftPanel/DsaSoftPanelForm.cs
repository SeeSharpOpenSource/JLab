using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DsaSoftPanel.Enumeration;
using DsaSoftPanel.FunctionUtility;
using DsaSoftPanel.ScopeComponents;
using DsaSoftPanel.TaskComponents;
using MetroFramework.Forms;
using SeeSharpTools.JY.GUI;

namespace DsaSoftPanel
{
    public partial class DsaSoftPanelForm : Form
    {
        public DsaSoftPanelForm()
        {
            InitializeComponent();
            //强制刷新Tab页面的背景色
            txTabControl_channel.BackColor = Color.FromArgb(64, 64, 64);

            _globalInfo = SoftPanelGlobalInfo.GetInstance();
            _titleMouseDownPosition = Point.Empty;
            _showMeasurePanel = false;
            _showFunctionPanel = false;
            RefreshMeasureAndFunctionPanel();
            AddMoveWindowEvent();
            InitFunctionRadioButtonTag();
            InitMeasureCheckBoxTag();
            //填充测量和函数面板
            panel_measure.Dock = DockStyle.Fill;
            panel_function.Dock = DockStyle.Fill;
        }
        
        private Point _titleMouseDownPosition;
        private void AddMoveWindowEvent()
        {
            panel_title.MouseDown += TitleMouseDown;
            panel_title.MouseMove += TitleMouseMove;
            panel_title.MouseUp += TitleMouseUp;
            panel_title.DoubleClick += button_maximize_Click;
//            pictureBox_titleIcon.MouseDown += TitleMouseDown;
//            pictureBox_titleIcon.MouseMove += TitleMouseMove;
//            pictureBox_titleIcon.MouseUp += TitleMouseUp;
            label_title.MouseDown += TitleMouseDown;
            label_title.MouseMove += TitleMouseMove;
            label_title.MouseUp += TitleMouseUp;
            label_title.DoubleClick += button_maximize_Click;
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

        private void InitFunctionRadioButtonTag()
        {
            txRadioButton_spectrum.Tag = FunctionType.Spectrum.ToString();
            txRadioButton_harmonic.Tag = FunctionType.Harmonic.ToString();
            txRadioButton_toneAnalyze.Tag = FunctionType.ToneAnalyze.ToString();
            txRadioButton_filter.Tag = FunctionType.Filter.ToString();
            txRadioButton_squareAnalyze.Tag = FunctionType.SquaureAnalyze.ToString();
            txRadioButton_phaseShift.Tag = FunctionType.PhaseShift.ToString();
        }

        private void InitMeasureCheckBoxTag()
        {
            txCheckBox_DC.Tag = MeasureType.DC;
            txCheckBox_rms.Tag = MeasureType.RMS;
            txCheckBox_peakAmp.Tag = MeasureType.PeakAmp;
            txCheckBox_peakFreq.Tag = MeasureType.PeakFreq;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            easyChartX_data.Clear();
            easyChartX_data.AxisX.ZoomReset();
            easyChartX_data.AxisY.ZoomReset();
            easyChartX_function.Clear();
            _channelViewManager.Clear();
        }

        private readonly SoftPanelGlobalInfo _globalInfo;
        private OscilloscopeTask _scopeTask;
        private FunctionTask _funcTask;
        private ChannelViewManager _channelViewManager;

        private void OscilloscopeSoftPanelForm_Load(object sender, EventArgs e)
        {
            _globalInfo.MainForm = this;
            _channelViewManager = new ChannelViewManager(this, label__ch1, label_ch2, label_ch3, label_ch4);
            _globalInfo.ChartViewPlot = easyChartX_data.Plot;
            _globalInfo.FunctionPlot = easyChartX_function.Plot;
            _globalInfo.ApplyConfigInRunTime = ApplyConfigInRunTime;
            _scopeTask = new OscilloscopeTask(this);
            _funcTask = new FunctionTask(this);
        }

        private string GetSampleRateLabel()
        {
            const string sampleRateFormat = "TD:{0}{1}Sa/s";
            double sampleRate = _globalInfo.AITask.MaxSampleRate;
            string sampleRateUnit = "";
            string valueFormat = "";
            double formatedValue;
            if (sampleRate >= 1E6)
            {
                sampleRateUnit = "M";
                valueFormat = "{0,6}";
                formatedValue = sampleRate/1E6;
            }
            else if (sampleRate >= 1E3)
            {
                sampleRateUnit = "K";
                valueFormat = "{0,6}";
                formatedValue = sampleRate / 1E3;
            }
            else
            {
                sampleRateUnit = "";
                valueFormat = "{0,7}";
                formatedValue = sampleRate;
            }
            return string.Format(sampleRateFormat, string.Format(valueFormat, formatedValue), sampleRateUnit);
        }

        private void buttonSwitch_Switch_ValueChanged(object sender, EventArgs e)
        {
            if (buttonSwitch_Switch.Value)
            {
                ApplyConfigAndStartTask();
            }
            else
            {
                _scopeTask.Stop();
                _funcTask.Stop();
            }
        }

        private void ApplyConfigAndStartTask()
        {
            try
            {
                // TODO to config
                numericUpDown_chartRange_ValueChanged(null, null);
                bool isChannelConfigured = SyncConfigAndRestartTask();
                if (!isChannelConfigured)
                {
                    buttonSwitch_Switch.Value = false;
                }
                //                    _scopeTask.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                buttonSwitch_Switch.Value = false;
            }
        }

        private void OscilloscopeSoftPanelForm_Shown(object sender, EventArgs e)
        {
            if (!_globalInfo.BoardConnected)
            {
                ShowBoardConnectForm();
            }
            CheckIfBoardConnected();
        }

        private void CheckIfBoardConnected()
        {
            if (_globalInfo.BoardConnected)
            {
                buttonSwitch_Switch.Value = false;
                _channelViewManager.AdaptChannelConfigView();
                label_sampleRateInMenu.Text = GetSampleRateLabel();
            }
            else
            {
                this.Dispose();
            }
        }

        private void ShowBoardConnectForm()
        {
            DsaBoardConnectForm connectForm = new DsaBoardConnectForm();
            this.Hide();
            connectForm.ShowDialog();
        }


        private void OscilloscopeSoftPanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _scopeTask?.Stop();
            _funcTask?.Stop();
            _globalInfo.AITask.Stop();
        }

        private bool SyncConfigAndRestartTask()
        {
            bool isNeedRestartTask, isNeedRefreshView, channelEnabled;
            _channelViewManager.SyncChannelConfig(out isNeedRestartTask, out isNeedRefreshView, out channelEnabled);
            if (!channelEnabled)
            {
                _scopeTask.Stop();
                Clear();
                _funcTask.Stop();
            }
            else
            {
                if (isNeedRestartTask || !_scopeTask.TaskRunning)
                {
                    _scopeTask.Stop();
                    _funcTask.Stop();
                    Clear();
                    Thread.Sleep(100);
                    _globalInfo.AITask.ClearChannels();
                    ApplyCommonConfig();
                    _channelViewManager.ApplyChannelConfig();
                    RefreshMeasureChannelItems();
                    _scopeTask.Start();
                    _funcTask.Start();
                }
            }
            
            return channelEnabled;
        }

        internal void ShowErrorMsg(string text, string caption = "Error")
        {
            MessageBox.Show(text, caption);
            buttonSwitch_Switch.Value = false;
        }

        private void checkBox_splitView_CheckedChanged(object sender, EventArgs e)
        {
            bool isSplitView = checkBox_splitView.Checked;
            easyChartX_data.SplitView = isSplitView;
            easyChartX_function.SplitView = isSplitView;
        }

//        private void numericUpDown_sampleRate_ValueChanged(object sender, EventArgs e)
//        {
//            if (!buttonSwitch_Switch.Value || _globalInfo.SampleRate == numericUpDown_sampleRate.Value)
//            {
//                return;
//            }
//            _globalInfo.SampleRate = (int)numericUpDown_sampleRate.Value;
//            ApplyConfigAndStartTask();
//        }

        private void ApplyCommonConfig()
        {
//            _globalInfo.SampleRate = (int) _globalInfo.AITask.MaxSampleRate;
            _globalInfo.AITask.SetSampleRate(_globalInfo.SampleRate);

            _globalInfo.SamplesPerView = GetSamplesPerView();
            // TODO to add trigger later
        }

        private void ApplyConfigInRunTime()
        {
            if (buttonSwitch_Switch.Value)
            {
                ApplyConfigAndStartTask();
            }
        }

        private void knobControl_viewTime_ValueChanged(object Sender)
        {
            RefreshViewTime((int) knobControl_viewTime.Value);
        }

        private void numericUpDown_viewTime_ValueChanged(object sender, EventArgs e)
        {
            RefreshViewTime((int) numericUpDown_viewTime.Value);
        }

        private void RefreshViewTime(int value)
        {
            int realViewTime = (value >= Constants.MinViewTime) ? value : Constants.MinViewTime;
            knobControl_viewTime.Value = realViewTime;
            numericUpDown_viewTime.Value = realViewTime;
            _globalInfo.SamplesPerView = GetSamplesPerView();
        }

        private int GetSamplesPerView()
        {
            return (int) ((double) numericUpDown_viewTime.Value*_globalInfo.AITask.GetSampleRate()/1000);
        }

        private void knobControl_chartRange_ValueChanged(object Sender)
        {
            RefreshChartRange(knobControl_chartRange.Value);
        }

        private void numericUpDown_chartRange_ValueChanged(object sender, EventArgs e)
        {
            RefreshChartRange((double) numericUpDown_chartRange.Value);
        }

        private void RefreshChartRange(double value)
        {
            double realChartRange = (value < Constants.MinChartRange) ? Constants.MinChartRange : Math.Round(value, 1);
            knobControl_chartRange.Value = realChartRange;
            numericUpDown_chartRange.Value = (decimal) realChartRange;
            easyChartX_data.AxisY.Maximum = realChartRange;
            easyChartX_data.AxisY.Minimum = -1*realChartRange;
            foreach (EasyChartXPlotArea plotArea in easyChartX_data.SplitPlotArea)
            {
                plotArea.AxisY.Maximum = realChartRange;
                plotArea.AxisY.Minimum = -1*realChartRange;
            }
        }

        private void button_runPause_Click(object sender, EventArgs e)
        {
            _globalInfo.RunStatus = !_globalInfo.RunStatus;
            button_runPause.Text = _globalInfo.RunStatus ? Constants.RunButtonText : Constants.PauseButtonText;
        }

        private void easyChartX_data_AxisViewChanged(object sender, EasyChartXViewEventArgs e)
        {
            RefreshStatusLabel();
        }

        internal void RefreshStatusLabel()
        {
            label_status2.Text = $"X Range:{(easyChartX_data.AxisX.ViewMaximum - easyChartX_data.AxisX.ViewMinimum).ToString("F2")}ms";
            label_status3.Text = $"Y Range:{(easyChartX_data.AxisY.ViewMaximum - easyChartX_data.AxisY.ViewMinimum).ToString("F2")}";
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _showMeasurePanel = false;
        private bool _showFunctionPanel = false;
        private void button_measure_Click(object sender, EventArgs e)
        {
            _showMeasurePanel = !_showMeasurePanel;
            if (_showMeasurePanel)
            {
                _showFunctionPanel = false;
            }
            RefreshMeasureAndFunctionPanel();
        }

        private void button_function_Click(object sender, EventArgs e)
        {
            _showFunctionPanel = !_showFunctionPanel;
            if (_showFunctionPanel)
            {
                _showMeasurePanel = false;
            }
            RefreshMeasureAndFunctionPanel();
        }

        private void RefreshMeasureAndFunctionPanel()
        {
            if (_showMeasurePanel)
            {
                splitContainer_buttonAndFunction.Panel2Collapsed = false;
                splitContainer_measureAndView.SplitterDistance = 180;
                button_measure.FlatAppearance.BorderColor = Color.Gray;
                button_function.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
                _showFunctionPanel = false;
            }
            else if (_showFunctionPanel)
            {
                splitContainer_buttonAndFunction.Panel2Collapsed = false;
                splitContainer_measureAndView.SplitterDistance = 180;
                button_measure.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
                button_function.FlatAppearance.BorderColor = Color.Gray;
                _showMeasurePanel = false;
            }
            else
            {
                splitContainer_buttonAndFunction.Panel2Collapsed = true;
                splitContainer_measureAndView.SplitterDistance = 30;
                button_measure.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
                button_function.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            }
            panel_measure.Visible = _showMeasurePanel;
            panel_function.Visible = _showFunctionPanel;
            splitContainer_plotArea.Panel2Collapsed = (null == _funcTask || _funcTask.FunctionType == FunctionType.None);
        }

        private void easyChartX_function_CursorPositionChanged(object sender, EasyChartXCursorEventArgs e)
        {
            if (null == e.ParentChartArea)
            {
                return;
            }
            label_XValueLabel.Text = string.Format(_functionXValueFormat, e.ParentChartArea.XCursor.Value);
            label_YValueLabel.Text = string.Format(_functionYValueFormat, e.ParentChartArea.YCursor.Value);
        }

        private void button_triggerConfig_Click(object sender, EventArgs e)
        {
            TriggerConfigForm triggerConfigForm = new TriggerConfigForm();
            triggerConfigForm.ShowDialog(this);
        }

        private string _functionXValueFormat = "{0}";
        private string _functionYValueFormat = "{0}";
        public void InitFunctionResultArea(FunctionBase function)
        {
            RefreshMeasureAndFunctionPanel();
            if (null == function)
            {
                return;
            }
            const string parameterColumnTitle = "Parameter";
            const string valueColumnTitle = "Value";
            easyChartX_function.AxisX.Title = function.ChartXTitle;
            easyChartX_function.AxisY.Title = function.ChartYTitle;
            label_XValueLabel.Text = string.Format(function.XValueLabelFormat, 0);
            label_YValueLabel.Text = string.Format(function.YValueLabelFormat, 0);
            _functionXValueFormat = function.XValueLabelFormat;
            _functionYValueFormat = function.YValueLabelFormat;
            splitContainer_functionDataAndDetail.Panel1Collapsed = !function.HasPlotData;
            splitContainer_functionDataAndDetail.Panel2Collapsed = !function.HasDetailedData;
            dataGridView_functionDetail.Rows.Clear();
            if (function.HasDetailedData)
            {
//                dataGridView_functionDetail.Rows.Add(parameterColumnTitle, valueColumnTitle);
                foreach (string parameter in function.DetailParameters)
                {
                    dataGridView_functionDetail.Rows.Add(parameter, "");
                }
            }
            if (function.HasPlotData)
            {
                function.ConfigChart(easyChartX_function);
                easyChartX_function.Clear();
            }
        }
        
        public void RefreshFunctionDetailResult(FunctionBase function)
        {
            for (int i = 0; i < dataGridView_functionDetail.RowCount; i++)
            {
                dataGridView_functionDetail.Rows[i].Cells[1].Value = function.DetailValues[i];
            }
        }

        private void SetFunctionType(object sender, EventArgs e)
        {
            RadioButton functionButton = sender as RadioButton;
            if (null != functionButton && functionButton.Checked)
            {
                _funcTask.FunctionType = (FunctionType)Enum.Parse(typeof(FunctionType), functionButton.Tag.ToString());
            }
        }

        private void button_stopfunction_Click(object sender, EventArgs e)
        {
            foreach (Control control in tableLayoutPanel_functionSelect.Controls)
            {
                if (control is RadioButton)
                {
                    (control as RadioButton).Checked = false;
                }
            }
            _funcTask.FunctionType = FunctionType.None;
        }

        public void InitFunctionConfigArea(FunctionBase function)
        {
            panel_functionConfig.Controls.Clear();
            if (null == function?.ConfigForm)
            {
                return;
            }
            panel_functionConfig.Controls.Add(function.ConfigForm);
            function.ConfigForm.Show();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            _funcTask?.Stop();
            _scopeTask?.Stop();
            ShowBoardConnectForm();
            CheckIfBoardConnected();
        }

        private void radioButton_xZoom_CheckedChanged(object sender, EventArgs e)
        {
            easyChartX_data.XCursor.Mode = EasyChartXCursor.CursorMode.Zoom;
            easyChartX_data.YCursor.Mode = EasyChartXCursor.CursorMode.Disabled;
        }

        private void radioButton_zoomY_CheckedChanged(object sender, EventArgs e)
        {
            easyChartX_data.XCursor.Mode = EasyChartXCursor.CursorMode.Disabled;
            easyChartX_data.YCursor.Mode = EasyChartXCursor.CursorMode.Zoom;
        }

        private void radioButton_zoomArea_CheckedChanged(object sender, EventArgs e)
        {
            easyChartX_data.XCursor.Mode = EasyChartXCursor.CursorMode.Zoom;
            easyChartX_data.YCursor.Mode = EasyChartXCursor.CursorMode.Zoom;
        }

        private void radioButton_cursor_CheckedChanged(object sender, EventArgs e)
        {
            easyChartX_data.XCursor.Mode = EasyChartXCursor.CursorMode.Cursor;
            easyChartX_data.YCursor.Mode = EasyChartXCursor.CursorMode.Cursor;
        }

        private void SelectMeasureType(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            MeasureType measureType = (MeasureType) checkBox.Tag;
            if (checkBox.Checked)
            {
                _funcTask.AddMeasure(measureType);
            }
            else
            {
                _funcTask.RemoveMeasre(measureType);
            }
            InitMeasureResultView();
        }

        private void InitMeasureResultView()
        {
            dataGridView_measureValues.Rows.Clear();
            foreach (MeasureType measureType in _funcTask.MeasureTypes)
            {
                dataGridView_measureValues.Rows.Add(measureType.ToString(), "");
            }
        }

        public void RefreshMeasureResult(string[] results)
        {
            Invoke(new Action(() =>
            {
                for (int i = 0; i < results.Length; i++)
                {
                    dataGridView_measureValues.Rows[i].Cells[1].Value = results[i];
                }
            }));
        }

        public int GetMeasureIndex()
        {
            int index = 0;
            Invoke(new Action(() =>
            {
                index = metroComboBox_measureChannel.SelectedIndex;
            }));
            return index;
        }

        private void RefreshMeasureChannelItems()
        {
            metroComboBox_measureChannel.Items.Clear();
            foreach (ChannelConfig channel in _globalInfo.Channels)
            {
                if (channel.Enabled)
                {
                    metroComboBox_measureChannel.Items.Add(channel.ChannelName);
                }
            }
            if (metroComboBox_measureChannel.Items.Count > 0)
            {
                metroComboBox_measureChannel.SelectedIndex = 0;
            }
        }
    }
}
