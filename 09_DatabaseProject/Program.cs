using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ado.net

            Console.WriteLine("***** C#  Veri Tabanlı Ürün Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();
            string tablerNumber;
            Console.WriteLine("1. Kategoriler");
            Console.WriteLine("2. Ürünler");
            Console.WriteLine("3. Siparişlere");
            Console.WriteLine("4. Çıkış Yap");
            Console.WriteLine();
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tablerNumber = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=COBAN\\SQLEXPRESS;initial Catalog=EgitimKampiDbi;integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("Select * From tblCatgory", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);


            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }


            connection.Close();


            Console.ReadLine();
        }
    }
}
