using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples.Basics
{
    internal class CelciusToFahrenheit
    {
        //Authors: Mitchell Flowitt
        //Generates a random temperature in celcius and displays it converted to fahrenheit
        public static void run()
        {
            Random random = new Random();
            double c = random.Next(0, 30);
            double f = (c * 1.8) + 32;
            Console.WriteLine(c + " degrees celcius = " + f + " degrees fahrenheit");
        }
    }
}
