using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BanDia
{
    public class ketnoicsdl
    {
        SqlConnection conn;

        public ketnoicsdl()
        {
            string str = "Data Source=DESKTOP-9BAJ70V\\SQLEXPRESS;Initial Catalog=Final1;Integrated Security=True";
            conn = new SqlConnection(str);
        }

        public DataTable Execute(string query)
        {
            DataTable dt = new DataTable();
            conn.Open();
            //lay query tu conn
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            //query conn va tra du lieu ve dt
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public void ExecuteNonQuery(string query)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void openConection()
        {
            if (ConnectionState.Closed == conn.State)
            {
                try
                {
                    conn.Open();
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối");
                }
            }
        }

        public void closeConection()
        {
            if (ConnectionState.Open == conn.State)
            {
                try
                {
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối");
                }
            }
        }

        public DataTable getLogin(string query, string user, string pass)
        {
            DataTable dt = new DataTable();
            conn.Open();
            //lay query tu conn
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@TaiKhoan", user);
            cmd.Parameters.AddWithValue("@MatKhau", pass);
            //query conn va tra du lieu ve dt
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public object ExecuteScalar(string query)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            object result = cmd.ExecuteScalar();
            conn.Close();
            return result;
        }

      
        
        
    }
}
