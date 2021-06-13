using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adınızı daxil edin: ");
            string firtName = Console.ReadLine();
            Console.Write("Soyadınızı daxil edin: ");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Salamlar {firtName}!");
        }
    }
}
