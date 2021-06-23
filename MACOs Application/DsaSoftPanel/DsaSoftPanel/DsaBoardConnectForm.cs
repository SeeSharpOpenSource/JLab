using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DsaSoftPanel.AITask;
using DsaSoftPanel.Enumeration;

namespace DsaSoftPanel
{
    public partial class DsaBoardConnectForm : Form
    {
        private SoftPanelGlobalInfo _globalInfo;

        public DsaBoardConnectForm()
        {
            InitializeComponent();
            _globalInfo = SoftPanelGlobalInfo.GetInstance();
        }

        private void DsaBoardConnectForm_Load(object sender, EventArgs e)
        {
            led_status.Value = _globalInfo.BoardConnected;

            metroComboBox_boardType.Items.Clear();
            metroComboBox_boardType.Items.AddRange(Enum.GetNames(typeof (BoardType)));
            metroComboBox_boardType.Text = _globalInfo.BoardType.ToString();

            metroComboBox_cardId.Text = _globalInfo.BoardId.ToString();
        }


        private void button_connect_Click(object sender, EventArgs e)
        {
            try
            {
                BoardType selectType = (BoardType) Enum.Parse(typeof (BoardType), metroComboBox_boardType.Text);
                int boardId = int.Parse(metroComboBox_cardId.Text);
                if (_globalInfo.BoardConnected && selectType == _globalInfo.BoardType && _globalInfo.BoardId == boardId)
                {
                    _globalInfo.MainForm.Show();
                    Dispose();
                    return;
                }
                switch (selectType)
                {
                    case BoardType.JYPCI69527:
                        _globalInfo.AITask = new JYPCI69527AITaskImpl(boardId);
                        break;
                    case BoardType.JYPCI69527L:
                        _globalInfo.AITask = new JYPCI69527LAITaskImpl(boardId);
                        break;
                    case BoardType.JYPXI69527:
                        _globalInfo.AITask = new JYPXI69527AITaskImpl(boardId);
                        break;
                    case BoardType.JYPXIe69529:
                        _globalInfo.AITask = new JYPXIe69529AITaskImpl(boardId);
                        break;
                    case BoardType.JYUSB62405:
                        _globalInfo.AITask = new JYUSB62405AITaskImpl(boardId);
                        break;
                    default:
                        throw new NotSupportedException("Not supported");
                }
                led_status.Value = true;
                _globalInfo.AITask.SetSampleRate(_globalInfo.AITask.MaxSampleRate);
                _globalInfo.BoardConnected = true;
                _globalInfo.MainForm.Show();
                this.Dispose();
            }
            catch (Exception ex)
            {
                led_status.Value = false;
                _globalInfo.BoardConnected = false;
                MessageBox.Show(ex.Message);
            }
        }


        private void button_cancel_Click(object sender, EventArgs e)
        {
            if (_globalInfo.BoardConnected)
            {
                _globalInfo.MainForm.Show();
                this.Dispose();
            }
            else
            {
                this.Dispose();
                _globalInfo.MainForm.Dispose();
            }
            
        }

        private void RefreshLedStatus(object sender, EventArgs e)
        {
            if (_globalInfo.BoardConnected && metroComboBox_boardType.Text.Equals(_globalInfo.BoardType.ToString()) &&
                metroComboBox_cardId.Text.Equals(_globalInfo.BoardId.ToString()))
            {
                led_status.Value = true;
            }
            else
            {
                led_status.Value = false;
            }
        }
    }
}
