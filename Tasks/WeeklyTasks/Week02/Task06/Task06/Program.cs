using System;

namespace Task06
{
    class Program
    {
        struct Person
        {
            public string name{ get; set; }
            public string surName{ get; set; }
            public int age{ get; set; }
            public Person(int _age)
            {
                this.name = "Rauf";
                this.surName = "Haciyev";
                this.age = _age;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Adinizi daxil edin: ");
            string name = Console.ReadLine().Trim();
            Console.Write("Soyadinizi daxil edin: ");
            string surName = Console.ReadLine().Trim();
            Console.Write("Yasinizi daxil edin: ");
            int age  = Convert.ToInt32(Console.ReadLine().Trim());
            Person person = new Person(age);

            //person.age = age;
            if (name == person.name && surName == person.surName)
            {
                if (age < 18)
                {
                    Console.WriteLine($"{person.name}, Sizin yasiniz uygun deyil");
                }
                else
                {
                    Console.WriteLine($"{person.name}, Sizin yasiniz uygundur");
                }
            }
            else
            {
                Console.WriteLine($"{name}, Sizin melumatlariniz sistemde yoxdur");
            }
        }
    }
}
