using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iki eded daxil edin: ");
            Console.Write("Birinci ededi daxil edin: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikinci ededi daxil edin: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            
            for (int number = number1; number <= number2; number++)
            {
                bool f = true;
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        f = false;
                        break;
                    }
                }
                if (f)
                {
                    Console.WriteLine($"{number} ededi sade ededdir");
                }
            }
        }
    }
}
