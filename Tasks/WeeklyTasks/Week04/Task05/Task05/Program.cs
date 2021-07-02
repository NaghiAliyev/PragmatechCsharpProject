using System;
using System.Linq;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 5, 8, 15, 18, 23, 26, 33, 38, 39};
            int[] oddNumbers = new int[arr.Length];
            int index = 0;
            foreach (int item in arr)
            {
                if (item % 2 == 1)
                {
                    oddNumbers[index++] = item;
                }
            }
            Array.Resize( ref oddNumbers, index);
            Console.WriteLine($"Array daxilindeki tek ededlerin sayi = {index}\nEdedler:");
            foreach (var item in oddNumbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
