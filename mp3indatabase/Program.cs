using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Collections;

namespace mp3indatabase
{
    class Program
    {
        static void Main(string[] args)
        {






            using (SqlConnection connection = new SqlConnection("Data Source=(local); Initial Catalog=Students;Integrated Security=True;"))
            {
                string pathmp3 = @"d:\daylight.mp3";
                string pathNewmp3 = @"d:\newmp3.mp3";

                //Insert to database
                // Create the file.
                Byte[] byteFromMp3 = File.ReadAllBytes(pathmp3);
                string f = Encoding.Default.GetString(byteFromMp3);
                //column song is data type text in database
                SqlCommand command = new SqlCommand("INSERT INTO [dbo].[table_Song] ([Song]) VALUES (@filedefinition)", connection);
                command.Parameters.AddWithValue("@filedefinition", f);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                //Select from database as string and create new mp3 file
                DataSet dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand("SELECT * FROM [dbo].[table_Song]", connection));
                adapter.Fill(dataset, "TableSong");
                DataRow row = dataset.Tables[0].Rows[0];
                byte[] byteMp3FromDatabase = Encoding.Default.GetBytes(row[1].ToString());
                if (!File.Exists(pathNewmp3))
                {
                    // Create the file.
                    using (FileStream fs = File.Create(pathNewmp3))
                    {
                        fs.Write(byteMp3FromDatabase, 0, byteMp3FromDatabase.Length);
                    }
                }

                // Open the stream and read it back.
                using (FileStream fs = File.Open(pathNewmp3, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    byte[] b = new byte[1024];
                    UTF8Encoding temp = new UTF8Encoding(true);

                    while (fs.Read(b, 0, b.Length) > 0)
                    {
                        Console.WriteLine(temp.GetString(b));
                    }
                }
            }
        }
    }
}
