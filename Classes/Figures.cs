namespace DrawnFigurines.Classes;

public class Figures
{
    public void WorkOfTheFirstCycle(int worker)
        {
            int assistant = worker;
            
            for (int leadingSpaces = 1; leadingSpaces <= worker; leadingSpaces++)
            {
                for (int secondLeadingSpaces = 0;
                     secondLeadingSpaces <= worker;
                     secondLeadingSpaces++)
                {
                    if (secondLeadingSpaces >= assistant)
                        Console.Write("* ");
                    else
                        Console.Write(" ");
                }

                assistant--;
                Console.WriteLine();
            }
        }

        
        public void WorkOfTheSecondCycle(int worker)
        {
            for (int leadingSpaces = 0; leadingSpaces < worker; leadingSpaces++)
            {
                for (int secondLeadingSpaces = 0;
                     secondLeadingSpaces <= leadingSpaces;
                     secondLeadingSpaces++)
                    Console.Write(" ");
                
                for (int thirdLeadingSpaces = 0;
                     thirdLeadingSpaces <= (worker - leadingSpaces) - 1;
                     thirdLeadingSpaces++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }

        
        public void WorkOfTheThirdCycle(int worker)
        {
            for (int leadingSpaces = 0; leadingSpaces < 2 * worker - 1; leadingSpaces++)
            {
                int comparator;
                if (leadingSpaces < worker)
                    comparator = 2 * (worker - leadingSpaces) - 1;//2
                else
                    comparator = 2 * (leadingSpaces - worker + 1) + 1;//2
                
                for(int secondLeadingSpaces = 0; secondLeadingSpaces < comparator; secondLeadingSpaces++)
                    Console.Write(" ");
                for(int thirdLeadingSpaces = 0; thirdLeadingSpaces < 2 * worker - comparator; thirdLeadingSpaces++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
}