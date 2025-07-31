using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples.Basics
{
    internal class ChooseProgram
    {
        //Authors: Mitchell Flowitt
        //Allows for a choice of which programs to run
        public static void run()
        {
            Console.WriteLine("select a program to run [1: Maths, 2: HelloLincoln, 3: OddOrEven, 4: CelciusToFahrenheit, 5: All");
            switch (Console.ReadLine())
            {
                case "1":
                    Maths.run(); 
                    break;
                case "2":
                    HelloLincoln.run();
                    break;
                case "3":
                    OddOrEven.run();
                    break;
                case "4":
                    CelciusToFahrenheit.run();
                    break;
                case "5":
                    Maths.run();
                    HelloLincoln.run();
                    OddOrEven.run();
                    CelciusToFahrenheit.run();
                    break;
                default:
                    Console.WriteLine("not a valid selection");
                    break;
            }
        }
    }
}
