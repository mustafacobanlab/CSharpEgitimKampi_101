using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _05_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region
            //string[] cities = { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            //int[] nume = { 1, 2, 3, 4, 5,6,7 };

            //foreach (int n in nume)
            //{
            //    if(n % 2 == 0)
            //       Console.WriteLine(n);
            //}

            //int toplam = 0;
            //foreach (int n in nume)
            //{
            //    toplam += n;

            //}
            //Console.WriteLine("Toplam: " + toplam);

            //List<int> sayilar = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //foreach (int saylar in sayilar)
            //{
            //    Console.WriteLine(saylar);
            //}


            //string sym = "SELAM DÜNYA";

            //foreach(char harf in sym)
            //{
            //                   Console.WriteLine(harf);
            //}
            #endregion

            Console.WriteLine("C# Eğitim Kampı Uygulama");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.Write("Sınıfınız Kaç Öğrenci var: ");
            int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------");

            string[] ogrenciler = new string[ogrenciSayisi];
            double[] notlar = new double[ogrenciSayisi];

            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.WriteLine();
                Console.Write($"{i+1}. Öğrenci Adı: ");
                ogrenciler[i] = Console.ReadLine();
                
                double notOrtalamasi = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine();
                    Console.Write($"{i + 1}. Öğrenci Notu {j + 1} . sınav notunu giriniz: ");
                    notOrtalamasi += Convert.ToDouble(Console.ReadLine());
                }
                notlar[i] = notOrtalamasi / 3; // Üç sınavın ortalamasını alıyoruz
                
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("Öğrenci Notları: ");
            Console.WriteLine();
            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.WriteLine($"{ogrenciler[i]}: {notlar[i]}");
                

                if (notlar[i] >= 50)
                {
                    Console.WriteLine($"{ogrenciler[i]}: Geçti");
                }
                else
                {
                    Console.WriteLine($"{ogrenciler[i]}: Kaldı");
                }
            }
            Console.WriteLine("------------------------");
            

          




            Console.ReadLine();

            
        }

    }
}