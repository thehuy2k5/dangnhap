namespace dangnhap
{
    partial class dangky
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_tk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_xnmk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.button_dangky = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_mk = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dangnhap.Properties.Resources.a_huy;
            this.pictureBox1.Location = new System.Drawing.Point(162, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox_tk
            // 
            this.textBox_tk.Location = new System.Drawing.Point(325, 152);
            this.textBox_tk.Multiline = true;
            this.textBox_tk.Name = "textBox_tk";
            this.textBox_tk.Size = new System.Drawing.Size(249, 44);
            this.textBox_tk.TabIndex = 0;
            this.textBox_tk.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(144, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tk";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(144, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "xác nhận mk";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_xnmk
            // 
            this.textBox_xnmk.Location = new System.Drawing.Point(325, 266);
            this.textBox_xnmk.Multiline = true;
            this.textBox_xnmk.Name = "textBox_xnmk";
            this.textBox_xnmk.PasswordChar = '*';
            this.textBox_xnmk.Size = new System.Drawing.Size(249, 44);
            this.textBox_xnmk.TabIndex = 2;
            this.textBox_xnmk.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(144, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 44);
            this.label3.TabIndex = 0;
            this.label3.Text = "email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(325, 316);
            this.textBox_email.Multiline = true;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(249, 44);
            this.textBox_email.TabIndex = 3;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button_dangky
            // 
            this.button_dangky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_dangky.Location = new System.Drawing.Point(325, 375);
            this.button_dangky.Name = "button_dangky";
            this.button_dangky.Size = new System.Drawing.Size(112, 38);
            this.button_dangky.TabIndex = 4;
            this.button_dangky.Text = "Đăng ký";
            this.button_dangky.UseVisualStyleBackColor = false;
            this.button_dangky.Click += new System.EventHandler(this.button_dangky_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(144, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 44);
            this.label4.TabIndex = 0;
            this.label4.Text = "mk";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_mk
            // 
            this.textBox_mk.Location = new System.Drawing.Point(325, 202);
            this.textBox_mk.Multiline = true;
            this.textBox_mk.Name = "textBox_mk";
            this.textBox_mk.PasswordChar = '*';
            this.textBox_mk.Size = new System.Drawing.Size(249, 44);
            this.textBox_mk.TabIndex = 1;
            this.textBox_mk.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dangky
            // 
            this.AcceptButton = this.button_dangky;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_mk);
            this.Controls.Add(this.button_dangky);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_xnmk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_tk);
            this.Controls.Add(this.pictureBox1);
            this.Name = "dangky";
            this.Text = "2";
            this.Load += new System.EventHandler(this.dangky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_tk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_xnmk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Button button_dangky;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_mk;
    }
}