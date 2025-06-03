using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region
            /*
            
            double applePrice, orangePrice, starberryPrice, potatoPrice, tomatoPrice;

            applePrice = 5.99;
            orangePrice = 4.99;
            starberryPrice = 6.99;
            potatoPrice = 2.99;
            tomatoPrice = 3.49;

            Console.WriteLine("**** Ürün Fiyatları ****");
            Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " ₺");
            Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " ₺");
            Console.WriteLine("---- Çilek Birim Fiyatı: " + starberryPrice + " ₺");
            Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " ₺");
            Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " ₺");

            double appleGram, orangeGram, starberryGram, potatoGram, tomatoGram;

            appleGram = 1.450;
            orangeGram = 1.200;
            starberryGram = 1.300;
            potatoGram = 2.500;
            tomatoGram = 1.800;

            double appleTotalPrice, orangeTotalPrice, starberryTotalPrice, potatoTotalPrice, tomatoTotalPrice;

            appleTotalPrice = applePrice * appleGram;
            orangeTotalPrice = orangePrice * orangeGram;
            starberryTotalPrice = starberryPrice * starberryGram;
            potatoTotalPrice = potatoPrice * potatoGram;
            tomatoTotalPrice = tomatoPrice * tomatoGram;

            Console.WriteLine();
            Console.WriteLine("**** Ürün Toplam Fiyatları ****");
            Console.WriteLine("Alınan Ürün Elma - Birim Fiyatı: " + applePrice + " ₺" + " Gramaj: "
                + appleGram + " Toplam Tutar: " + appleTotalPrice + " ₺");
            Console.WriteLine("Alınan Ürün Portakal - Birim Fiyatı: " + orangePrice + " ₺" + " Gramaj: "
                + orangeGram + " Toplam Tutar: " + orangeTotalPrice + " ₺");
            Console.WriteLine("Alınan Ürün Çilek - Birim Fiyatı: " + starberryPrice + " ₺" + " Gramaj: "
                + starberryGram + " Toplam Tutar: " + starberryTotalPrice + " ₺");
            Console.WriteLine("Alınan Ürün Patates - Birim Fiyatı: " + potatoPrice + " ₺" + " Gramaj: "
                + potatoGram + " Toplam Tutar: " + potatoTotalPrice + " ₺");
            Console.WriteLine("Alınan Ürün Domates - Birim Fiyatı: " + tomatoPrice + " ₺" + " Gramaj: "
                + tomatoGram + " Toplam Tutar: " + tomatoTotalPrice + " ₺");
          
            double totalPrice = appleTotalPrice + orangeTotalPrice + starberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Toplam Ödenenecek Tutar: " + totalPrice + " ₺");
            
            */
            #endregion
            #region
            /*

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine("*** ÇOBAN HAVA YOLLARI YOLCU BİLGİSİ ***");
            Console.WriteLine();

            string customerName, customerSurname, customerDistrict, customerCity, customerAge,
                customerID;

            Console.Write("Müşteri Adı: ");
            customerName = Console.ReadLine();

            Console.Write("Müşteri Soyadı: ");
            customerSurname = Console.ReadLine();

            Console.Write("Müşteri İlçe: ");
            customerDistrict = Console.ReadLine();

            Console.Write("Müşteri İl: ");
            customerCity = Console.ReadLine();

            Console.Write("Müşteri Yaşı: ");
            customerAge = Console.ReadLine();

            Console.Write("Müşteri TC Kimlik Numarası: ");
            customerID = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("Yolcu TC Kimlik Numarası: " + customerID );
            Console.WriteLine("Yolcu: " + customerName + " " + customerSurname);
            Console.WriteLine("Yolcu Yaşı: " + customerAge);
            Console.WriteLine("Yolcu İL/İLÇE: " + customerCity + "/" + customerDistrict);

            */
            #endregion

            int shoePrice, computerPrice, ChairPrice, tvPrice;

            shoePrice = 499;
            computerPrice = 9999;
            ChairPrice = 1999;
            tvPrice = 5999;

            int shoeCount, computerCount, chairCount, tvCount;

            Console.Write("Aldığınız Ayakkabı Sayısını Giriniz: ");
            shoeCount =int.Parse( Console.ReadLine());

            Console.Write("Aldığınız Bilgisayar Sayısını Giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Aldığınız Sandalye Sayısını Giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Aldığınız Televizyon Sayısını Giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = (shoePrice * shoeCount) + (computerPrice * computerCount) +
                (ChairPrice * chairCount) + (tvPrice * tvCount);

            Console.WriteLine();
            Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice + " ₺");

            Console.Read();

        }
    }
}
