using System;

namespace SumInts1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int entry = 0;
           

            do
            {
                Console.WriteLine("Enter a intger >>> ");
                entry = Convert.ToInt32(Console.ReadLine());
                total = total + entry;
                

            } while (entry != 999);

            Console.WriteLine(total-999);
        }
    }
}
