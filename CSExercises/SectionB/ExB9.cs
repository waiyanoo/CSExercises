using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input Distance");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:#.#}", CalculateFare(distance));
            
        }

        public static double CalculateFare(double distance)
        {
            double fare = 2.4 + distance * 0.4;
            return Math.Ceiling(fare * 10) / 10;
            
        }
        
    }
}
