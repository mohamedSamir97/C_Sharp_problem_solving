using System;
 
namespace Watermelon
{
    class Program
    {
        static void Main(string[] args)
        {
            int w;
            w= Convert.ToInt32(Console.ReadLine());
            if (w%2==0 && w!=2)
            {
                Console.WriteLine("YES");
            }
            else
                Console.WriteLine("NO");
 
        }
    }
}
