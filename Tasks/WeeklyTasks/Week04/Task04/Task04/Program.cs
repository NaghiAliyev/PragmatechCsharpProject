using System;
using System.Collections;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList members = new ArrayList();
            //Console.WriteLine("Sport komplekse qeydiyyat sistemi");
            while (true)
            {
                Console.WriteLine("Sport komplekse qeydiyyat sistemi");
                Console.WriteLine("Edeceyiniz emeliyyati secin:");
                Console.WriteLine(
                    "1 - Uzv daxil edin" +
                    "\n2-Uzvu qeydiyyatdan silin" +
                    "\n3-Uzvlerin siyahisini gorun" +
                    "\n4-Uzvlerin siyahini ters cevirin" +
                    "\n5-Uzvlerin qeydiyyatda olub olmamasini yoxlayin" +
                    "\n6-Uzvlerin siyahisini bashdan sona siralayin" +
                    "\n7-Butun uzvlerin qeydiyyatini silin" +
                    "\n8-Sport komlekse qeydiyyat sisteminden cixin"
                    );
                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Uzv daxil etme ekranina xosh geldiniz");
                        Console.Write("Nece uzv daxil etmek isteyirsiniz: ");
                        int size = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < size; i++)
                        {
                            Console.Write($"{i}. uzvun adini daxil edin: ");
                            string member = Console.ReadLine();
                            members.Add(member);
                        }
                        Console.WriteLine("Daxil etme emeliyyati ugurla basa catdi!");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Uzvlerin qeydiyyatdan silme ekranina xosh geldiniz");
                        foreach (string member in members)
                        {
                            Console.Write(member + " ");
                        }
                        Console.WriteLine("\nSilmek istediyiniz uzvun adini yazin: ");
                        string memberName = Console.ReadLine();
                        if (members.Contains(memberName))
                        {
                            members.Remove(memberName);
                            Console.WriteLine($"{memberName} sistemden ugurla silindi");
                        }
                        else
                        {
                            Console.WriteLine("Sistemde bu uzv yoxdur");
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Uzvlerin siyahisi ekranina xosh geldiniz");
                        Console.WriteLine("Uzvlerin siyahisi asagidaki sekildedir: ");
                        if (members.Count != 0)
                        {
                            foreach (string member in members)
                            {
                                Console.Write(member + " ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sistemdeki uzv sayi 0-dir");
                        }
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("4-Uzvlerin siyahini ters cevirin ekranina xosh geldiniz");
                        Console.WriteLine("Uzvlerin siyahisinin ters cevrilmis hali asagidaki sekildedir: ");
                        members.Reverse();
                        foreach (string member in members)
                        {
                            Console.Write(member + " ");
                        }
                        Console.WriteLine("\nTers cevirme emeliyyati yerine yetirildi");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Uzvlerin qeydiyyatda olub olmamasinin yoxlandigi ekranina xosh geldiniz");
                        Console.Write("Uzvun adini daxil edin: ");
                        string check = Console.ReadLine();
                        if (members.Contains(check))
                        {
                            Console.WriteLine("Uzv sistemde var");
                        }
                        else
                        {
                            Console.WriteLine("Uzv sistemde yoxdur");
                        }
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("Uzvlerin siyahisini bashdan sona siralanmasi ekranina xosh geldiniz");
                        Console.WriteLine("Uzvlerin siyahisinin bashdan sona siralanmis hali asagidaki sekildedir: ");
                        members.Sort();
                        foreach (string member in members)
                        {
                            Console.Write(member + " ");
                        }
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Butun uzvlerin qeydiyyatini silinmesi ekranina xosh geldiniz");
                        members.Clear();
                        Console.WriteLine("Butun uzvler sistemden silindi");
                        Console.ReadKey();
                        break;
                    case 8:
                        return;
                    default:
                        Console.WriteLine("Daxil etdiyiniz indekse uygun emeliyyat tapilmadi");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
        }
    }
}
