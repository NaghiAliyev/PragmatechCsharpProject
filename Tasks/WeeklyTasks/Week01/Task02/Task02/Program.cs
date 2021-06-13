using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
