using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100�999.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter 3 Digit integer");
            int n = Convert.ToInt32(Console.ReadLine());
            if (IsArmstrongNumber(n))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }


        public static bool IsArmstrongNumber(int n)
        {
            bool r = false;
            int firstdig = n / 100;
            int seconddig = (n / 10)%10;
            int lastdig = n % 10;
            double checkno = Math.Pow(firstdig, 3) + Math.Pow(seconddig, 3) + Math.Pow(lastdig, 3);
            Console.WriteLine(checkno);
            if (checkno == n)
            {
                r = true;
            }
            else r = false;
            return r;

        }
    }
}