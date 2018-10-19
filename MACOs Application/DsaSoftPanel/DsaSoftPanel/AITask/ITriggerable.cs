namespace DsaSoftPanel.AITask
{
    public interface ITriggerable
    {
        bool TriggerEnabled { get; }

        /// <summary>
        /// 触发模式，如果不支持返回null
        /// </summary>
        string TriggerMode { get; set; }

        /// <summary>
        /// 触发类型，如果不支持返回null
        /// </summary>
        string TriggerType { get; set; }

        /// <summary>
        /// 模拟触发源，如果不支持返回null
        /// </summary>
        string AnalogTriggerSource { get; set; }

        /// <summary>
        /// 模拟触发条件，如果不支持返回null
        /// </summary>
        string AnalogTriggerCondition { get; set; }

        /// <summary>
        /// 模拟触发阈值，如果不支持返回double.NaN
        /// </summary>
        double AnalogTriggerThreshold { get; set; }

        /// <summary>
        /// 数字触发源，如果不支持返回null
        /// </summary>
        string DigitalTriggerSource { get; set; }

        /// <summary>
        /// 数字触发边沿，如果不支持返回null
        /// </summary>
        string DigitalTriggerEdge { get; set; }

        /// <summary>
        /// 获取板卡支持的所有触发模式，如果不支持则返回null
        /// </summary>
        string[] GetTriggerModes();

        /// <summary>
        /// 获取板卡支持的所有触发类型，如果不支持则返回null
        /// </summary>
        string[] GetTriggerTypes();

        /// <summary>
        /// 获取板卡支持的所有模拟触发源，如果不支持则返回null
        /// </summary>
        string[] GetAnalogTriggerSources();

        /// <summary>
        /// 获取板卡支持的所有模拟触发条件，如果不支持则返回null
        /// </summary>
        string[] GetAnalogTriggerConditions();

        /// <summary>
        /// 获取板卡支持的所有数字触发源，如果不支持则返回null
        /// </summary>
        string[] GetDigitalTriggerSources();

        /// <summary>
        /// 获取板卡支持的所有数字触发沿，如果不支持则返回null
        /// </summary>
        string[] GetDigitalTriggerEdge();
    }
}