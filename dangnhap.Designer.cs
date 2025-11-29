namespace dangnhap
{
    partial class dangnhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_taikhoan = new System.Windows.Forms.TextBox();
            this.textBox_matkhau = new System.Windows.Forms.TextBox();
            this.linkLabel_quenmatkhau = new System.Windows.Forms.LinkLabel();
            this.linkLabel_dangky = new System.Windows.Forms.LinkLabel();
            this.button_dangnhap = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_taikhoan
            // 
            this.textBox_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_taikhoan.HideSelection = false;
            this.textBox_taikhoan.Location = new System.Drawing.Point(336, 194);
            this.textBox_taikhoan.Multiline = true;
            this.textBox_taikhoan.Name = "textBox_taikhoan";
            this.textBox_taikhoan.Size = new System.Drawing.Size(253, 49);
            this.textBox_taikhoan.TabIndex = 1;
            this.textBox_taikhoan.TextChanged += new System.EventHandler(this.textBox_taikhoan_TextChanged);
            // 
            // textBox_matkhau
            // 
            this.textBox_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_matkhau.HideSelection = false;
            this.textBox_matkhau.Location = new System.Drawing.Point(336, 270);
            this.textBox_matkhau.Multiline = true;
            this.textBox_matkhau.Name = "textBox_matkhau";
            this.textBox_matkhau.PasswordChar = '*';
            this.textBox_matkhau.Size = new System.Drawing.Size(253, 49);
            this.textBox_matkhau.TabIndex = 3;
            // 
            // linkLabel_quenmatkhau
            // 
            this.linkLabel_quenmatkhau.AutoSize = true;
            this.linkLabel_quenmatkhau.Location = new System.Drawing.Point(246, 360);
            this.linkLabel_quenmatkhau.Name = "linkLabel_quenmatkhau";
            this.linkLabel_quenmatkhau.Size = new System.Drawing.Size(103, 16);
            this.linkLabel_quenmatkhau.TabIndex = 5;
            this.linkLabel_quenmatkhau.TabStop = true;
            this.linkLabel_quenmatkhau.Text = "Quên mật khẩu?";
            this.linkLabel_quenmatkhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_quenmatkhau_LinkClicked);
            // 
            // linkLabel_dangky
            // 
            this.linkLabel_dangky.AutoSize = true;
            this.linkLabel_dangky.Location = new System.Drawing.Point(441, 360);
            this.linkLabel_dangky.Name = "linkLabel_dangky";
            this.linkLabel_dangky.Size = new System.Drawing.Size(56, 16);
            this.linkLabel_dangky.TabIndex = 6;
            this.linkLabel_dangky.TabStop = true;
            this.linkLabel_dangky.Text = "Đăng ký";
            this.linkLabel_dangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_dangky_LinkClicked);
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.BackColor = System.Drawing.Color.Red;
            this.button_dangnhap.Location = new System.Drawing.Point(592, 353);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(124, 30);
            this.button_dangnhap.TabIndex = 7;
            this.button_dangnhap.Text = "Đăng nhập";
            this.button_dangnhap.UseVisualStyleBackColor = false;
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangnhap_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::dangnhap.Properties.Resources.a_huy;
            this.pictureBox3.Location = new System.Drawing.Point(178, 270);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::dangnhap.Properties.Resources.a_huy;
            this.pictureBox2.Location = new System.Drawing.Point(178, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dangnhap.Properties.Resources.a_huy;
            this.pictureBox1.Location = new System.Drawing.Point(178, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dangnhap
            // 
            this.AcceptButton = this.button_dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_dangnhap);
            this.Controls.Add(this.linkLabel_dangky);
            this.Controls.Add(this.linkLabel_quenmatkhau);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox_matkhau);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox_taikhoan);
            this.Controls.Add(this.pictureBox1);
            this.Name = "dangnhap";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_taikhoan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox_matkhau;
        private System.Windows.Forms.LinkLabel linkLabel_quenmatkhau;
        private System.Windows.Forms.LinkLabel linkLabel_dangky;
        private System.Windows.Forms.Button button_dangnhap;
    }
}

