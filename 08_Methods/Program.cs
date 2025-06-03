using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Customer(string name,string surname)
            {
                Console.WriteLine(name+" "+surname);
            }

            Customer("Ahmet", "Yılmaz");

            int Sum(int a, int b, int c)
            {
                return a + b + c;
            }

            int sum = Sum(15, 45, 60);
            Console.WriteLine(sum);

            string surn()
            {
                return "Yılmaz";
            }
            Console.WriteLine(surn()); 

            string country(string name, string capital, string flagcolor)
            {
                string card = $"Ülke Adı: {name} Ülke Başkenti: {capital} Ülke Bayrak Rengi: {flagcolor}";
                return card;
            }
            Console.WriteLine(country("Türkiye", "Ankara", "Kırmızı"));





            Console.ReadLine();

        }
    }
}
