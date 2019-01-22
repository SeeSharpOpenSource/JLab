using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace MACOs.JY.AudioAnalyzer.AnalyzePanels
{
    public static class AnalyzerPanelFactory
    {
        private static Assembly _assembly = Assembly.GetExecutingAssembly();
        private const string _analyzerNamespace = "MACOs.JY.AudioAnalyzer.AnalyzePanels.AnalyzePanelImpl";
//        private const string _panelBaseClass = "MACOs.JY.AudioAnalyzer.AnalyzePanels.AnalyzePanelBase";

        public static Form CreateAnalyzer(string analyzerName)
        {
            Type formType = _assembly.GetType($"{_analyzerNamespace}.{analyzerName}", true, false);
            object analyzerInst = Activator.CreateInstance(formType);
            return analyzerInst as Form;
        }

        public static Dictionary<string, string> GetAllAnalyzerNameAndLabel()
        {
            Dictionary<string, string> analyzerInfo = new Dictionary<string, string>();
            foreach (Type type in _assembly.GetTypes())
            {
                if (_analyzerNamespace.Equals(type.Namespace))
                {
                    analyzerInfo[type.Name] = type.Name;
                }
            }
            return analyzerInfo;
        }
    }
}