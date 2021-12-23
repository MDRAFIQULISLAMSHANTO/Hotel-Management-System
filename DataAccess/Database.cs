using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using DataAccess.Table;



namespace DataAccess
{
    public class Database
    {
        public Rooms Rooms { get; set; }
        public Guests Guests { get; set; }
        
        public Database()
        {
            /* string connStr = @"Server = SHANTO\SQLEXPRESS; Database = HotelManagementSystem; Integrated Security = true";
             SqlConnection conn = new SqlConnection(connStr);
             Rooms = new Rooms(conn);*/
            Rooms = new Rooms();
            Guests = new Guests();
            

        }
    }
}
