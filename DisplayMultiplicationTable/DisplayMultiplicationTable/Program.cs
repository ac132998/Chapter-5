using System;

namespace DisplayMultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {

            displayAttemptTwo();

        }
        public static void displayAttemptTwo()
        {
            
            int product;
            
           
                for (int m = 1; m < 11; ++m)
                {
                    for (int c = 1; c < 11; ++c)
                    {
                        product = m * c;
                        Console.Write(product + " ");

                       
    
                    }

                }
 



        }
        public static void displayFirstAttempt()
        {
            int display;
         

            for (int i = 1; i < 11; ++i)
            {
                for (int j = 1; i < 11; ++j)
                {
                    display = i * j;
                    Console.Write(display + " ");
                   
                }

            }
        }
    }
}
