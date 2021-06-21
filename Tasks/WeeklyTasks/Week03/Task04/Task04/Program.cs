using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded daxil edin :");
            int number = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            int factorial = 1;
            if (temp == 0)
            {
                Console.Write("\nDaxil edilen eded 0 ola bilmez :");
                number = Convert.ToInt32(Console.ReadLine());
                temp = number;
            }

            do
            {
                factorial *= temp--;
            } while (temp > 0) ;

            if (factorial != 0)
            {
                Console.WriteLine($"Daxil edilen {number} ededinin faktoriali = {factorial}");
            }
        }
    }
}
