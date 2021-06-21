using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int chances = 5;
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1000);
            bool status = false;
            do
            {
                Console.Write("Texmin etdiyiniz ededi daxil edin :");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == randomNumber)
                {
                    Console.WriteLine("Tebrikler siz duzgun ededi texmin etdiniz!");
                    status = true;
                    break;
                }
                else if (number > randomNumber)
                {
                    Console.WriteLine($"Texmin etdiyiniz eded boyukdur, sizin {--chances} sansiniz qalib.");
                }
                else
                {
                    Console.WriteLine($"Texmin etdiyiniz eded kicikdir, sizin {--chances} sansiniz qalib.");
                }
            } while (chances > 0);
            if (!status)
            {
                Console.WriteLine($"Sizin texmin ucun sansiniz bitdi, nezerde tutulan eded {randomNumber}-idi");
            }
        }
    }
}
