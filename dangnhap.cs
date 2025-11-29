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
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_quenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            quenmatkhau quenmk = new quenmatkhau();
            quenmk.ShowDialog();
        }

        private void linkLabel_dangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dangky dk = new dangky();
            dk.ShowDialog();
        }

        Modify modify = new Modify();
        private void button_dangnhap_Click(object sender, EventArgs e)
        {

            string tentkhoan = textBox_taikhoan.Text;
            string mk = textBox_matkhau.Text;
            if (tentkhoan.Trim() == "" || mk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else
            {
                string query = "SELECT * FROM Taikhoan  WHERE Tentaikhoan = '"
                    + tentkhoan + "' AND MATKHAU = '" 
                    + mk + "'";

                if (modify.taikhoans(query).Count != 0 )
                { 
                    //MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    home homes = new home();
                    homes.ShowDialog();
                    this.Close();
                }   
                else
                {
                    MessageBox.Show("Tài khoản or mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void textBox_taikhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
