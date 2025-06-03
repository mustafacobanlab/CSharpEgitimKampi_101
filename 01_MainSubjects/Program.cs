using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdırma Komutları
            Console.WriteLine("Programlama Dilleri");
            Console.WriteLine();
            Console.WriteLine("C#");
            Console.WriteLine("Java");
            Console.WriteLine("Python");
            Console.WriteLine("JavaScript");

            #endregion

            #region Değişkenler

            string customerName;
            string customerSurname;
            string customerPhoneNumber;
            string customerEmail, district, city;


            customerName = "Mustafa";
            customerSurname = "Çoban";
            customerPhoneNumber = "0532 123 45 67";
            customerEmail = "deneme@mail.com";
            district = "Çankaya";
            city = "Ankara";





            Console.WriteLine("**** Müşteri Bilgileri ****");
            Console.WriteLine();
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("Telefon: " + customerPhoneNumber);
            Console.WriteLine("E-Posta: " + customerEmail);
            Console.WriteLine("İlçe: " + district);
            Console.WriteLine("İl: " + city);




            #endregion




            Console.ReadLine();


        }
    }
}
