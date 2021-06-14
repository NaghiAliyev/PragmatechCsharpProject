using System;

namespace Task05
{
    class Program
    {
        struct Student
        {
            public int grade { get; set; }
            public Student(int _grade)
            {
                this.grade = _grade;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Imtahandan aldiginiz bali daxil edin: ");
            Student student = new Student(Convert.ToInt32(Console.ReadLine().Trim()));
            switch (student.grade)
            {
                case int n when(n<=100 && n>=91):
                    Console.WriteLine("Tebrikler, siz 'A' aldiniz!");
                    break;
                case int n when (n <= 90 && n >= 81):
                    Console.WriteLine("Siz 'B' aldiniz!");
                    break;
                case int n when (n <= 80 && n >= 71):
                    Console.WriteLine("Siz 'C' aldiniz!");
                    break;
                case int n when (n <= 70 && n >= 61):
                    Console.WriteLine("Siz 'D' aldiniz!");
                    break;
                case int n when (n <= 60 && n >= 51):
                    Console.WriteLine("Siz 'E' aldiniz!");
                    break;
                case int n when (n <= 50 && n >= 0):
                    Console.WriteLine("Teessuf ki, siz 'F' aldiniz!");
                    break;
                default:
                    Console.WriteLine("Teessuf ki, daxil etdiyiniz qiymet yanlisdir!");
                    break;
            }
        }
    }
}
