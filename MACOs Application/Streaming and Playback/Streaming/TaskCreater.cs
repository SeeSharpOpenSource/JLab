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
                case BoardType.JYUSB62405:
                    return new JYUSB62405(boardNum);
                case BoardType.JYPXI62022:
                    return new JYPXI62022(boardNum);
                case BoardType.JYPXI62204:
                    return new JYPXI62204(boardNum);
                case BoardType.JYPCI69846D:
                    return new JYPCI69846D(boardNum);
                case BoardType.JYPCI69846H:
                    return new JYPCI69846H(boardNum);
                case BoardType.JYPCIE69814:
                    return new JYPCIE69814(boardNum);
                case BoardType.JYPCIE69834:
                    return new JYPCIE69834(boardNum);
                case BoardType.JYPCIE69852:
                    return new JYPCIE69852(boardNum);
                case BoardType.JYPXI69527:
                    return new JYPXI69527(boardNum);
                case BoardType.JYPXIe69529:
                    return new JYPXIe69529(boardNum);
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
        JYUSB62405,

        /// <summary>
        /// 
        /// </summary>
        JYPXI62022,

        /// <summary>
        /// 
        /// </summary>
        JYPXI62204,

        /// <summary>
        /// 
        /// </summary>
        JYPCI69846D,

        /// <summary>
        /// 
        /// </summary>
        JYPCI69846H,

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
        JYPXI69527,

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
        JYPXIe69529,

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
