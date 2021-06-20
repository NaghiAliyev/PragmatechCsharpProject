using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            while (i <=100)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                i++;
            }
            Console.WriteLine($"1-den 100-e qeder cut ededlerin cemi: {sum}");
        }
    }
}
