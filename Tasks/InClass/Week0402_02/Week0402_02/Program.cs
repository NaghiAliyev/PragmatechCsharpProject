using System;
using System.Linq;

namespace Week0402_02
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
            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");

            }
            Console.WriteLine();
            // Method 02
            Array.Reverse(arr);
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }

        }
    }
}
