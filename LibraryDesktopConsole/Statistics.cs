using K4os.Compression.LZ4.Internal;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDesktopConsole
{
    internal class Statistics
    {
        public static List<Book> bookList = new List<Book>();
        static MySqlConnection conn = null;
        static MySqlCommand comm = null;
        public Statistics()
        {
            read();

        }

        public static void read()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Clear();
            sb.Server = "localhost";
            sb.UserID = "anett";
            sb.Password = "7112";
            sb.Database = "books";
            sb.CharacterSet = "utf8";
            conn = new MySqlConnection(sb.ConnectionString);
            comm = conn.CreateCommand();
            try
            {
                conn.Open();

                comm.CommandText = "SELECT * FROM `books`";
                using (MySqlDataReader dr = comm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int id = dr.GetInt32("id");
                        string title = dr.GetString("title");
                        string author = dr.GetString("author");
                        int publishYear = dr.GetInt32("publish_year");
                        int pageCount = dr.GetInt32("page_count");

                        Book fresh = new Book(id, title, author, publishYear, pageCount);

                        bookList.Add(fresh);
                    }
                }
                conn.Close();
                Console.WriteLine("\n***** Reading is done! *****\n");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\n----- Reading is failed! -----\n");
            }
        }

        public void longestBook()
        {
            //Határozza meg az 500 oldalnál hosszabb könyvek számát!
            int count = 0;
            foreach (Book book in bookList)
            {
                if (book.page_count > 500)
                {
                    count++;
                }
            }
            Console.WriteLine("Az 500 oldalnál hosszabb könyvek száma: " + count);
        }
    }
}
            





