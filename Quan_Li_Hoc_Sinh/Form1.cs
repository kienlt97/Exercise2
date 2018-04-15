using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Quan_Li_Hoc_Sinh.frmExtra;

namespace Quan_Li_Hoc_Sinh
{
	public partial class frmMain : Form 
	{
		public frmMain()
		{
			
			InitializeComponent();
			 
		}
		DataConnection dt = new DataConnection();
		 
		private void frmMain_Load(object sender, EventArgs e)
		{
 
		}
		frmForm frmm = new frmForm();
		private void btnlogin_Click(object sender, EventArgs e)
		{
			dt.OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "KiemTraDN";
			cmd.Connection = dt.conn;

			cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = txtuser.Text;
			cmd.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = txtpass.Text;
			SqlDataReader reader = cmd.ExecuteReader();
			if (reader.Read())
			{
				this.Controls.Clear();
				frmm.Dock = DockStyle.Fill;
				this.Controls.Add(frmm);
			}
			else
			{
				MessageBox.Show("Đăng nhập thất bại");
			}
			reader.Close();
		}

        frmDangKi frmdk = new frmDangKi();
 		private void taotailkhoan_Click(object sender, EventArgs e)
		{
            this.Hide();
            frmdk.ShowDialog();
            this.Show();
		}

		private void taotailkhoan_MouseHover(object sender, EventArgs e)
		{
			taotailkhoan.ForeColor = Color.White;
		}

		private void taotailkhoan_MouseLeave(object sender, EventArgs e)
		{
			taotailkhoan.ForeColor = Color.Black;
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }

}
