using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
           // String input = Console.ReadLine
            double num = Convert.ToDouble(Console.ReadLine());
            double result = SQRT(num);
            Console.WriteLine(result);
        }

        public static double SQRT(double x)
        {
            double res = Math.Sqrt(x);
            return res;

        }
    }
}
