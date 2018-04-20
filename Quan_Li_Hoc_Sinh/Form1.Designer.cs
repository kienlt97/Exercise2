namespace Quan_Li_Hoc_Sinh
{
	partial class frmMain
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
			this.taotailkhoan = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.txtpass = new System.Windows.Forms.TextBox();
			this.txtuser = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnThoat = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.btnlogin = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// taotailkhoan
			// 
			this.taotailkhoan.AutoSize = true;
			this.taotailkhoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.taotailkhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.taotailkhoan.Location = new System.Drawing.Point(133, 288);
			this.taotailkhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.taotailkhoan.Name = "taotailkhoan";
			this.taotailkhoan.Size = new System.Drawing.Size(120, 19);
			this.taotailkhoan.TabIndex = 5;
			this.taotailkhoan.Text = "Tạo Tài Khoản";
			this.taotailkhoan.Click += new System.EventHandler(this.taotailkhoan_Click);
			this.taotailkhoan.MouseLeave += new System.EventHandler(this.taotailkhoan_MouseLeave);
			this.taotailkhoan.MouseHover += new System.EventHandler(this.taotailkhoan_MouseHover);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(285, 288);
			this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(136, 23);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "Lưu Mật Khẩu";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// txtpass
			// 
			this.txtpass.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtpass.Location = new System.Drawing.Point(285, 223);
			this.txtpass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtpass.Name = "txtpass";
			this.txtpass.PasswordChar = '*';
			this.txtpass.Size = new System.Drawing.Size(226, 21);
			this.txtpass.TabIndex = 2;
			this.txtpass.UseSystemPasswordChar = true;
			// 
			// txtuser
			// 
			this.txtuser.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtuser.Location = new System.Drawing.Point(285, 171);
			this.txtuser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtuser.Name = "txtuser";
			this.txtuser.Size = new System.Drawing.Size(226, 21);
			this.txtuser.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(133, 221);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mật khẩu";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(133, 170);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên đăng nhập";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel1.Controls.Add(this.btnThoat);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtuser);
			this.panel1.Controls.Add(this.txtpass);
			this.panel1.Controls.Add(this.btnlogin);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.taotailkhoan);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(636, 508);
			this.panel1.TabIndex = 2;
			// 
			// btnThoat
			// 
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThoat.Location = new System.Drawing.Point(415, 340);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(96, 31);
			this.btnThoat.TabIndex = 7;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(225, 90);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(219, 26);
			this.label3.TabIndex = 6;
			this.label3.Text = "Đăng nhập hệ thống";
			// 
			// btnlogin
			// 
			this.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnlogin.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnlogin.Location = new System.Drawing.Point(285, 340);
			this.btnlogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnlogin.Name = "btnlogin";
			this.btnlogin.Size = new System.Drawing.Size(96, 31);
			this.btnlogin.TabIndex = 4;
			this.btnlogin.Text = "Đăng nhập";
			this.btnlogin.UseVisualStyleBackColor = true;
			this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
			// 
			// frmMain
			// 
			this.AcceptButton = this.btnlogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(636, 508);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản Lí Học Sinh";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.Enter += new System.EventHandler(this.btnlogin_Click);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label taotailkhoan;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button btnlogin;
		private System.Windows.Forms.TextBox txtpass;
		private System.Windows.Forms.TextBox txtuser;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
    }
}

