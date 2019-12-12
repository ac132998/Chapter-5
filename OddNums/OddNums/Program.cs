using System;

namespace OddNums
{
    class Program
    {
        static void Main(string[] args)
        {
             
            for (int n = 1; n < (99+1); n++)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n);
                }

            }
           



        }
    }
}
