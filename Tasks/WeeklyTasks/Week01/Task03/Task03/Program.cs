using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Üç herf daxil edin: ");
            string line = Console.ReadLine();
            line = line.Replace(" ", ""); // Herfler arasinda bosluq qoyulma ehtimalini nezere almaq ucun bosluqlari silirik
            line = line.Replace(",", ""); // Herfler arasinda vergul qoyulma ehtimalini nezere almaq ucun vergulleri silirik
            char[] chars = line.ToCharArray();
            char[] rChars = new char[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                rChars[i] = chars[chars.Length - 1 - i];
            }
            Console.WriteLine("Verilmiş herflerin ters sıra ile yazılışı :");
            Console.WriteLine(string.Join(", ", rChars));
        }
    }
}
