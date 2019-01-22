using System;
using System.Linq;
using System.Windows.Forms;
using MACOs.JY.AudioAnalyzer.AnalyzePanels.AnalyzePanelImpl;
using MACOs.JY.AudioAnalyzer.GeneratorPanel.GeneratorImpl;

namespace MACOs.JY.AudioAnalyzer.GeneratorPanel
{
    public class GeneratorPanelFactory
    {
        private static GeneratorPanelFactory _inst;

        public static GeneratorPanelFactory GetInstance()
        {
            if (null == _inst)
            {
                _inst = new GeneratorPanelFactory();
            }
            return _inst;
        }

        private Panel _currentPanel;

        private GeneratorPanelFactory()
        {
            
        }

        public static Form GetGenerator(string typeName)
        {
            GeneratorType selectType;
            return Enum.TryParse(typeName, out selectType) ? GetGenerator(selectType) : null;
        }

        public static Form GetGenerator(GeneratorType type)
        {
            Form generatorPanel = null;
            switch (type)
            {
                case GeneratorType.AribitraryWaveform:
                    break;
                case GeneratorType.FromWavFile:
                    break;
                case GeneratorType.LogChirpWaveform:
                    generatorPanel = new LogChripWaveForm();
                    break;
                case GeneratorType.MultiToneWaveform:
                    generatorPanel = new MultiToneWaveForm();
                    break;
                case GeneratorType.SingleToneWaveForm:
                    generatorPanel =  new SingleToneWaveForm();
                    break;
                case GeneratorType.DualToneWaveForm:
                    generatorPanel = new DualToneWaveForm();
                    break;
                case GeneratorType.SteppedLevelSineWaveform:
                    generatorPanel = new SteppedLevelSineWaveform();
                    break;
                case GeneratorType.SteppedSineWaveform:
                    generatorPanel = new SteppedSineWave();
                    break;
                default:
                    break;
            }
            return generatorPanel;
        }

        public void InitGeneratorSelector(ComboBox selector, Panel dispPanel, params GeneratorType[] invalidTypes)
        {
            string[] values = Enum.GetNames(typeof (GeneratorType));
            foreach (string typeName in values)
            {
                if (!invalidTypes.Any(invalidType => typeName.Equals(invalidTypes.ToString())))
                {
                    selector.Items.Add(typeName);
                }
            }
            _currentPanel = dispPanel;
            selector.SelectedIndexChanged += ChangeGenerator;
            if (selector.Items.Count > 0)
            {
                selector.SelectedIndex = 0;
            }
        }

        private void ChangeGenerator(object sender, EventArgs e)
        {
            _currentPanel.Controls.Clear();
            ComboBox selector = sender as ComboBox;
            Form generator = GetGenerator(selector.Text);
            if (null == generator || null == _currentPanel)
            {
                return;
            }
            _currentPanel.Controls.Add(generator);
            generator.Show();
        }
    }
}