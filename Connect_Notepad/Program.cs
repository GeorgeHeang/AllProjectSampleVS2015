using System;
using System.Data.OleDb;
using System.IO;

namespace Connect_Notepad
{
    class Program
    {
        static void Main(string[] args)
        {
            #region a
            //int counter = 0;
            //string line;
            //// Read the file and display it line by line.
            //System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\George\Desktop\test.txt");
            //while ((line = file.ReadLine()) != null)
            //{
            //    System.Console.WriteLine(line);
            //    counter++;
            //}
            //file.Close();
            //string text = Console.ReadLine();
            //using (System.IO.StreamWriter files = new System.IO.StreamWriter(@"C:\Users\George\Desktop\test.txt",true )) 
            //{
            //    files.WriteLine(text);
            //    Console.WriteLine("Text added");
            //}
            #endregion

            #region Exception
            //string[]fruit = { "apple", "orange", "mango", "grape" };
            //try
            //{
            //    for (int i = 0; i <=fruit.Length; i++)
            //    {
            //        Console.WriteLine(fruit[i]);
            //        throw (new IndexOutOfRangeException());
            //    }
            //}
            //catch (IndexOutOfRangeException ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            #endregion
            //try
            //{
            //    string text = null ;
            //    OleDbConnection access = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;data source=C:\\Users\\George\\Documents\\datastructureassignment.accdb");
            //    OleDbCommand command = new OleDbCommand("SELECT Staff_ID FROM tbl_UserInfo WHERE [UserName]='george';",access);
            //    access.Open();
            //    OleDbDataReader reader= command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        text = reader["Staff_ID"].ToString();
            //        using (StreamWriter files = new StreamWriter(@"C:\Users\George\Desktop\test.txt", false))
            //        {
            //            files.WriteLine(text);
            //            Console.WriteLine("Added");
            //        }
            //    }
            //}

            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            //OleDbConnection access = new OleDbConnection("Provider==Microsoft.ace.oledb.12.0;data source=C:\\Users\\George\\Documents\\datastructureassignment.accdb");




            string line;
            long StaffID = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\George\Desktop\test.txt");
            while ((line = file.ReadLine()) != null)
            {
                StaffID = Convert.ToInt64(line);
                Console.WriteLine(StaffID.ToString());
            }
            OleDbConnection access = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;data source=C:\\Users\\George\\Documents\\datastructureassignment.accdb");
            OleDbCommand command = new OleDbCommand("SELECT * FROM tbl_StaffInformation where ID=1;", access);
            access.Open();
            OleDbDataReader result = command.ExecuteReader();
            while (result.Read())
            {
                Console.WriteLine(result["StaffName"].ToString());
            }
        }

    }
}
