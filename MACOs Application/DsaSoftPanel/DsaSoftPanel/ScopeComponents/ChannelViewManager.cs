using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DsaSoftPanel.Enumeration;
using DsaSoftPanel.ViewComponents;
using MetroFramework.Controls;
using SeeSharpTools.JY.GUI;

namespace DsaSoftPanel.ScopeComponents
{
    public class ChannelViewManager
    {
        private readonly SoftPanelGlobalInfo _globalInfo;
        private readonly TabControl _parentControl;
        private readonly DsaSoftPanelForm _parentForm;
        private readonly List<ChannelConfig> _configData = new List<ChannelConfig>(Constants.MaxChannelCount);
        private readonly List<Label> _channelButtons = new List<Label>(Constants.MaxChannelCount); 
        private List<StatisticPanel> _statisticPanels = new List<StatisticPanel>(Constants.MaxChannelCount); 

        public ChannelViewManager(DsaSoftPanelForm parentForm, params Label[] channelButtons)
        {
            this._parentForm = parentForm;
            this._parentControl = parentForm.txTabControl_channel;
            this._globalInfo = SoftPanelGlobalInfo.GetInstance();
            this._globalInfo.ShowRange = ShowMaxAndMin;
            // to fix init error
            _parentControl.TabPages.Clear();
            _parentControl.SelectedIndex = 0;
            foreach (Label channelButton in channelButtons)
            {
                channelButton.Click += ChannelButtonOnClick;
                _channelButtons.Add(channelButton);
            }
        }

        private void ChannelButtonOnClick(object sender, EventArgs eventArgs)
        {
            Label label = sender as Label;
            int index = -1;
            
            if (null != label && (index = _channelButtons.IndexOf(label)) >= 0)
            {
                _configData[index].Enabled = !_configData[index].Enabled;
                RefreshChannelButtonStatus(index);
                if (_configData[index].Enabled)
                {
                    _statisticPanels[index].Show();
                    _statisticPanels[index].IsShown = false;
                }
                else
                {
                    _statisticPanels[index].Hide();
                    _statisticPanels[index].IsShown = false;
                }
                int seriesIndex = 0;
                foreach (ChannelConfig channelConfig in _configData)
                {
                    if (channelConfig.Enabled)
                    {
                        _parentForm.easyChartX_data.Series[seriesIndex].Color = Constants.Palette[channelConfig.ChannelId];
                        _parentForm.easyChartX_function.Series[seriesIndex].Color =
                            Constants.Palette[channelConfig.ChannelId];
                        seriesIndex++;
                    }
                }
                _globalInfo.ApplyConfigInRunTime.Invoke();
            }
        }

        public void AdaptChannelConfigView()
        {
            int totalChannelCount = _globalInfo.AITask.GetChannelCount();
            while (totalChannelCount != _globalInfo.Channels.Count)
            {
                int currentCount = _globalInfo.Channels.Count;
                if (totalChannelCount > currentCount)
                {
                    CreateChannelTabPage(currentCount + 1);
                    _globalInfo.Channels.Add(new ChannelConfig(currentCount));
                }
                else
                {
                    _parentControl.TabPages.RemoveAt(currentCount - 1);
                    _parentControl.TabPages.RemoveAt(currentCount - 1);
                    _globalInfo.Channels.RemoveAt(currentCount - 1);
                }
            }
            _configData.Clear();
            for (int i = 0; i < totalChannelCount; i++)
            {
                _configData.Add(new ChannelConfig());
                // 替换板卡后默认只有第一个通道开启
                _globalInfo.Channels[i].Enabled = (0 == i);
                _globalInfo.Channels[i].Clone(_configData[i]);
                _channelButtons[i].Text = string.Format(Constants.ChannelLabelFormat, i + 1);
                RefreshChannelButtonStatus(i);
                _parentControl.TabPages[i].Enabled = _globalInfo.Channels[i].Enabled;
            }
            for (int i = 0; i < _channelButtons.Count; i++)
            {
                if (i < totalChannelCount)
                {
                    _channelButtons[i].Show();
                }
                else
                {
                    _channelButtons[i].Hide();
                }
            }
            FlowLayoutPanel statisticLayout = _parentForm.flowLayoutPanel_channelInfos;
            for (int channelIndex = 0; channelIndex < _globalInfo.AITask.GetChannelCount(); channelIndex++)
            {
                StatisticPanel statisticPanel = new StatisticPanel(channelIndex);
                statisticPanel.BackColor = Constants.Palette[channelIndex % Constants.Palette.Length];
                _statisticPanels.Add(statisticPanel);
                statisticLayout.Controls.Add(statisticPanel);
            }
            // 默认打开第一个通道
            _statisticPanels[0].Show();
        }

        public void Clear()
        {
            foreach (StatisticPanel statisticPanel in _statisticPanels)
            {
                statisticPanel.Clear();
            }
        }

        private void RefreshChannelButtonStatus(int index)
        {
            _channelButtons[index].BackColor = _configData[index].Enabled ? Constants.Palette[index] :
                    Color.Transparent;
            _parentControl.TabPages[index].Enabled = _configData[index].Enabled;
        }

        public void SyncChannelConfig(out bool isNeedRestartTask, out bool isNeedRefreshView, out bool channelEnabled)
        {
            isNeedRestartTask = false;
            isNeedRefreshView = false;
            channelEnabled = false;
            for (int i = 0; i < _globalInfo.Channels.Count; i++)
            {
                isNeedRestartTask |= _globalInfo.Channels[i].NeedRestartTask(_configData[i]);
                isNeedRefreshView |= _globalInfo.Channels[i].NeedRefreshView(_configData[i]);
                _configData[i].Clone(_globalInfo.Channels[i]);
                channelEnabled |= _globalInfo.Channels[i].Enabled;
            }
            _globalInfo.EnableChannelCount = _globalInfo.Channels.Count(item => item.Enabled);
        }

        private void ShowMaxAndMin(double[] max, double[] min)
        {
            int rangeIndex = 0;
            foreach (StatisticPanel statisticPanel in _statisticPanels)
            {
                if (!_globalInfo.Channels[statisticPanel.ChannelId].Enabled)
                {
                    continue;
                }
                statisticPanel.SetMaxAndMin(max[rangeIndex], min[rangeIndex]);
                rangeIndex++;
            }
        }

        public void ApplyChannelConfig()
        {
            foreach (ChannelConfig channel in _configData.Where(channel => channel.Enabled))
            {
                _globalInfo.AITask.AddChannel(channel.ChannelId, channel.Range, channel.Coupling);
            }
        }

        private void LedChannelEnableOnClick(object sender, EventArgs eventArgs)
        {
            LED led = sender as LED;
            led.Value = !led.Value;
            int selectedIndex = _parentControl.SelectedIndex;
            if (selectedIndex < _configData.Count)
            {
                _configData[selectedIndex].Enabled = led.Value;
                _globalInfo.ApplyConfigInRunTime.Invoke();
            }
        }

        private void ProbeSelectionChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int selectedIndex = _parentControl.SelectedIndex;
            if (selectedIndex < _configData.Count)
            {
                _configData[selectedIndex].Probe = (Probe) Enum.Parse(typeof (Probe), comboBox.Text);
                _globalInfo.ApplyConfigInRunTime.Invoke();
            }
        }

        private void CouplingSelectionChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int selectedIndex = _parentControl.SelectedIndex;
            if (selectedIndex < _configData.Count)
            {
                _configData[selectedIndex].Coupling = (Coupling) Enum.Parse(typeof (Coupling), comboBox.Text);
                _globalInfo.ApplyConfigInRunTime.Invoke();
            }
        }

        private void UnitSelectionChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int selectedIndex = _parentControl.SelectedIndex;
            if (selectedIndex < _configData.Count)
            {
                _configData[selectedIndex].Unit = (UnitType) Enum.Parse(typeof (UnitType), comboBox.Text);
            }
            _globalInfo.ApplyConfigInRunTime.Invoke();
        }

        public void CreateChannelTabPage(int index)
        {
            // 
            // tabPage
            // 
            TabPage tabPage = new TabPage();
            tabPage.AutoScroll = true;
            tabPage.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            tabPage.Location = new System.Drawing.Point(4, 24);
            tabPage.Name = string.Format(Constants.ChannelTabNameFormat, index);
            tabPage.Padding = new System.Windows.Forms.Padding(3);
            tabPage.Size = new System.Drawing.Size(195, 191);
            tabPage.TabIndex = index;
            tabPage.Text = string.Format(Constants.ChannelLabelFormat, index);

            _parentControl.TabPages.Add(tabPage);
            _parentControl.SelectedIndex = 0;

//            AddChannelEnableLed(tabPage);
            AddCouplingControls(tabPage);
            AddProbeContros(tabPage);
            AddUnitControls(tabPage);
            
        }

        private void AddChannelEnableLed(TabPage tabPage)
        {
            // 
            // led_channelEnable
            // 
            LED led_channelEnable = new LED();
            led_channelEnable.BlinkColor = System.Drawing.Color.Lime;
            led_channelEnable.BlinkInterval = 1000;
            led_channelEnable.BlinkOn = false;
            led_channelEnable.Cursor = System.Windows.Forms.Cursors.Arrow;
            led_channelEnable.Interacton = SeeSharpTools.JY.GUI.LED.InteractionStyle.Indicator;
            led_channelEnable.Location = new System.Drawing.Point(72, 11);
            led_channelEnable.Name = "led_channelEnable";
            led_channelEnable.OffColor = System.Drawing.Color.Black;
            led_channelEnable.OnColor = System.Drawing.Color.Green;
            led_channelEnable.Size = new System.Drawing.Size(43, 33);
            led_channelEnable.Style = SeeSharpTools.JY.GUI.LED.LedStyle.Rectangular3D;
            led_channelEnable.TabIndex = 11;
            led_channelEnable.Value = false;

            led_channelEnable.Click += LedChannelEnableOnClick;

            tabPage.Controls.Add(led_channelEnable);
        }
        
        private void AddCouplingControls(TabPage tabPage)
        {
            // 
            // label_Coupling
            // 
            Label labelCoupling = new Label();
            // 
            // label_Coupling
            // 
            labelCoupling.ForeColor = System.Drawing.Color.Silver;
            labelCoupling.Location = new System.Drawing.Point(17, 57);
            labelCoupling.Name = "label_Coupling";
            labelCoupling.Size = new System.Drawing.Size(67, 20);
            labelCoupling.TabIndex = 5;
            labelCoupling.Text = "Coupling:";
            labelCoupling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelCoupling.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroComboBox_coupling
            // 
            MetroComboBox metroComboBoxCoupling = new MetroComboBox();
            metroComboBoxCoupling.BackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            metroComboBoxCoupling.DrawMode = DrawMode.OwnerDrawFixed;
            metroComboBoxCoupling.DropDownStyle = ComboBoxStyle.DropDownList;
            metroComboBoxCoupling.FlatStyle = FlatStyle.Flat;
            metroComboBoxCoupling.FontSize = MetroFramework.MetroLinkSize.Small;
            metroComboBoxCoupling.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroComboBoxCoupling.ForeColor = System.Drawing.SystemColors.WindowText;
            metroComboBoxCoupling.FormattingEnabled = true;
            metroComboBoxCoupling.Items.AddRange(Enum.GetNames(typeof(Coupling)));
            metroComboBoxCoupling.ItemHeight = 19;
            metroComboBoxCoupling.Location = new Point(90, 55);
            metroComboBoxCoupling.Name = "metroComboBox_coupling";
            metroComboBoxCoupling.Size = new Size(89, 25);
            metroComboBoxCoupling.Style = MetroFramework.MetroColorStyle.Silver;
            metroComboBoxCoupling.StyleManager = null;
            metroComboBoxCoupling.TabIndex = 11;
            metroComboBoxCoupling.Theme = MetroFramework.MetroThemeStyle.Dark;

            metroComboBoxCoupling.SelectedIndexChanged += new System.EventHandler(CouplingSelectionChanged);
            metroComboBoxCoupling.SelectedIndex = 0;

            tabPage.Controls.Add(labelCoupling);
            tabPage.Controls.Add(metroComboBoxCoupling);
        }

        private void AddProbeContros(TabPage tabPage)
        {
            // 
            // label_probe
            // 
            Label labelProbe = new Label();
            labelProbe.ForeColor = System.Drawing.Color.Silver;
            labelProbe.Location = new System.Drawing.Point(17, 21);
            labelProbe.Name = "label_probe";
            labelProbe.Size = new System.Drawing.Size(67, 20);
            labelProbe.TabIndex = 7;
            labelProbe.Text = "Probe:";
            labelProbe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelProbe.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroComboBox_probe
            // 
            MetroComboBox metroComboBoxProbe = new MetroComboBox();
            metroComboBoxProbe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            metroComboBoxProbe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            metroComboBoxProbe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            metroComboBoxProbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            metroComboBoxProbe.FontSize = MetroFramework.MetroLinkSize.Small;
            metroComboBoxProbe.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroComboBoxProbe.ForeColor = System.Drawing.SystemColors.Info;
            metroComboBoxProbe.FormattingEnabled = true;
            metroComboBoxProbe.ItemHeight = 19;
            metroComboBoxProbe.Items.AddRange(Enum.GetNames(typeof(Probe)));
            metroComboBoxProbe.Location = new System.Drawing.Point(90, 19);
            metroComboBoxProbe.Name = "metroComboBox_probe";
            metroComboBoxProbe.Size = new System.Drawing.Size(89, 25);
            metroComboBoxProbe.Style = MetroFramework.MetroColorStyle.Silver;
            metroComboBoxProbe.StyleManager = null;
            metroComboBoxProbe.TabIndex = 0;
            metroComboBoxProbe.Theme = MetroFramework.MetroThemeStyle.Dark;

            metroComboBoxProbe.SelectedIndexChanged += new System.EventHandler(ProbeSelectionChanged);
            metroComboBoxProbe.SelectedIndex = 0;

            tabPage.Controls.Add(labelProbe);
            tabPage.Controls.Add(metroComboBoxProbe);
        }

        private void AddUnitControls(TabPage tabPage)
        {
            // 
            // label_Unit
            // 
            Label labelUnit = new Label();
            labelUnit.ForeColor = System.Drawing.Color.Silver;
            labelUnit.Location = new System.Drawing.Point(17, 92);
            labelUnit.Name = "label_Unit";
            labelUnit.Size = new System.Drawing.Size(67, 20);
            labelUnit.TabIndex = 9;
            labelUnit.Text = "Unit:";
            labelUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelUnit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroComboBox_unit
            // 
            MetroComboBox metroComboBoxUnit = new MetroComboBox();
            metroComboBoxUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            metroComboBoxUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            metroComboBoxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            metroComboBoxUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            metroComboBoxUnit.FontSize = MetroFramework.MetroLinkSize.Small;
            metroComboBoxUnit.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            metroComboBoxUnit.ForeColor = System.Drawing.SystemColors.WindowText;
            metroComboBoxUnit.FormattingEnabled = true;
            metroComboBoxUnit.Items.AddRange(Enum.GetNames(typeof(UnitType)));
            metroComboBoxUnit.ItemHeight = 19;
            metroComboBoxUnit.Location = new System.Drawing.Point(90, 90);
            metroComboBoxUnit.Name = "metroComboBox_unit";
            metroComboBoxUnit.Size = new System.Drawing.Size(89, 25);
            metroComboBoxUnit.Style = MetroFramework.MetroColorStyle.Silver;
            metroComboBoxUnit.StyleManager = null;
            metroComboBoxUnit.TabIndex = 12;
            metroComboBoxUnit.Theme = MetroFramework.MetroThemeStyle.Dark;

            metroComboBoxUnit.SelectedIndexChanged += new System.EventHandler(UnitSelectionChanged);
            metroComboBoxUnit.SelectedIndex = 0;

            tabPage.Controls.Add(labelUnit);
            tabPage.Controls.Add(metroComboBoxUnit);
        }
    }
}