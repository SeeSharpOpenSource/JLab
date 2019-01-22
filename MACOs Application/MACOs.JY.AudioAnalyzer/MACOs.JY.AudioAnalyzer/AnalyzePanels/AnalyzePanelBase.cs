using SeeSharpTools.JY.Audio.Analyzer;

namespace MACOs.JY.AudioAnalyzer.AnalyzePanels
{
    public interface AnalyzePanelBase
    {
        string GetAnalyzerName();
        void Start();
        void Stop();
        void Analyze();
        void ShowResult();
        void ClosePanel();
//        void InitComponentTag();
    }
}