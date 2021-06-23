using System;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            while (true)
            {
                Console.Write("Daxil etmek istediyiniz adlarin sayini bildirin: ");
                size = Convert.ToInt32(Console.ReadLine());
                if (size % 2 == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Zehmet olmasa cut eded daxil edin...");
                }
            }
            string[] names = new string[size];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"{i + 1}. adi daxil edin: ");
                string tempName = Console.ReadLine();
                while (Array.IndexOf(names, tempName) != -1)
                {
                    Console.WriteLine("Bu ad artiq daxil edilib,bashqa ad daxil edin: ");
                    Console.Write($"{i + 1}. adi daxil edin: ");
                    tempName = Console.ReadLine();
                }
                names[i] = tempName;              
                
            }

            Random random = new Random();
            int[] randomIndexes = new int[size];
            for (int i = 0; i < randomIndexes.Length; i++)
            {
                randomIndexes[i] = -1;
            }

            for (int i = 0; i < size; i++)
            {
                int randomIndex = random.Next(size);
                while (Array.IndexOf(randomIndexes, randomIndex) != -1)
                {
                    randomIndex = random.Next(size);
                }
                randomIndexes[i] = randomIndex;
            }

            string[] firtsTeam = new string[size / 2];
            string[] secondTeam = new string[size / 2];
            for (int i = 0; i < randomIndexes.Length; i++)
            { 
                if (i % 2 == 0)
                {
                    firtsTeam[i / 2] = names[randomIndexes[i]];
                }
                else
                {
                    secondTeam[i / 2] = names[randomIndexes[i]];
                }
            }

            Console.WriteLine("Birinci kamandanin uzvleri:");
            foreach (var item in firtsTeam)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nIkinci kamandanin uzvleri:");
            foreach (var item in secondTeam)
            {
                Console.WriteLine(item);
            }
        }
    }
}
