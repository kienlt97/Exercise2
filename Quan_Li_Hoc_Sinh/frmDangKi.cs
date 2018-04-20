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

namespace Quan_Li_Hoc_Sinh
{
    public partial class frmDangKi : Form
    {
        public frmDangKi()
        {
            InitializeComponent();
        }
        DataConnection dt = new DataConnection();
        List<string> lst = new List<string>();
        public void PullData()
        {
            dt.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Login";
            cmd.Connection = dt.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string username = reader.GetString(0);
                lst.Add(username);
            }
            reader.Close();
        }
       
        public void AddTK_Database()
        {
            dt.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ThemTK";
            cmd.Connection = dt.conn;

            cmd.Parameters.Add("@USERNAME", SqlDbType.NVarChar).Value = txtUsername.Text;
            cmd.Parameters.Add("@PASS", SqlDbType.NVarChar).Value = txtPassword.Text;
            int ret = cmd.ExecuteNonQuery();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDangKi_Load_1(object sender, EventArgs e)
        {
            PullData();
        }
        bool check = true;
        private void btnDangky_Click(object sender, EventArgs e)
        {
            foreach (string us in lst)
            {
                if (us.Contains(txtUsername.Text) || txtPassword.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại hoặc mật khẩu không khớp !");
                    check = false;
                    break;
                }
                check = true;
            }
            if (check == true)
            {
                AddTK_Database();
                MessageBox.Show("Đăng ký thành công!");
            }
        }
    }
}
