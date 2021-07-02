using System;
using System.Linq;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, -4, 27, 0 , 44, -2, 47, 59, -88};

            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }

            // Method 01
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"\nArrayin en kicik deyere sahib elementi : {min}");

            // Method 02
            int minimum = arr.Min();
            Console.WriteLine($"Arrayin en kicik deyere sahib elementi : {minimum}");
        }
    }
}
