using System;
using System.Linq;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Random random = new Random();
            Array.Fill(arr, -1);
            for (int i = 0; i < arr.Length; i++)
            {
                int randomNumber = random.Next(5);
                while (Array.IndexOf(arr, randomNumber) != -1)
                {
                    randomNumber = random.Next(5);
                };
                arr[i] = randomNumber;
            }

            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            // Method 01
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            Console.WriteLine($"\nEdedlerin cemi = {sum}");

            // Method 02
            int sum02 = arr.Sum();
            Console.WriteLine($"\nEdedlerin cemi = {sum02}");

        }
    }
}
