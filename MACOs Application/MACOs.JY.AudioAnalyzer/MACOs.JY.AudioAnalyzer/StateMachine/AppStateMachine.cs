using System;
using System.Drawing;
using System.Windows.Forms;

namespace MACOs.JY.AudioAnalyzer.StateMachine
{
    internal class AppStateMachine
    {
        private GlobalInfo _globalInfo;
        private AudioAnalyzerForm _audioAnalyzerForm;
        private bool _taskRunning;

        internal BoardStatus Status {
            get { return _boardStatus; }
            set
            {
                _boardStatus = value;
                if (_audioAnalyzerForm.InvokeRequired)
                {
                    _audioAnalyzerForm.Invoke(new Action(RefreshAudioForm));
                }
                else
                {
                    RefreshAudioForm();
                }
            }
        }
        private BoardStatus _boardStatus;
        internal AnalyzeStatus AnalyzerStatus {
            get { return _analyzeStatus; }
            set
            {
                _analyzeStatus = value;
                if (_audioAnalyzerForm.InvokeRequired)
                {
                    _audioAnalyzerForm.Invoke(new Action(RefreshAudioForm));
                }
                else
                {
                    RefreshAudioForm();
                }
            }
        }
        private AnalyzeStatus _analyzeStatus;

        public AppStateMachine(GlobalInfo globalInfo, AudioAnalyzerForm audioAnalyzerForm)
        {
            _boardStatus = BoardStatus.Disconnect;
            _analyzeStatus = AnalyzeStatus.Idle;
            this._globalInfo = globalInfo;
            this._audioAnalyzerForm = audioAnalyzerForm;
            this._taskRunning = false;
        }

        public void RefreshAudioForm()
        {
            const string boardDisconnect = "Board Disconnect";
            switch (_boardStatus)
            {
                case BoardStatus.Connected:
                    _audioAnalyzerForm.toolStripStatusLabel_boardStatus.BackColor = SystemColors.Control;
                    _audioAnalyzerForm.toolStripStatusLabel_boardStatus.Text = _globalInfo.BoardType.ToString();

                    _audioAnalyzerForm.button_start.Enabled = !_taskRunning;
                    _audioAnalyzerForm.numericUpDown_delaySamples.Enabled = !_taskRunning;
                    _audioAnalyzerForm.button_trigger.Enabled = !_taskRunning;
                    _audioAnalyzerForm.button_analyze.Enabled = AnalyzerStatus == AnalyzeStatus.DataAcquisition && !_taskRunning;
                    break;

                case BoardStatus.Disconnect:
                    _audioAnalyzerForm.toolStripStatusLabel_boardStatus.BackColor = Color.Red;
                    _audioAnalyzerForm.toolStripStatusLabel_boardStatus.Text = boardDisconnect;

                    _audioAnalyzerForm.button_start.Enabled = false;
                    _audioAnalyzerForm.numericUpDown_delaySamples.Enabled = false;
                    _audioAnalyzerForm.button_trigger.Enabled = false;
                    _audioAnalyzerForm.button_analyze.Enabled = false;
                    break;
            }
            _audioAnalyzerForm.toolStripStatusLabel_configBoard.BackColor = SystemColors.Control;
            _audioAnalyzerForm.toolStripStatusLabel_configBoard.BorderStyle = Border3DStyle.RaisedOuter;
            _audioAnalyzerForm.tableLayoutPanel_Analyzer.Enabled = (BoardStatus.Connected == _boardStatus);
            _audioAnalyzerForm.toolStripDropDownButton_selectAnalyzer.Enabled = (BoardStatus.Connected == _boardStatus);

            _audioAnalyzerForm.toolStripStatusLabel_status.Text = _analyzeStatus.ToString();
        }

        private void DisableAudioForm()
        {
            _audioAnalyzerForm.toolStripStatusLabel_boardStatus.BackColor = SystemColors.Control;
            _audioAnalyzerForm.toolStripStatusLabel_boardStatus.Text = _globalInfo.BoardType.ToString();

            _audioAnalyzerForm.button_start.Enabled = false;
            _audioAnalyzerForm.numericUpDown_delaySamples.Enabled = false;
            _audioAnalyzerForm.button_trigger.Enabled = false;
            _audioAnalyzerForm.button_analyze.Enabled = false;

            _audioAnalyzerForm.toolStripStatusLabel_configBoard.BackColor = SystemColors.Control;
            _audioAnalyzerForm.toolStripStatusLabel_configBoard.BorderStyle = Border3DStyle.RaisedOuter;

            _audioAnalyzerForm.tableLayoutPanel_Analyzer.Enabled = false;

            _audioAnalyzerForm.toolStripDropDownButton_selectAnalyzer.Enabled = false;

            _audioAnalyzerForm.toolStripStatusLabel_status.Text = _analyzeStatus.ToString();
        }

        internal void SetConfigBoardFormValues(ConfigBoardForm configBoardForm)
        {
            configBoardForm.led_boardStatus.Value = (BoardStatus.Connected == _boardStatus);
            if (BoardType.NULL != _globalInfo.BoardType)
            {
                for (int i = 0; i < configBoardForm.comboBox_boardSelect.Items.Count; i++)
                {
                    string itemValue = configBoardForm.comboBox_boardSelect.Items[i].ToString();
                    if (_globalInfo.BoardType.ToString().Equals(itemValue))
                    {
                        configBoardForm.comboBox_boardSelect.SelectedIndex = i;
                        break;
                    }
                }
            }
            _globalInfo.BoardId = (int) configBoardForm.numericUpDown_boardId.Value;
        }

        internal void Flip(bool operationDone)
        {
            this._taskRunning = false;
            if (BoardStatus.Disconnect == _boardStatus)
            {
                // 需要更新界面状态，所以使用属性配置
                AnalyzerStatus = AnalyzeStatus.Idle;
                return;
            }
            // 需要更新界面状态，所以使用属性配置
            switch (_analyzeStatus)
            {
                case AnalyzeStatus.Idle:
                    AnalyzerStatus = operationDone
                        ? AnalyzeStatus.DataAcquisition
                        : AnalyzeStatus.Idle;
                    break;
                case AnalyzeStatus.DataAcquisition:
                    AnalyzerStatus = operationDone
                        ? AnalyzeStatus.DataAcquisition
                        : AnalyzeStatus.Idle;
                    break;
                case AnalyzeStatus.Analyze:
                    AnalyzerStatus = operationDone
                        ? AnalyzeStatus.Idle
                        : AnalyzeStatus.DataAcquisition;
                    break;
                default:
                    break;
            }
        }

        internal void SetOperationStatus(AnalyzeStatus status)
        {
            _analyzeStatus = status;
            this._taskRunning = true;
            if (_audioAnalyzerForm.InvokeRequired)
            {
                _audioAnalyzerForm.Invoke(new Action(DisableAudioForm));
            }
            else
            {
                DisableAudioForm();
            }
        }
    }
}