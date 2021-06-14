using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iki eded daxil edin:");
            Console.Write("Birinci eded: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine().Trim());
            Console.Write("Ikinci eded: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine().Trim());
            if(firstNumber > secondNumber)
            {
                Console.WriteLine($"{firstNumber} > {secondNumber}");
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine($"{secondNumber} > {firstNumber}");
            }
            else
            {
                Console.WriteLine($"{secondNumber} ve {firstNumber} bir-birine beraberdir");
            }
        }
    }
}
