using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeeSharpTools.JY.ArrayUtility;
using SeeSharpTools.JY.DSP.Fundamental;

namespace MACOs.JY.SoftFrontPanel
{
    public partial class Form1 : Form
    {
        #region Private Data

        private HardwareFactory.InstrumentsType _instrType = HardwareFactory.InstrumentsType.Simulation;
        private int _brdNum = 0;
        private double _sampleRate;
        private int _samples;
        private string _attenuation;
        private bool spectrumMode;

        private AnalogInputDevices device;

        private DGVGUIHandler _hwGUIHandler;
        private MathEngine MathEngineHandler;
        private int _dataLength = 0;
        private int _selChCnts = 0;
        private int rowIndex = 0;
        private double[,] displayData;
        private double[,] readData;
        private double[] tempData;
        private double[] tempSpecData;
        private double df;
        private List<string> _chNames = new List<string>();
        private string[] _seriesDefaultNames = new string[32];
        private bool isSingleRun = true;
        private bool isRunning = false;
        private Task fetchTask;
        private bool dataAvailable = false;

        #endregion Private Data

        #region Constructor

        public Form1()
        {
            InitializeComponent();
            easyChart1.FixAxisX = true; 
        }

        #endregion Constructor

        #region Private Methods

        private void Run()
        {
            if (device.SelectedChannels.Length != 0)
            {
                if (_dataLength != _samples || _selChCnts != device.SelectedChannels.Length)
                {
                    _dataLength = _samples;
                    _selChCnts = device.SelectedChannels.Length;
                    readData = new double[_dataLength, _selChCnts];
                    tempData = new double[_dataLength];
                    tempSpecData = new double[_dataLength];
                    displayData = new double[_selChCnts, _dataLength];
                }

                device.ConfigTiming(_sampleRate, _samples);
                device.ConfigTrigger(propertyGrid_trigProp.SelectedObject);
                dataAvailable = false;
                device.Start();
                fetchTask = Task.Factory.StartNew(FetchLoop);
            }
            else
            {
                easyButton_stop_Click(null, null);
                timer_measure.Enabled = false;
            }
        }

        private void FetchLoop()
        {
            while (isRunning)
            {
                if (device.SelectedChannels.Length != 0)
                {
                    if (device.ReadyToFetch)
                    {
                        device.Fetch(ref readData);
                        ArrayCalculation.MultiplyScale(ref readData, Double.Parse(_attenuation));

                        //isExecCompleted = true;
                        isRunning = false;
                        dataAvailable = true;
                    }
                }
                Thread.Sleep(1);
            }
        }

        private void GUIConfig(AnalogInputDevices _device)
        {
            Type t = _device.GetType().GetInterfaces()[0];

            switch (t.Name)
            {
                case "IDigitizer":
                    numericUpDown_sampleRate.Value = (decimal)(((IDigitizer)device).DigitizerInformation.MaxSampleRate / 10);
                    numericUpDown_samples.Value = (decimal)((double)numericUpDown_sampleRate.Value / 1000.0);
                    break;

                case "IDaq":
                    numericUpDown_sampleRate.Value = (decimal)(((IDaq)device).DaqInfomation.MaxSampleRate);
                    numericUpDown_samples.Value = (decimal)((double)numericUpDown_sampleRate.Value / 10.0);
                    break;

                case "IDsa":
                    numericUpDown_sampleRate.Value = (decimal)(((IDsa)device).DSAInformation.MaxSampleRate);
                    numericUpDown_samples.Value = (decimal)((double)numericUpDown_sampleRate.Value / 10);
                    break;

                case "ISimulation":
                    numericUpDown_sampleRate.Value = 10000;
                    numericUpDown_samples.Value = (decimal)((double)numericUpDown_sampleRate.Value / 10.0);
                    break;

                default:
                    break;
            }
        }

        #endregion Private Methods

        #region EventHandler

        public void Form1_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("JYTEK - Soft Front Panel ({0}, Board Number={1})", _instrType, _brdNum);
            device = HardwareFactory.Create(_brdNum, _instrType);

            _hwGUIHandler = new DGVGUIHandler();
            _hwGUIHandler.CellValueChangedEvent += _hwGUIHandler_CellValueChangedEvent;
            _hwGUIHandler.BindingSource(dgv_ChannelsConfig, device.GetChannelMap());
            MathEngineHandler = new MathEngine(dgv_mathEngine, contextMenuStrip1, device.SelectedChannels);
            propertyGrid_trigProp.SelectedObject = device.TriggerSetting;

            GUIConfig(device);

            comboBox_attRatio.SelectedIndex = 0;

            for (int i = 0; i < _seriesDefaultNames.Length; i++)
            {
                _seriesDefaultNames[i] = "Series " + i.ToString();
            }
            string[] text = Enum.GetNames(typeof(HardwareFactory.InstrumentsType));
            for (int i = 0; i < text.Length; i++)
            {
                ToolStripMenuItem digitizerMenus = new ToolStripMenuItem(text[i])
                {
                    CheckOnClick = true,
                };
                toolStripMenuItem_aiDevice.DropDownItems.Add(digitizerMenus);
            }
            foreach (ToolStripMenuItem item in toolStripMenuItem_graphs.DropDownItems)
            {
                item.CheckOnClick = true;
                item.Checked = false;
            }
            toolStripMenuItem_time.Checked = true;

            contextMenuStrip1.Items.Clear();
            contextMenuStrip1.Items.Add(new ToolStripMenuItem("Add Measure Item"));
            contextMenuStrip1.Items.Add(new ToolStripMenuItem("Remove Measure Item"));
        }

        private void _hwGUIHandler_CellValueChangedEvent(object sender, DGVGUIHandler.CellValueChangedEventArgs e)
        {
            if (isRunning)
            {
                easyButton_stop_Click(null, null);
                device.ConfigChannel(dgv_ChannelsConfig.Rows[e.SelectedRowIndex].DataBoundItem);
            }
            else
            {
                device.ConfigChannel(dgv_ChannelsConfig.Rows[e.SelectedRowIndex].DataBoundItem);
            }
            MathEngineHandler.UpdateTasks(
                (int)dgv_ChannelsConfig.Rows[e.SelectedRowIndex].Cells[1].Value,
                (bool)dgv_ChannelsConfig.Rows[e.SelectedRowIndex].Cells[0].Value,
                dgv_mathEngine);
        }

        private void easyButton_start_Click(object sender, EventArgs e)
        {
            easyButton_start.Enabled = false;
            easyButton_contStart.Enabled = false;
            easyButton_stop.Enabled = true;
            isSingleRun = true;
            isRunning = true;
            Run();
            timer_measure.Enabled = true;
        }

        private void easyButton_stop_Click(object sender, EventArgs e)
        {
            device.Stop();

            easyButton_start.Enabled = true;
            easyButton_contStart.Enabled = true;
            easyButton_stop.Enabled = false;
            timer_measure.Enabled = false;
            isRunning = false;
        }

        private void easyButton_contStart_Click(object sender, EventArgs e)
        {
            easyButton_start.Enabled = false;
            easyButton_contStart.Enabled = false;
            easyButton_stop.Enabled = true;
            isSingleRun = false;
            isRunning = true;
            Run();
            timer_measure.Enabled = true;
        }

        private void timer_measure_Tick(object sender, EventArgs e)
        {
            timer_measure.Enabled = false;
            if (dataAvailable)
            {
                MathEngineHandler.WfmSubset(readData, device.SelectedChannels.ToList(), (double)numericUpDown_sampleRate.Value);
                ArrayManipulation.Transpose(readData, ref displayData);
                MathEngineHandler.Process();
                if (spectrumMode)
                {
                    for (int i = 0; i < readData.GetLength(1); i++)
                    {
                        ArrayManipulation.GetArraySubset(readData, i, ref tempData, ArrayManipulation.IndexType.column);
                        Spectrum.PowerSpectrum(tempData, _sampleRate, ref tempSpecData, out df);
                        ArrayManipulation.ReplaceArraySubset(tempSpecData, ref displayData, i, ArrayManipulation.IndexType.row);
                    }
                    easyChart1.Plot(displayData, 0, df);
                }
                else
                {
                    if (checkBox_timeDisplay.Checked)
                    {
                        easyChart1.Plot(displayData, 0, 1.0 / (double)numericUpDown_sampleRate.Value);
                    }
                    else
                    {
                        easyChart1.Plot(displayData);
                    }
                }
                easyChart1.SeriesNames = _seriesDefaultNames;
                easyChart1.SeriesNames = _chNames.ToArray();
                dgv_mathEngine.Invalidate();
                if (isSingleRun)
                {
                    easyButton_stop_Click(null, null);
                }
                else
                {
                    device.Stop();
                    easyButton_contStart_Click(null, null);
                }
            }
            else
            {
                timer_measure.Enabled = true;
            }
        }

        private void toolStripMenuItem_aiDevice_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            easyButton_stop_Click(null, null);
            dgv_ChannelsConfig.DataSource = null;
            dgv_mathEngine.DataSource = null;

            userDialog dialog = new userDialog(e.ClickedItem.ToString(), "Please Select the Board Number");
            dialog.ShowDialog();

            _instrType = (HardwareFactory.InstrumentsType)Enum.Parse(typeof(HardwareFactory.InstrumentsType), e.ClickedItem.ToString());
            _brdNum = dialog.BoardNumber;
            this.Text = string.Format("JYTEK - Soft Front Panel ({0}, Board Number={1})", _instrType, _brdNum);

            foreach (ToolStripMenuItem item in toolStripMenuItem_aiDevice.DropDownItems)
            {
                item.CheckState = CheckState.Unchecked;
            }

            device = HardwareFactory.Create(_brdNum, _instrType);
            _hwGUIHandler.BindingSource(dgv_ChannelsConfig, device.GetChannelMap());
            MathEngineHandler = new MathEngine(dgv_mathEngine, contextMenuStrip1, device.SelectedChannels);
            propertyGrid_trigProp.SelectedObject = device.TriggerSetting;

            GUIConfig(device);

            toolStripMenuItem_aiDevice.Invalidate();
        }

        private void toolStripMenuItem_graphs_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in ((ToolStripMenuItem)sender).DropDownItems)
            {
                item.CheckState = CheckState.Unchecked;
            }
            spectrumMode = e.ClickedItem.Text.Contains("Spectrum");
        }

        private void dgv_mathEngine_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this.dgv_mathEngine, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void propertyGrid_trigProp_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (isRunning)
            {
                easyButton_stop_Click(null, null);
            }

        }

        #endregion EventHandler

        #region GUI Paramters Events

        private void numericUpDown_sampleRate_ValueChanged(object sender, EventArgs e)
        {
            _sampleRate = (double)numericUpDown_sampleRate.Value;
        }

        private void numericUpDown_samples_ValueChanged(object sender, EventArgs e)
        {
            _samples = (int)numericUpDown_samples.Value;
        }

        private void comboBox_attRatio_SelectedIndexChanged(object sender, EventArgs e)
        {
            _attenuation = comboBox_attRatio.SelectedItem.ToString();
        }

        #endregion GUI Paramters Events

        #region dgv_MathEngine - related behavior

        private void dgv_mathEngine_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int ch = (int)dgv_mathEngine.Rows[e.RowIndex].Cells[0].Value;
            string item = (string)dgv_mathEngine.Rows[e.RowIndex].Cells[1].Value;
            MathEngineHandler.ReconfigTask(e.RowIndex, ch, item);
        }

        private void dgv_mathEngine_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgv_mathEngine.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "Add Measure Item")
            {
                if (device.SelectedChannels.Length != 0)
                {
                    MathEngineHandler.AddTask(device.SelectedChannels[0], MathEngineHandler.Items.ElementAt(0));
                }
            }
            else
            {
                if (dgv_mathEngine.Rows.Count != 0)
                {
                    MathEngineHandler.RemoveTask(this.rowIndex);
                }
            }
        }

        private void dgv_mathEngine_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    this.dgv_mathEngine.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.dgv_mathEngine.CurrentCell = this.dgv_mathEngine.Rows[e.RowIndex].Cells[1];
                }
            }
        }

        #endregion dgv_MathEngine - related behavior

    }
}