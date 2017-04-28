using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using CryptoCore;
using System.Data;

namespace Class_and_Advance_method
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\George\Documents\Login.accdb";

            String Username = Console.ReadLine();
            String Password = Console.ReadLine();

            OleDbCommand cmd = new OleDbCommand("INSERT into Login (Username,Password) Values(@Username, @Password)");
            cmd.Connection = conn;

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.Add("@Username", OleDbType.VarChar).Value = Username;
                cmd.Parameters.Add("@Password", OleDbType.VarChar).Value = Password;

                try
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Data Added");
                    conn.Close();
                }
                catch (OleDbException ex)
                {
                   Console.WriteLine("error "+ex.Source);
                    conn.Close();
                }
            }
            else
            {
                Console.WriteLine("Connection Failed");
            }

            //    Console.WriteLine("please enter data");
            //    OleDbConnection conn = new OleDbConnection();
            //    string connstring = "Provider=Microsoft.ace.oledb.12.0;data source=C:\\Users\\George\\Documents\\datastructureassignment.accdb";
            //    conn.ConnectionString = connstring;
            //here:
            //    conn.Open();



            //    string input = Console.ReadLine();

            //    OleDbCommand cmd = new OleDbCommand("insert into Position(Position) values('" + input + "')", conn);
            //    cmd.ExecuteNonQuery();
            //    Console.WriteLine("data was added");
            //    conn.Close();
            //    goto here;



            //Console.WriteLine("this is program calculate leap year");
            //int input = Convert.ToInt32(Console.ReadLine());
            //bool isyearleap = ((input % 4 == 0) && (input % 100 != 0) || (input % 400 == 0));
            //if (isyearleap)
            //{
            //    Console.WriteLine(input + " is leap year");
            //}
            //else
            //{
            //    Console.WriteLine(input + " is not leap year");
            //}
            //Console.ReadLine();
        }
    }
}
