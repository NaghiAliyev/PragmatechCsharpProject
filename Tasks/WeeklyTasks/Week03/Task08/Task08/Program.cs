using System;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -1;
            }
            Random random = new Random();
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int randomIndex = random.Next(10);
                while (Array.IndexOf(arr, randomIndex) != -1)
                {
                    randomIndex = random.Next(10);
                    counter++;
                }
                arr[i] = randomIndex;
            }
            Console.Write("Array-in elementleri: ");
            foreach (int number in arr)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine($"\nArray yaradilan zaman tekrarlanmanin qarsisinin alindigi hallarin sayi: {counter}");
        }
    }
}
