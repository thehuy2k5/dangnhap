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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button_dangxuat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                dangnhap dn = new dangnhap();
                dn.ShowDialog();
                this.Close();

            }
        }
    }
}
