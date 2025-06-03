using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Ekrana Yazılması istediğiniz Yazıyı Giriniz: ");
            //string input = Console.ReadLine();

            //Console.Write("Kaç kere yazılmasını istediğinizi giriniz: ");
            //int count = int.Parse(Console.ReadLine());

            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine(input);
            //}

            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            for( int z = 10; z >= 1; z--)
            {
                for(int e = 1; e <= z; e++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
