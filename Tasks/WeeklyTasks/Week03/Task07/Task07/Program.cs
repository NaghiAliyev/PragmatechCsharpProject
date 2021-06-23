using System;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vowels = {"a", "e", "i", "o", "u"};
            Console.WriteLine("Bir soz daxil edin: ");
            string word = Console.ReadLine();
            int count = 0;
            foreach (string vowel in vowels)
            {
                if (word.Contains(vowel))
                {
                    // Tekrarlanan saitlerin tapilmasi ucun edilib, bu hissede
                    // IndexOf methodu ucun mueyyen bir startIndex anlayisi ile internetde qarsilasmisam
                    int minIndex = word.IndexOf(vowel,0);
                    while (minIndex != -1)
                    {
                        minIndex = word.IndexOf(vowel, minIndex+1);
                        count++;
                    }
                }
            }
            if (count != 0)
            {
                Console.WriteLine($"{word} sozu daxilinde {count} sayda sait var");
            }
            else
            {
                Console.WriteLine($"{word} sozu daxilinde sait yoxdur");
            }
        }
    }
}
