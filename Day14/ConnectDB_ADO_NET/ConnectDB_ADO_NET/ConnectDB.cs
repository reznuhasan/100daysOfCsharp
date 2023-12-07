using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectDB_ADO_NET
{
    public class ConnectDB
    {
        static void Main(string[] args)
        {
            ConnectDB.Connection();
            Console.ReadLine();
        }
        static void Connection()
        {
            string connectionString = "Data Source=DESKTOP-6P8AMML\\SQLEXPRESS;Initial Catalog=Practice;Integrated Security=true";
            SqlConnection con=new SqlConnection(connectionString);
            con.Open();
            if(con.State==System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Connection has been created Successfully");
            }
            con.Close();
        }
    }
    
}
