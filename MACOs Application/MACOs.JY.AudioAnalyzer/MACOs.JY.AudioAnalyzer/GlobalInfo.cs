using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using MACOs.JY.AudioAnalyzer.StateMachine;
using MACOs.JY.AudioAnalyzer.AITask;
using MACOs.JY.AudioAnalyzer.AnalyzePanels;
using MACOs.JY.AudioAnalyzer.AOTask;


namespace MACOs.JY.AudioAnalyzer
{
    internal class GlobalInfo
    {
        public const int ReadTimeOut = 10000;

        public static double ExtraReadTime
        {
            get
            {
                const double triggerExtraReadTime = 1.2;
                const double noTrigExtraReadTime = 1.5;
                if (TriggerType.Immediate != GetInstance().AITask.TrigType)
                {
                    
                    return triggerExtraReadTime;
                }
                else
                {
                    return noTrigExtraReadTime;
                }
            }
        }

        public AppStateMachine AppStateMachine { get; private set; }

        public AITask.AITask AITask;
        public AOTask.AOTask AOTask;

        public uint DelaySamples { get; set; }

        public AudioAnalyzerForm Mainform { get; private set; }
        public AnalyzePanelBase CurrentAnalyzer { get; set; }

        internal BoardType BoardType { get; set; }
        internal int BoardId { get; set; }

        private static GlobalInfo _instance = null;

        public static void CreateInstance(AudioAnalyzerForm audioAnalyzerForm)
        {
            if (null == _instance)
            {
                _instance = new GlobalInfo(audioAnalyzerForm);
            }
        }

        public static GlobalInfo GetInstance()
        {
            return _instance;
        }

        private GlobalInfo(AudioAnalyzerForm audioAnalyzerForm)
        {
            AppStateMachine = new AppStateMachine(this, audioAnalyzerForm);
            this.BoardType = BoardType.NULL;
            this.Mainform = audioAnalyzerForm;
        }

        public void ConnectBoard()
        {
            try
            {
                switch (BoardType)
                {
                    case BoardType.JYPCI69527:
                        AITask = new JYPCI69527AITaskImpl(BoardId);
                        AOTask = new JYPCI69527AOTaskImpl(BoardId);
                        break;
                    case BoardType.JYPXI69527:
                        AITask = new JYPXI69527AITaskImpl(BoardId);
                        AOTask = new JYPXI69527AOTaskImpl(BoardId);
                        break;
                        case BoardType.JYUSB61902:
                        AITask = new JYUSB61902AITaskImpl(BoardId);
                        AOTask = new JYUSB61902AOTaskImpl(BoardId);
                        break;
                }
                this.AppStateMachine.Status = BoardStatus.Connected;
            }
            catch (Exception)
            {
                this.AppStateMachine.Status = BoardStatus.Disconnect;
                throw;
            }
        }


    }
}
