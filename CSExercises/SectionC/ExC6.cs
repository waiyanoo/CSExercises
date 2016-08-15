using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            Console.Write("Please quantity for TV");
            int TV = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please quantity for DVD");
            int DVD = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please quantity for MP3");
            int MP3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}", CalculateTotalPrice(TV, DVD, MP3));


        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            double totalprice = 0;
            int priceforTV = tvQty * 900;
            int priceforDVD = dvdQty * 500;
            int priceforMP3 = mp3Qty * 700;
            int inttotal = priceforTV + priceforDVD + priceforMP3;
            if (inttotal > 5000 && inttotal < 10000)
            {
                totalprice = priceforTV - (priceforTV * 0.1) + priceforDVD - (priceforDVD * 0.1) + priceforMP3;
            }
            else if (inttotal >10000)
            {
                totalprice = priceforTV - (priceforTV * 0.15) + priceforDVD - (priceforDVD * 0.15) + priceforMP3;
            }
            else
            {
                totalprice = priceforTV + priceforDVD + priceforMP3;
            }
            
            return totalprice;



        }
    }
}