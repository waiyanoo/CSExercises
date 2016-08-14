using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {   
            String aas = Console.ReadLine();
            String bs = Console.ReadLine();
            String cs = Console.ReadLine();
            double a = Convert.ToDouble(aas);
            double b = Convert.ToDouble(bs);
            double c = Convert.ToDouble(cs);
            double result =CalculateArea(a, b, c);
            if(double.IsNaN(result))
            {
                Console.WriteLine("The area is can't calculated");
            }
            else
            {
                Console.WriteLine("The area is {0}", result);
            }
            

        }

        public static double CalculateArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double calresult = Math.Sqrt(s*(s - a)*(s - b)*(s - c));
            return calresult;
        }
    }
}