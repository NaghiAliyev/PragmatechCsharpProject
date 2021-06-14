using System;

namespace Task01
{
    class Program
    {
        struct User
        {
            public string userName { get; set; }
            public string password { get; set; }
            
            public User(string _userName, string _password)
            {
                this.userName = _userName;
                this.password = _password;
            }
        }
        static void Main(string[] args)
        {
            User defaultUser = new User("Mustafa", "Mustafa_123");
            Console.WriteLine("Istifadeci adinizi daxil edin:");
            string userName = Console.ReadLine().Trim();
            Console.WriteLine("Sifrenizi daxil edin:");
            string password = Console.ReadLine().Trim();
            if(defaultUser.userName == userName && defaultUser.password == password)
            {
                Console.WriteLine("Sayta xos gelmisiniz!");
            }
            else
            {
                Console.WriteLine("Istifadeci adi ve ya sifre yanlisdir!");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
