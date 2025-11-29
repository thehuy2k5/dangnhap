using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace dangnhap
{
    public partial class dangky : Form
    {
        public dangky()
        {
            InitializeComponent();
        }

        public bool checkAccount(string username)
        {
            //check tk và mk 
            return Regex.IsMatch(username, @"^[a-zA-Z0-9]{6,20}$");
        }
        public bool checkEmail(string email)
        {
            //check email
            return Regex.IsMatch(email, @"^[a-zA-Z0-9]{3,20}@gmail.com(.vn|)$");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dangky_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();
        private void button_dangky_Click(object sender, EventArgs e)
        {
            string tentk = textBox_tk.Text;
            string matkhau = textBox_mk.Text;
            string xnmatkhau = textBox_xnmk.Text;
            string email = textBox_email.Text;  
            if(!checkAccount(tentk))
            {
                MessageBox.Show("Tài khoản không hợp lệ! (6-20 ký tự gồm chữ và số)");
                return;
            }
            if(!checkAccount(matkhau))
            {
                MessageBox.Show("Mật khẩu không hợp lệ! (6-20 ký tự gồm chữ và số)");
                return;
            }
            if(xnmatkhau != matkhau)
            {
                MessageBox.Show("Xác nhận mật khẩu không hợp lệ!");
                return;
            }
            if (!checkEmail(email)){
                MessageBox.Show("Email không hợp lệ! ");
                return;
            }
            if(modify.taikhoans("select * from Taikhoan where email='"+email+"'").Count!=0)
            {
                MessageBox.Show("Email đã tồn tại!");
                return;
            }
            try
            {
                string query = "insert into Taikhoan values('" + tentk + "','" + matkhau + "','" + email + "')";
                modify.Comand(query);
                if(MessageBox.Show("Đăng ký thành công!","Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
               
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tài khoản đã được đăng ký!");
            }


        }
    }
}
