using System;
using System.Collections;
using System.Linq;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Array-ler nece elementli olacagini daxil edin: ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] list01 = new string[size];
            string[] list02 = new string[size];


            Console.WriteLine("Birinci Array-in elementlerini daxil edin:");
            for (int i = 0; i < list01.Length; i++)
            {
                list01[i] = Console.ReadLine();
            }

            Console.WriteLine("Ikinci Array-in elementlerini daxil edin:");
            for (int i = 0; i < list01.Length; i++)
            {
                list02[i] = Console.ReadLine();
            }

            foreach (string item in list01)
            {
                int count = 0;
                if (list02.Contains(item))
                {
                    foreach (string subItem in list02)
                    {
                        if (item == subItem)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{item}-den ikinci array-de {count} qeder var");
                }
            }
        }
    }
}
