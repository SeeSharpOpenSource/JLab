using System;

namespace MACOs.JY.Streaming
{
    /// <summary>
    /// Create task class
    /// </summary>
    public class TaskCreater
    {
        /// <summary>
        /// Create respective task using bordNum and boardType
        /// </summary>
        /// <param name="boardNum">board number</param>
        /// <param name="boardType">board type</param>
        /// <returns></returns>
        public static StreamingTask CreateDAQTask(int boardNum, BoardType boardType)
        {
            switch (boardType)
            {
                case BoardType.JYUSB61902:
                    return new JYUSB61902(boardNum);
                case BoardType.JYPXI62204:
                    return new JYPXI62204(boardNum);
                case BoardType.JYPCIE69814:
                    return new JYPCIE69814(boardNum);
                case BoardType.JYPCIE69834:
                    return new JYPCIE69834(boardNum);
                case BoardType.JYPCIE69852:
                    return new JYPCIE69852(boardNum);
                case BoardType.JYPXIE69529:
                    return new JYPXIE69529(boardNum);
                case BoardType.JYPXI9816H:
                    return new JYPXI69816H(boardNum);
                case BoardType.JYPXI69846D:
                    return new JYPXI69846D(boardNum);
                case BoardType.JYPXIE69848H:
                    return new JYPXIE69848H(boardNum); 
                case BoardType.JYPXIE69852:
                    return new JYPXIE69852(boardNum);
                default:
                    throw new Exception("We don't support this card yet!");
            }
        }
    }

    /// <summary>
    /// Hardware list that supports streaming task
    /// </summary>
    public enum BoardType
    {
        /// <summary>
        /// 
        /// </summary>
        JYUSB61902,

        /// <summary>
        /// 
        /// </summary>
        JYPXI62204,

        /// <summary>
        /// 
        /// </summary>
        JYPCIE69814,

        /// <summary>
        /// 
        /// </summary>
        JYPCIE69834,

        /// <summary>
        /// 
        /// </summary>
        JYPCIE69852,

        /// <summary>
        /// 
        /// </summary>
        JYPXI9816H,

        /// <summary>
        /// 
        /// </summary>
        JYPXI69846D,

        /// <summary>
        /// 
        /// </summary>
        JYPXIE69529,

        /// <summary>
        /// 
        /// </summary>
        JYPXIE69848H,

        /// <summary>
        /// 
        /// </summary>
        JYPXIE69852,
    }
}
