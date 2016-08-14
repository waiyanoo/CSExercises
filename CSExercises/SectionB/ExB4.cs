using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would convert temperature given in Centigrade 
    //scale to Fahrenheit – the number can be integer or real.  Use the formula:
    //	F = 1.8C  + 32

    public class ExB4
    {
        public static void Main(string[] args)
        {
            double C = Convert.ToDouble( Console.ReadLine());
            double F = ConvertToFahrenheit(C);
            Console.WriteLine("The Temp Fahrenheit is {0}", F);

        }

        public static double ConvertToFahrenheit(double c)
        {
            double f = (1.8*c) + 32;
            return f;

        }
    }
}
