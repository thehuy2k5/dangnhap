using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace dangnhap
{
    internal class Connection
    {
        
        private static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\cshap\dangnhap\Database1.mdf;Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
