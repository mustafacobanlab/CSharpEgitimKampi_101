using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Console.Write("Başkenti Giriniz: ");
            //string capital = Console.ReadLine();


            //Console.Write("Ülkeyi Giriniz: ");
            //string country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Bilgiler Doğru");
            //}
            //else {
            //    Console.WriteLine("Hatalı Veri");
            //}

            //Console.WriteLine("---1 Numaralı Şehirler---");
            //Console.WriteLine("1-Ankara");
            //Console.WriteLine("2-Adana");
            //Console.WriteLine("3-Eskişehir");
            //Console.WriteLine("-------------------------");
            //Console.WriteLine();
            //Console.WriteLine("---2 Numaralı Şehirler---");
            //Console.WriteLine("1-İstanbul");
            //Console.WriteLine("2-İzmir");
            //Console.WriteLine("3-Bursa");
            //Console.WriteLine("-------------------------");
            //Console.WriteLine();
            //Console.Write("Bir Şehir Giriniz: ");
            //string city = Console.ReadLine();

            //if (city == "ankara" | city == "adana" | city == "eskişehir") {
            //    Console.WriteLine("1 Numaralı Şehirler");
            //}
            //else if (city == "istanbul" | city == "izmir" | city == "bursa")
            //{
            //    Console.WriteLine("2 Numaralı Şehirler");
            //}
            //else
            //{
            //    Console.WriteLine("Mevcut Değil");
            //}
            #endregion

            //Console.Write("Lütfen Takım Sembolü Giriniz: ");
            //char takim = char.Parse(Console.ReadLine());

            //if(takim == 'F' || takim == 'f')
            //{
            //    Console.WriteLine("Takımınız Fenerbahçe");
            //}
            //else if(takim == 'B' || takim == 'b')
            //{
            //    Console.WriteLine("Takımınız Beşiktaş");
            //}
            //else if(takim == 'G' || takim == 'g')
            //{
            //    Console.WriteLine("Takımınız Galatasaray");
            //}
            //else if(takim == 'T' || takim == 't')
            //{
            //    Console.WriteLine("Takımınız Trabzonspor");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz Takım Sembolü");
            //}


            //Console.Write("Lütfen Bir Ay Numarası Giriniz: ");
            //int month = int.Parse(Console.ReadLine());

            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak Ayı");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat Ayı");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart Ayı");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan Ayı");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs Ayı");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran Ayı");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz Ayı");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos Ayı");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül Ayı");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim Ayı");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım Ayı");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık Ayı");
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz Ay Numarası!");
            //        break;
            //}

            Console.Write("İlk Sayıyı Giriniz: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("[+] [-] [*] [/] Yapmak istediğiniz işlemi Giriniz: ");
            char symbol = char.Parse(Console.ReadLine());
            
            switch (symbol)
            {
                case '+':
                    Console.WriteLine("Sonuç: " + (a + b));
                    break;
                case '-':
                    Console.WriteLine("Sonuç: " + (a - b));
                    break;
                case '*':
                    Console.WriteLine("Sonuç: " + (a * b));
                    break;
                case '/':
                    Console.WriteLine("Sonuç: " + (a / b));
                    break;

                default:
                    Console.WriteLine("Geçersiz İşlem Sembolü!");
                    break;
            }
            Console.Read();

        }
    }
}
