namespace dangnhap
{
    partial class quenmatkhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_emaildk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_laylaimatkhau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dangnhap.Properties.Resources.a_huy;
            this.pictureBox1.Location = new System.Drawing.Point(178, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(144, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email đăng ký";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_emaildk
            // 
            this.textBox_emaildk.Location = new System.Drawing.Point(325, 214);
            this.textBox_emaildk.Multiline = true;
            this.textBox_emaildk.Name = "textBox_emaildk";
            this.textBox_emaildk.Size = new System.Drawing.Size(249, 44);
            this.textBox_emaildk.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(144, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 44);
            this.label2.TabIndex = 5;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_laylaimatkhau
            // 
            this.button_laylaimatkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_laylaimatkhau.Location = new System.Drawing.Point(343, 345);
            this.button_laylaimatkhau.Name = "button_laylaimatkhau";
            this.button_laylaimatkhau.Size = new System.Drawing.Size(187, 68);
            this.button_laylaimatkhau.TabIndex = 6;
            this.button_laylaimatkhau.Text = "Lấy lại mật khẩu";
            this.button_laylaimatkhau.UseVisualStyleBackColor = false;
            this.button_laylaimatkhau.Click += new System.EventHandler(this.button_laylaimatkhau_Click);
            // 
            // quenmatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_laylaimatkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_emaildk);
            this.Controls.Add(this.pictureBox1);
            this.Name = "quenmatkhau";
            this.Text = "Quên mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_emaildk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_laylaimatkhau;
    }
}