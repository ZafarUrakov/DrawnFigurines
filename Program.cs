using DrawnFigurines.Classes;

namespace DrawnFigurines
{
    class Program
    {
        static void Main(string[] args)
        {
            var figures = new Figures();
            string triangleSize = Messages.GetUserValueByMassage("Hello!\nSize: ");
            int triangleSizeToConvert = Convert.ToInt32(triangleSize);
            figures.WorkOfTheFirstCycle(triangleSizeToConvert);
            Messages.GetUserValueByMassage("\nYour answer is ready, press enter..\n");
            Messages.GetUserValueByMassage("\nPress enter..\n");
            figures.WorkOfTheSecondCycle(triangleSizeToConvert);
            Messages.GetUserValueByMassage("\nDo you want to see the rhombus, press enter..\n");
            figures.WorkOfTheThirdCycle(triangleSizeToConvert);
            Messages.GetUserValueByMassage("\nUntil we meet again, I was glad to show my skills.\nExit..");
        }
    }
}