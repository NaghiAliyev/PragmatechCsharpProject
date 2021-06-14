using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir eded daxil edin: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine().Trim());
            if (firstNumber > 0)
            {
                Console.WriteLine($"{firstNumber} musbet ededdir ");
            }
            else if(firstNumber < 0)
            {
                Console.WriteLine($"{firstNumber} menfi ededdir");
            }
            else
            {
                Console.WriteLine($"Daxil edilmis eded 0-dir");
            }
        }
    }
}
