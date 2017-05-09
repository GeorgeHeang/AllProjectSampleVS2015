using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToIndrahanuConsole
{
    class Program
    {
        public const string ConnectionString = "Data Source=(local);Initial Catalog=Indrahanu;Integrated Security=True";
        static void Main(string[] args)
        {
            if(IsUpdatable(DateTime.Now,"11:00 AM"))
            {
                Console.WriteLine(true);
            }
            Console.ReadLine();
        }

        public static bool IsUpdatable(DateTime date, string time)
        {
            try
            {
                using(var connection= new SqlConnection(ConnectionString))
                {
                    var t = DateTime.ParseExact(time, "hh:mm tt", CultureInfo.InvariantCulture);
                    var command = new SqlCommand("SELECT * FROM tbl_Registration_sub WHERE ApointmentDate=@d AND MeetingTime=@t;", connection);
                    command.Parameters.AddWithValue("@d", date.Date.ToShortDateString());
                    command.Parameters.AddWithValue("@t", t.TimeOfDay);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    return !reader.HasRows;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
    }
}
