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
			this.grpdangnhap = new System.Windows.Forms.GroupBox();
			this.taotailkhoan = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.btnlogin = new System.Windows.Forms.Button();
			this.txtpass = new System.Windows.Forms.TextBox();
			this.txtuser = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.grpdangnhap.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpdangnhap
			// 
			this.grpdangnhap.BackColor = System.Drawing.SystemColors.Highlight;
			this.grpdangnhap.Controls.Add(this.taotailkhoan);
			this.grpdangnhap.Controls.Add(this.checkBox1);
			this.grpdangnhap.Controls.Add(this.btnlogin);
			this.grpdangnhap.Controls.Add(this.txtpass);
			this.grpdangnhap.Controls.Add(this.txtuser);
			this.grpdangnhap.Controls.Add(this.label2);
			this.grpdangnhap.Controls.Add(this.label1);
			this.grpdangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpdangnhap.Location = new System.Drawing.Point(155, 131);
			this.grpdangnhap.Name = "grpdangnhap";
			this.grpdangnhap.Size = new System.Drawing.Size(454, 227);
			this.grpdangnhap.TabIndex = 1;
			this.grpdangnhap.TabStop = false;
			this.grpdangnhap.Text = "Đăng Nhập :";
			// 
			// taotailkhoan
			// 
			this.taotailkhoan.AutoSize = true;
			this.taotailkhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.taotailkhoan.Location = new System.Drawing.Point(32, 187);
			this.taotailkhoan.Name = "taotailkhoan";
			this.taotailkhoan.Size = new System.Drawing.Size(143, 25);
			this.taotailkhoan.TabIndex = 5;
			this.taotailkhoan.Text = "Tạo Tài Khoản";
			this.taotailkhoan.Click += new System.EventHandler(this.taotailkhoan_Click);
			this.taotailkhoan.MouseLeave += new System.EventHandler(this.taotailkhoan_MouseLeave);
			this.taotailkhoan.MouseHover += new System.EventHandler(this.taotailkhoan_MouseHover);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(37, 126);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(154, 29);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Lưu Mật Khẩu";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// btnlogin
			// 
			this.btnlogin.Location = new System.Drawing.Point(280, 148);
			this.btnlogin.Name = "btnlogin";
			this.btnlogin.Size = new System.Drawing.Size(130, 34);
			this.btnlogin.TabIndex = 3;
			this.btnlogin.Text = "Đăng Nhập";
			this.btnlogin.UseVisualStyleBackColor = true;
			this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
			// 
			// txtpass
			// 
			this.txtpass.Location = new System.Drawing.Point(147, 89);
			this.txtpass.Name = "txtpass";
			this.txtpass.PasswordChar = '*';
			this.txtpass.Size = new System.Drawing.Size(263, 30);
			this.txtpass.TabIndex = 2;
			// 
			// txtuser
			// 
			this.txtuser.Location = new System.Drawing.Point(147, 43);
			this.txtuser.Name = "txtuser";
			this.txtuser.Size = new System.Drawing.Size(263, 30);
			this.txtuser.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mật Khẩu : ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tài Khoản : ";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(717, 530);
			this.Controls.Add(this.grpdangnhap);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmMain";
			this.Text = "Quản Lí Học Sinh";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.grpdangnhap.ResumeLayout(false);
			this.grpdangnhap.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpdangnhap;
		private System.Windows.Forms.Label taotailkhoan;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button btnlogin;
		private System.Windows.Forms.TextBox txtpass;
		private System.Windows.Forms.TextBox txtuser;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

