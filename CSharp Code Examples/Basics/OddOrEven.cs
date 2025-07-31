using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples.Basics
{
    internal class OddOrEven
    {
        //Authors: Mitchell Flowitt
        //Generates a random number and prints if it is odd or even
        public static void run()
        {
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                int a = random.Next(1, 10);
                if (a % 2 == 0)
                {
                    Console.WriteLine(a + " is even");
                }
                else
                {
                    Console.WriteLine(a + " is odd");
                }
            }
        }
    }
}
