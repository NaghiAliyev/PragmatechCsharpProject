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
            public Person(string _name, string _surName)
            {
                this.name = _name;
                this.surName = _surName;
                this.age = 0;
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Resul", "Qasimov");
            Console.Write("Adinizi daxil edin: ");
            string name = Console.ReadLine().Trim();
            Console.Write("Soyadinizi daxil edin: ");
            string surName = Console.ReadLine().Trim();
            Console.Write("Yasinizi daxil edin: ");
            int age = Convert.ToInt32(Console.ReadLine().Trim());
            //person.age = age;
            if(name == person.name && surName == person.surName)
            {
                if (age < 18)
                {
                    Console.WriteLine($"{person.name}, Sizin yasiniz uygun deyil");
                }
                else
                {
                    Console.WriteLine($"{person.name}, Sizin yasiniz uygundur");
                    person.age = age;
                }
            }
            else
            {
                Console.WriteLine($"{name}, Sizin melumatlariniz sistemde yoxdur");
            }
        }
    }
}
