using System;

namespace SumFourInts
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int q;
            int total = 0;

            for (int i = 0; i < 4; ++i)
            {
                Console.WriteLine("Enter a number > ");
                q = Convert.ToInt32(Console.ReadLine());
                total = total + q;

            }

            Console.WriteLine(total);
        }
    }
}
