using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;


namespace DataAccess.Table
{
   public class Guests
    {
        SqlConnection conn;
        public Guests()
        {
            string connStr = @"Server = SHANTO\SQLEXPRESS; Database = HotelManagementSystem; Integrated Security = true";
            conn = new SqlConnection(connStr);
        }
        public List<Guest> GetAllGuests()
        {
            string query = "select * from Guests";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Guest> data = new List<Guest>();

            while (reader.Read())
            {
                Guest gues = new Guest();
                gues.GuestId = reader.GetInt32(reader.GetOrdinal("GuestId"));
                gues.GuestName = reader.GetString(reader.GetOrdinal("GuestName"));
                gues.GuestPhone = reader.GetString(reader.GetOrdinal("GuestPhone"));
                gues.GuestCountry = reader.GetString(reader.GetOrdinal("GuestCountry"));
                gues.GuestUserName = reader.GetString(reader.GetOrdinal("GuestUserName"));
                gues.GuestPassword = reader.GetString(reader.GetOrdinal("GuestPassword"));
                data.Add(gues);
            }
              conn.Close();
            return data;

        }
        public Guest GetGuest(int id)
        {
            string query = "select * from Guests where GuestId = " + id;
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Guest gues = null;
            while (reader.Read())
            {
                gues = new Guest();
                gues.GuestId = reader.GetInt32(reader.GetOrdinal("GuestId"));
                gues.GuestName = reader.GetString(reader.GetOrdinal("GuestName"));
                gues.GuestPhone = reader.GetString(reader.GetOrdinal("GuestPhone"));
                gues.GuestCountry = reader.GetString(reader.GetOrdinal("GuestCountry"));
                gues.GuestUserName = reader.GetString(reader.GetOrdinal("GuestUserName"));
                gues.GuestPassword = reader.GetString(reader.GetOrdinal("GuestPassword"));
               
            }
            conn.Close();
            return gues;
        } 
       public bool Insert(Guest gues )
        {
            string query = String.Format("Insert into Guests values ('{0}','{1}','{2}','{3}','{4}')", gues.GuestName, gues.GuestPhone, gues.GuestCountry, gues.GuestUserName, gues.GuestPassword);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);

            int r = cmd.ExecuteNonQuery();

            conn.Close();
            if (r > 0) return true;
            return false;

        }
        public bool CheckLogin(string username, string password)
        {
            string query = String.Format("select GuestName from Guests where GuestUserName='{0}' and GuestPassword='{1}'", username, password);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return true;
            }
            return false;

        }
        public Guest Search(string uname)
        {
            string query = String.Format("select * from Guests where GuestUserName='{0}'", uname);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Guest gues= null;
            while (reader.Read())
            {
                gues = new Guest();
                gues.GuestId = reader.GetInt32(reader.GetOrdinal("GuestId"));
                gues.GuestName = reader.GetString(reader.GetOrdinal("GuestName"));
                gues.GuestPhone = reader.GetString(reader.GetOrdinal("GuestPhone"));
                gues.GuestCountry = reader.GetString(reader.GetOrdinal("GuestCountry"));
                gues.GuestUserName = reader.GetString(reader.GetOrdinal("GuestUserName"));
                gues.GuestPassword = reader.GetString(reader.GetOrdinal("GuestPassword"));
            }
            conn.Close();
            return gues;

        }
        public bool Update(Guest gues)
        {
            string query = String.Format("Update Guests set GuestName='{0}' , GuestPhone='{1}' where GuuestUserName='{2}'", gues.GuestName, gues.GuestPhone, gues.GuestUserName);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
        public bool Delete(string username)
        {
            string query = String.Format("delete from Guests where GuestUserName='{0}'", username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0) { return true; }
            return false;
        }




    }
}
