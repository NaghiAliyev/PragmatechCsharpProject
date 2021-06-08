using System;

namespace Week_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_01();
            Task_02();
            Task_03();
            Task_04();
        }

        static void Task_01()
        {
            string firtName = "Naghi";
            string lastName = "Aliyev";
            int age = 19;
            string universityName = "Baku Engineering University";
            Console.WriteLine($"Adı: {firtName}\nSoyadı: {lastName}\nYaşı:{age}\nOxuduğu Universitet: {universityName}");
        }

        static void Task_02()
        {
            Console.Write("Adınızı daxil edin: ");
            string firtName = Console.ReadLine();
            Console.Write("Soyadınızı daxil edin: ");
            string lastName = Console.ReadLine();
            Console.Write("Yaşınızı daxil edin: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Oxuduğunuz Universiteti daxil edin: ");
            string universityName = Console.ReadLine();
            Console.WriteLine($"Adı: {firtName}\nSoyadı: {lastName}\nYaşı: {age}\nOxuduğu Universitet: {universityName}");
        }

        static void Task_03()
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

        static void Task_04()
        {
            Console.Write("Adınızı daxil edin: ");
            string firtName = Console.ReadLine();
            Console.Write("Soyadınızı daxil edin: ");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Salamlar {firtName}!");
        }
    }
}
