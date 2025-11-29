using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace dangnhap
{
    internal class Modify
    {
        public Modify()
        {

        }
        SqlCommand sqlcommand;
        //dùng để truy vấn dữ liệu update, insert, delete
        SqlDataReader sqlDataReader;
        //dùng để đọc dữ liệu trong bảng
        public List<Taikhoan> taikhoans(string query) //dùng để check tk
        {
            List<Taikhoan> taikhoans = new List<Taikhoan>();
            using (SqlConnection sqlconnection = Connection.GetConnection())
            {
                sqlconnection.Open();
                sqlcommand = new SqlCommand(query, sqlconnection);
                sqlDataReader = sqlcommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    taikhoans.Add(new Taikhoan(sqlDataReader.GetString(0), sqlDataReader.GetString(1)));
                }
                sqlconnection.Close();
            }

            return taikhoans;
        }

        public void Comand(string query) //check đăng ký
        {
            using (SqlConnection sqlconnection = Connection.GetConnection())
            {
                sqlconnection.Open();
                sqlcommand = new SqlCommand(query, sqlconnection);
                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
            }
        }
    }
}
