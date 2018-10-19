namespace DsaSoftPanel.Enumeration
{
    public enum TaskStatus
    {
        /// <summary>
        /// 空闲状态
        /// </summary>
        Idle = 0,

        /// <summary>
        /// 等待触发状态
        /// </summary>
        Trigger = 1,

        /// <summary>
        /// 运行状态
        /// </summary>
        Running = 2,

        /// <summary>
        /// 错误
        /// </summary>
        Error = 3
    }
}