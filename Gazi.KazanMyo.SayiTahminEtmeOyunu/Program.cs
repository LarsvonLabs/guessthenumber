using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMyo.SayiTahminEtmeOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zorluk Seviyesi Seçin\n -Kolay\n -Normal\n -Zor: ");
            string zorluk = Console.ReadLine().ToLower();

            if (zorluk == "kolay")
            {
                Random rnd = new Random();
                int sayi = rnd.Next(1, 10);

                for (int i = 0; i < 15; i++)
                {
                    Console.WriteLine("Tahmininizi Yapınız: ");
                    int tahmin = int.Parse(Console.ReadLine());
                    if (sayi == tahmin)
                    {
                        Console.WriteLine("Tebrikler, başardınız!");
                        break;
                    }
                    else if (sayi != tahmin && i <= 15)
                    {
                        Console.WriteLine("Daha hakkınız bulunmakta, lütfen tahmin etmeye devam edin");
                    }
                    else 
                    {
                        Console.WriteLine("Başaramadınız!");
                    }
                }
            }
            if (zorluk == "normal")
            {
                Random rnd = new Random();
                int sayi = rnd.Next(1, 25);

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Tahmininizi Yapınız: ");
                    int tahmin = int.Parse(Console.ReadLine());
                    if (sayi == tahmin)
                    {
                        Console.WriteLine("Tebrikler, başardınız!");
                        break;
                    }
                    else if (sayi != tahmin && i <= 10)
                    {
                        Console.WriteLine("Daha hakkınız bulunmakta, lütfen tahmin etmeye devam edin");
                    }
                    else
                    {
                        Console.WriteLine("Başaramadınız!");
                    }
                }
            }
            if (zorluk == "zor")
            {
                Random rnd = new Random();
                int sayi = rnd.Next(1, 50);

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Tahmininizi Yapınız: ");
                    int tahmin = int.Parse(Console.ReadLine());
                    if (sayi == tahmin)
                    {
                        Console.WriteLine("Tebrikler, başardınız!");
                        break;
                    }
                    else if (sayi != tahmin && i <= 5)
                    {
                        Console.WriteLine("Daha hakkınız bulunmakta, lütfen tahmin etmeye devam edin");
                    }
                    else
                    {
                        Console.WriteLine("Başaramadınız!");
                    }
                }
            }
        }
    }
}
