using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud Create Read Update Delete işlemleri

            Console.WriteLine("*****Menü Sipariş İşlem Paneli*****");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------");
            #region Kategori ekleme işlemi
            //Console.Write("Eklemek istediğiniz kategori adını giriniz: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=COBAN\\SQLEXPRESS;initial Catalog=EgitimKampiDbi;integrated security=true"); // Veritabanı bağlantısı oluşturma işlemi
            //connection.Open(); // Veritabanı bağlantısını açma işlemi

            //SqlCommand command = new SqlCommand("Insert into tblCatgory (CategoryName) values (@p1)", connection); // SQL sorgusu oluşturma işlemi
            //command.Parameters.AddWithValue("@p1", categoryName); // Parametre ekleme işlemi
            //command.ExecuteNonQuery(); // Veritabanına ekleme işlemi
            //connection.Close(); // Veritabanı bağlantısını kapatma işlemi

            //Console.WriteLine("Kategori başarı ile eklendi!");
            #endregion


            #region ürün ekleme işlemi

            //string ProductName;
            //decimal ProductPrice;
            //// bool productStatus;

            //Console.Write("Eklemek İstediğiniz ürün adı: ");
            //ProductName = Console.ReadLine();
            //Console.Write("Eklemek istediğiniz ürün fiyatı: ");
            //ProductPrice = Convert.ToDecimal(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=COBAN\\SQLEXPRESS;initial Catalog=EgitimKampiDbi;integrated security=true"); // Veritabanı bağlantısı oluşturma işlemi
            //connection.Open(); // Veritabanı bağlantısını açma işlemi

            //SqlCommand command = new SqlCommand("Insert into tblProduct (ProductName, ProductPrice, ProductStatus) values (@p1, @p2, @p3)", connection); // SQL sorgusu oluşturma işlemi

            //command.Parameters.AddWithValue("@p1", ProductName); // Parametre ekleme işlemi
            //command.Parameters.AddWithValue("@p2", ProductPrice); // Parametre ekleme işlemi
            //command.Parameters.AddWithValue("@p3", true); // Parametre ekleme işlemi (ürün durumu)
            //command.ExecuteNonQuery(); // Veritabanına ekleme işlemi
            //connection.Close(); // Veritabanı bağlantısını kapatma işlemi
            //Console.WriteLine("Ürün başarı ile eklendi!");


            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=COBAN\\SQLEXPRESS;initial Catalog=EgitimKampiDbi;integrated security=true"); // Veritabanı bağlantısı oluşturma işlemi
            //connection.Open(); // Veritabanı bağlantısını açma işlemi

            //SqlCommand command = new SqlCommand("Select * From tblProduct", connection); // SQL sorgusu oluşturma işlemi
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(command); // Veritabanından veri çekme işlemi
            //DataTable dataTable = new DataTable(); 
            //dataAdapter.Fill(dataTable); // Veritabanından çekilen verileri DataTable'a doldurma işlemi

            //foreach (DataRow row in dataTable.Rows) // DataTable'daki her satırı döngü ile gezme işlemi
            //{
            //    foreach (var item in row.ItemArray) // Her satırdaki her öğeyi döngü ile gezme işlemi
            //    {
            //        Console.Write(item.ToString() + " "); // Öğeleri ekrana yazdırma işlemi
            //    }
            //    Console.WriteLine(); // Satır sonu
            //}









            //connection.Close();



            #endregion



            #region Ürün Silme İşlemi


            //Console.Write("Silinecek Ürün ID: ");
            //int productId=int.Parse(Console.ReadLine()); // Silinecek ürünün ID'sini kullanıcıdan alma işlemi



            //SqlConnection connection = new SqlConnection("Data Source=COBAN\\SQLEXPRESS;initial Catalog=EgitimKampiDbi;integrated security=true"); // Veritabanı bağlantısı oluşturma işlemi
            //connection.Open(); // Veritabanı bağlantısını açma işlemi

            //SqlCommand command = new SqlCommand("Delete From tblProduct Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId); // Silinecek ürünün ID'sini parametre olarak ekleme işlemi
            //command.ExecuteNonQuery(); // Veritabanından silme işlemi


            //connection.Close();


            //Console.WriteLine("Silme İşlemi Yapıldı.");

            #endregion

            #region Ürün Güncelleme

            Console.Write("Güncellenecek Ürün ID: ");
            int productId = int.Parse(Console.ReadLine()); // Güncellenecek ürünün ID'sini kullanıcıdan alma işlemi
            Console.Write("Güncellenecek Ürün Adı: ");
            string newProductName = Console.ReadLine(); // Güncellenecek ürünün yeni adını kullanıcıdan alma işlemi
            Console.Write("Güncellenecek Ürün Fiyatı: ");
            decimal newProductPrice = decimal.Parse(Console.ReadLine()); // Güncellenecek ürünün yeni fiyatını kullanıcıdan alma işlemi




            SqlConnection connection = new SqlConnection("Data Source=COBAN\\SQLEXPRESS;initial Catalog=EgitimKampiDbi;integrated security=true"); // Veritabanı bağlantısı oluşturma işlemi
            connection.Open(); // Veritabanı bağlantısını açma işlemi
            SqlCommand command = new SqlCommand("Update tblProduct Set ProductName=@newProductName, ProductPrice=@newProductPrice Where ProductId=@productId", connection); // SQL sorgusu oluşturma işlemi
            command.Parameters.AddWithValue("@productId", productId); // Güncellenecek ürünün ID'sini parametre olarak ekleme işlemi
            command.Parameters.AddWithValue("@newProductName", newProductName); // Güncellenecek ürünün yeni adını parametre olarak ekleme işlemi
            command.Parameters.AddWithValue("@newProductPrice", newProductPrice); // Güncellenecek ürünün yeni fiyatını parametre olarak ekleme işlemi
            command.ExecuteNonQuery();









            connection.Close();

            Console.WriteLine("Güncelleme Başarılı");


            #endregion







            Console.ReadLine();
        }


    }
}
