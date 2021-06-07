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
            Console.Write("Adınızı daxil edin: ");
            string firtName = Console.ReadLine();
            Console.Write("Soyadınızı daxil edin: ");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Salamlar {firtName} !");
        }
    }
}
