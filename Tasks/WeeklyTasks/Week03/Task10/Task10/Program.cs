using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method 01 - with ASCII table
            int startIndex = 65;
            //int startIndex = 97; 
            int endIndex = 90;
            //int endIndex = 122;
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (i!=endIndex)
                {
                    Console.Write((char)i + ", ");

                }
                else
                {
                    Console.WriteLine((char)i);

                }
            }

            // Method 02
            char startPoint = 'a';
            //char startPoint = 'A';
            char endPoint = 'z';
            //char startPoint = 'Z';
            for (char ch = startPoint; ch <= endPoint; ch++)
            {
                if (ch != endPoint)
                {
                    Console.Write(ch + ", ");

                }
                else
                {
                    Console.WriteLine(ch);

                }
            }
        }
    }
}
