using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number = 0;
            do
            {
                Console.Write("Eded daxil edin :");
                number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            } while (number != 0);
            Console.WriteLine($"Daxil olunan ededlerin cemi: {sum}");
        }
    }
}
