using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using JYPCI69527;
using MACOs.JY.AudioAnalyzer.AnalyzePanels;
using MACOs.JY.AudioAnalyzer.AnalyzePanels.AnalyzePanelImpl;
using MACOs.JY.AudioAnalyzer.StateMachine;
using SeeSharpTools.JY.Audio.Analyzer;
using SeeSharpTools.JY.Audio.Common;

namespace MACOs.JY.AudioAnalyzer
{
    public partial class AudioAnalyzerForm : Form
    {
        private GlobalInfo _globalInfo;

        public AudioAnalyzerForm()
        {
            InitializeComponent();
        }

        private Thread _acquiringThread;
        private Thread _AnalyzeThread;

        private void button__connect_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Dock = DockStyle.Fill;
            tableLayoutPanel_Analyzer.Controls.Add(button);
        }


        private void AudioAnalyzerForm_Load(object sender, EventArgs e)
        {
            GlobalInfo.CreateInstance(this);
            _globalInfo = GlobalInfo.GetInstance();
            _globalInfo.AppStateMachine.RefreshAudioForm();
            Dictionary<string, string> analyzerInfo = AnalyzerPanelFactory.GetAllAnalyzerNameAndLabel();
            ToolStripItemCollection analyzerItemCollection = toolStripDropDownButton_selectAnalyzer.DropDownItems;
            foreach (string analyzerClass in analyzerInfo.Keys)
            {
                ToolStripMenuItem analyzerItem = new ToolStripMenuItem(analyzerInfo[analyzerClass]);
                analyzerItem.Tag = analyzerClass;
                analyzerItem.Click += Analyzer_ToolStripMenuItem_Click;
                analyzerItemCollection.Add(analyzerItem);
            }
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void toolStripStatusLabel_configBoard_MouseDown(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel_configBoard.BackColor = SystemColors.ControlDark;
            toolStripStatusLabel_configBoard.BorderStyle = Border3DStyle.Sunken;
        }

        private void toolStripStatusLabel_configBoard_MouseUp(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel_configBoard.BackColor = SystemColors.Control;
            toolStripStatusLabel_configBoard.BorderStyle = Border3DStyle.RaisedOuter;
        }

        private void toolStripStatusLabel_configBoard_Click(object sender, EventArgs e)
        {
            ConfigBoardForm configBoardForm = new ConfigBoardForm(this);
            configBoardForm.ShowDialog(this);
        }

        private void Analyzer_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickItem = sender as ToolStripMenuItem;
            if (null != _globalInfo.CurrentAnalyzer && 
                _globalInfo.CurrentAnalyzer.GetAnalyzerName().Equals(clickItem.Tag.ToString()))
            {
                return;
            }
            ToolStripItemCollection analyzerItems = toolStripDropDownButton_selectAnalyzer.DropDownItems;
            foreach (object analyzerItem in analyzerItems)
            {
                ((ToolStripMenuItem) analyzerItem).Checked = false;
            }
            
            clickItem.Checked = true;
            tableLayoutPanel_Analyzer.Controls.Clear();
            //            Form analyzeForm = new SteppedSineWaveCrossTalkAnalyze();
            Form analyzeForm = AnalyzerPanelFactory.CreateAnalyzer(clickItem.Tag.ToString());
            tableLayoutPanel_Analyzer.Controls.Add(analyzeForm);
            analyzeForm.Show();
            _globalInfo.AppStateMachine.AnalyzerStatus = AnalyzeStatus.Idle;
            _globalInfo.CurrentAnalyzer?.ClosePanel();
            _globalInfo.CurrentAnalyzer = analyzeForm as AnalyzePanelBase;
            label_analyzeName.Text = clickItem.Text;
            numericUpDown_delaySamples.Value = 0;

        }

        const int ErrorCardNotRegistered = -4;
        private void button_test_Click(object sender, EventArgs e)
        {
            if (BoardStatus.Disconnect == _globalInfo.AppStateMachine.Status || null == _globalInfo.CurrentAnalyzer)
            {
                return;
            }
            _globalInfo.AppStateMachine.SetOperationStatus(AnalyzeStatus.DataAcquisition);
            _acquiringThread = new Thread(StartDataAcquiring);
            _acquiringThread.IsBackground = true;
            _acquiringThread.Start();
        }

        private void StartDataAcquiring()
        {
            try
            {
                _globalInfo.CurrentAnalyzer.Start();
                _globalInfo.AppStateMachine.Flip(true);
            }
            catch (JYDriverException ex)
            {
                if (ex.ErrorCode == ErrorCardNotRegistered)
                {
                    _globalInfo.AppStateMachine.Status = BoardStatus.Disconnect;
                }
                Invoke(new Action<string, string>(ShowErrMsg), "Driver Error", ex.Message);
                _globalInfo.AppStateMachine.Flip(false);
            }
            catch (Exception ex)
            {
                Invoke(new Action<string, string>(ShowErrMsg), "Runtime Error", ex.Message);
                _globalInfo.AppStateMachine.Flip(false);
            }
            finally
            {
                _globalInfo.AITask?.Stop();
                _globalInfo.AOTask?.Stop();
            }
        }

        private void button_analyze_Click(object sender, EventArgs e)
        {
            if (BoardStatus.Disconnect == _globalInfo.AppStateMachine.Status || null == _globalInfo.CurrentAnalyzer)
            {
                return;
            }
            _globalInfo.AppStateMachine.SetOperationStatus(AnalyzeStatus.Analyze);
            _AnalyzeThread = new Thread(AnalyzeAndShowResult);
            _AnalyzeThread.IsBackground = true;
            _AnalyzeThread.Start();
        }

        private void AnalyzeAndShowResult()
        {
            try
            {
                AnalyzePanelBase analyzer = _globalInfo.CurrentAnalyzer;
                analyzer.Analyze();
                this.Invoke(new Action(analyzer.ShowResult));
                _globalInfo.AppStateMachine.Flip(true);
            }
            catch (SeeSharpAudioException ex)
            {
                Invoke(new Action<string, string>(ShowErrMsg), "Analyze Failed", ex.Message);
                _globalInfo.AppStateMachine.Flip(false);
            }
            catch (Exception ex)
            {
                Invoke(new Action<string, string>(ShowErrMsg), "Runtime Error", ex.Message);
                _globalInfo.AppStateMachine.Flip(false);
            }
            finally
            {
                // TODO
//                _globalInfo.AppStateMachine.RefreshAudioForm();
            }

        }

        private void ShowErrMsg(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        public new void Dispose()
        {
            _globalInfo.AITask?.Stop();
            _globalInfo.AOTask?.Stop();
            base.Dispose();
        }

        private void button_trigger_Click(object sender, EventArgs e)
        {
            if (BoardStatus.Disconnect == _globalInfo.AppStateMachine.Status)
            {
                return;
            }
            TriggerConfigForm triggerConfigForm = new TriggerConfigForm();
            triggerConfigForm.ShowDialog(this);
        }

        private void numericUpDown_delaySamples_ValueChanged(object sender, EventArgs e)
        {
            _globalInfo.DelaySamples = (uint) numericUpDown_delaySamples.Value;
        }

        const int CloseTimeOut = 500;
        private void AudioAnalyzerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopThread(_acquiringThread);
            StopThread(_AnalyzeThread);
            _globalInfo.CurrentAnalyzer?.ClosePanel();
        }

        private static void StopThread(Thread thread)
        {
            try
            {
                if (null != thread && ThreadState.Running == thread.ThreadState && !thread.Join(CloseTimeOut))
                {
                    thread.Abort();
                }
            }
            catch
            {
                //ignore
            }
        }
    }
}
