﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges 
    //based on the kilometres travelled.
    //
    //Minimum fixed charge:  $2.40
    //In addition the fare would be computed at 40 cents per kilometer.
    //
    //E.g.If the distance traveled is 3.24 km then the total fare is 2.40 + 3.24 * 0.4

    public class ExB7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input Distance");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Total fare is {0}", CalculateFare(distance));
        }

        public static double CalculateFare(double distance)
        {
            double fare = 2.4 + distance * 0.4;
            return fare;

        }
    }
}
