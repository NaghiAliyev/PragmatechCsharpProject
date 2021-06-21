using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Daxil etmek istediyiniz adlarin sayini bildirin: ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[size];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"{i+1}. adi daxil edin: ");
                names[i] = Console.ReadLine();
            }
            
            Console.Write("Hansi adi secmek isteyirsiniz: ");
            string selectedName = Console.ReadLine();
            int count = 0;
            foreach (string name in names)
            {
                if (name == selectedName)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"Sizin daxil etdiyiniz {selectedName} adi evvel daxil etdiyiniz adlarin daxilinde yoxdur.");
            }
            else
            {
                Console.WriteLine($"Sizin daxil etdiyiniz {selectedName} adi evvel daxil etdiyiniz adlarin daxilinde {count} saydadir.");
            }
        }
    }
}
