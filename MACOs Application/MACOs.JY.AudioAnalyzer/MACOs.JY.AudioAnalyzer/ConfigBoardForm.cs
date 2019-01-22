using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MACOs.JY.AudioAnalyzer.StateMachine;

namespace MACOs.JY.AudioAnalyzer
{
    public partial class ConfigBoardForm : Form
    {
        private GlobalInfo _globalInfo;

        private AudioAnalyzerForm _parentForm;

        public ConfigBoardForm(AudioAnalyzerForm audioAnalyzerForm)
        {
            InitializeComponent();
            this._globalInfo = GlobalInfo.GetInstance();
            this.StartPosition = FormStartPosition.CenterScreen;
            this._parentForm = audioAnalyzerForm;
        }
        
        private void ConfigBoardForm_Load(object sender, EventArgs e)
        {
            InitItems();
            _globalInfo.AppStateMachine.SetConfigBoardFormValues(this);
        }

        private void InitItems()
        {
            string emptyType = BoardType.NULL.ToString();
            foreach (string boardType in Enum.GetNames(typeof (BoardType)))
            {
                if (emptyType.Equals(boardType))
                {
                    continue;
                }
                comboBox_boardSelect.Items.Add(boardType);
            }
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_boardSelect.Text))
            {
                //  TODO i18n
                MessageBox.Show("选择板卡类型");
                return;
            }
            if (BoardStatus.Connected == _globalInfo.AppStateMachine.Status)
            {
                _globalInfo.AITask?.Stop();
                _globalInfo.AOTask?.Stop();
            }
            _globalInfo.BoardType = (BoardType) Enum.Parse(typeof(BoardType), 
                comboBox_boardSelect.Text);
            _globalInfo.BoardId = (int) numericUpDown_boardId.Value;
            try
            {
                _globalInfo.ConnectBoard();
                _parentForm.Enabled = true;
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            _globalInfo.AppStateMachine.SetConfigBoardFormValues(this);
            _globalInfo.AppStateMachine.RefreshAudioForm();
            
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            _globalInfo.AppStateMachine.RefreshAudioForm();
            _parentForm.Enabled = true;
            this.Dispose();
        }

    }
}
