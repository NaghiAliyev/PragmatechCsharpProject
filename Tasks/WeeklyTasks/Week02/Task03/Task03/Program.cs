using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir eded daxil edin: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine().Trim());
            if (firstNumber % 2 == 1)
            {
                Console.WriteLine($"{firstNumber} tek ededdir ");
            }
            else 
            {
                Console.WriteLine($"{firstNumber} cut ededdir");
            }            
        }
    }
}
