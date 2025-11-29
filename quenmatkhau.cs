using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dangnhap
{
    public partial class quenmatkhau : Form
    {
        public quenmatkhau()
        {
            InitializeComponent();
            label2.Text = "";
        }
        Modify modify = new Modify();
        private void button_laylaimatkhau_Click(object sender, EventArgs e)
        {
            string email = textBox_emaildk.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email!");
               
            }
            else 
            { 
                string query = "select * from Taikhoan where email='" + email + "'";
         
                if (modify.taikhoans(query).Count == 0)
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Email không tồn tại!";
                }
                else
                {
                    label2.ForeColor = Color.Blue;
                    label2.Text = "Mật khẩu: " + modify.taikhoans(query)[0].MatKhau;
                }
            }
        }
    }
}
