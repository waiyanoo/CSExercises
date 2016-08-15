using System;

namespace CSExercises
{
    //3.	Write a program that would compute the grade for a mark that the student gets.  The program should take an integer number between 0 and 100 and print the following:
    //You scored 73 marks which is B grade.
    //where 73 is the input and B is calculated by the program.  Use the following table for computing the grades:

    //Marks         Grade
    //80 to 100	    A
    //60 to 79	    B
    //40 to 59	    C
    //0 to 40	    F
    //< 0  	        **Error**
    //> 100	        **Error**

    public class ExC3
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());

            string grade = CalculateGrade(mark);
            Console.WriteLine("You scored {0} marks which is {1} grade.", mark,grade);

        }

        public static string CalculateGrade(int mark)
        {
            string resut = null;
            if (mark > 100)
            {
                resut = "**Error**";
            }
            
            else if (mark >= 0 && mark <=40)
            {
                resut = "F";
            }
            else if (mark >= 40 && mark <= 59)
            {
                resut = "C";
            }
            else if (mark >= 60 && mark <= 79)
            {
                resut = "B";
            }
            else if (mark >= 80 && mark <= 100)
            {
                resut = "A";
            }
            else
            {
                resut = "**Error**";
            }
            return resut;
        }
    }
}