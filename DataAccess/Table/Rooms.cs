using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DataAccess.Table
{
   public class Rooms
    {
        SqlConnection conn;

        public Rooms()
        {
            string connStr = @"Server = SHANTO\SQLEXPRESS; Database = HotelManagementSystem; Integrated Security = true";
            conn = new SqlConnection(connStr);
        }

        public void Insert()
        {
            string query = "insert into ";
        }
        public void Update() { }
        public void Delete() { }
        public void Get()
        {
            string query = "select * from Guest";
        }
        public void Search() { }
    }
}
