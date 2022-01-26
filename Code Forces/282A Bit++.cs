using System;
namespace problem_solving_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfStatements = Convert.ToInt32(Console.ReadLine());
            string[] lines = new string[numOfStatements];
            int x = 0; 
            for (int i = 0; i < numOfStatements; i++)
            {
                lines[i] = Console.ReadLine();
            }
 
            for (int i = 0; i < numOfStatements; i++)
            {
                if (lines[i].Contains("++"))
                {
                    x++;
                }
                else if (lines[i].Contains("--"))
                {
                    x--;
                }
            }
            Console.WriteLine(x);
        }
    }
}
