using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 04_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "Red", "Green", "Blue", "Yellow", "Purple" };
            int index = Array.IndexOf(colors, "Blue");
            Console.WriteLine(index);

            int[] number = new int[5];

            number[0] = 10;
            number[1] = 20;
            number[2] = 30;
            number[3] = 40;
            number[4] = 50;

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine($"Color {i + 1}: {colors[i]}");
            }

            Console.WriteLine();

            int[] num = { 85,47,90,12,45,78,65,23,56,89 };
            Array.Sort(num);
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Number {i + 1}: {num[i]}");
            }
            Console.WriteLine();

            
            Array.Reverse(num);
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Number {i + 1}: {num[i]}");
            }

            Console.WriteLine();
            Console.WriteLine($"Dizinin En büyük Elemanı: {num.Max()} Dizinin En Küçük Elemanı: {num.Min()}");
            int ez = 0;
            for (int i = 0; i < num.Length; i++)
            {
                ez += num[i];
            }
            Console.WriteLine();
            Console.WriteLine("Dizide bulunan rakamların toplamı: "+ ez);


            Console.Read();
        }
    }
}
