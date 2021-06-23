using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 2; number <= 100; number++)
            {
                bool f = true;
                for (int i = 2; i <= number/2; i++)
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
