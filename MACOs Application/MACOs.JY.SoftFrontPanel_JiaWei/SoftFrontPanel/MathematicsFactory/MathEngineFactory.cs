
namespace MACOs.JY.SoftFrontPanel
{
    public class MathEngineFactory
    {

        public static MathLibraries CreateTask(int ch, string item,string library)
        {
            MathLibraries template;

            //if new test library is added, MUST add new case here!!!!!!!!!
            switch (library)
            {
                case "JXMathLibrary":
                    template = new JXMathLibrary(item);
                    template.ChNum = ch;
                    break;
                case "JYMathLibrary":
                    template = new JYMathLibrary(item);
                    template.ChNum = ch;
                    break;
                default:
                    return null;
            }
            return template;
        }

    }
}
