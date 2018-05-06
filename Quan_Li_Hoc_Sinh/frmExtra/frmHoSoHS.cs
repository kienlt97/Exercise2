using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quan_Li_Hoc_Sinh.frmExtra
{
	public partial class frmHoSoHS : UserControl
	{
		public frmHoSoHS()
		{
			InitializeComponent();
		}
		DataConnection dt = new DataConnection();
		#region ShowData
		private void frmHoSoHS_Load(object sender, EventArgs e)
		{
			ShowData();
            Lop();
		}
        List<string> lst = new List<string>();
        public void ShowData()
		{
			dt.OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from HOSOHOCSINH";
			cmd.Connection = dt.conn;

			SqlDataReader reader = cmd.ExecuteReader();
			
			while (reader.Read())
			{
                string mahs = reader.GetString(0);
                ListViewItem liv = new ListViewItem(reader.GetString(0));
				liv.SubItems.Add(reader.GetString(1));
				liv.SubItems.Add(reader.GetString(2));
                liv.SubItems.Add(reader.GetDateTime(3).ToString());
                liv.SubItems.Add(reader.GetString(4));              
                liv.SubItems.Add(reader.GetString(8));
                liv.SubItems.Add(reader.GetString(5));
                lst.Add(mahs);
				lvHS.Items.Add(liv);
			}
			reader.Close();
		}
        #endregion

        private void lvHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmahs.Enabled = false;
            btnthemhs.Enabled = false;
            btnXoahs.Enabled = true;
            btnSuahs.Enabled = true;
            if (lvHS.SelectedItems.Count == 0) return;
            ListViewItem liv = lvHS.SelectedItems[0];
            txtmahs.Text = liv.SubItems[0].Text;
            txttenhs.Text = liv.SubItems[1].Text;
            if(rdnam.Text.ToLower() == liv.SubItems[2].Text.ToLower())
            {
                rdnam.Checked = true;
                rdnu.Checked = false;
            }
            else
            {
                rdnu.Checked = true;
                rdnam.Checked = false;
            }
                       
            dtNS.Value = DateTime.Parse(liv.SubItems[3].Text);
            txtdiachi.Text = liv.SubItems[4].Text;
            cblop.Text = liv.SubItems[5].Text;
            txtsdt.Text = liv.SubItems[6].Text;
        }


        public int kths = 0;
        public int kt()
        {
            return kths;
        }
        public void Lop()
        {
            dt.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from LOP";
            cmd.Connection = dt.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            cblop.Items.Clear();
            while (reader.Read())
            {
                string malop = reader.GetString(0);
                string tenlop = reader.GetString(1);

                cblop.Items.Add(malop + "- " + tenlop);
            }
            reader.Close();
        }

        public void DeleteHS_Database()
        {
            dt.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "XOAHS";
            cmd.Connection = dt.conn;

            cmd.Parameters.Add("@MAHS", SqlDbType.NVarChar).Value = txtmahs.Text;

            int rekt = cmd.ExecuteNonQuery();
            lvHS.Items.Clear();
            if (rekt > 0)
                ShowData();
        }

        private void btnXoahs_Click(object sender, EventArgs e)
        {
            kths = 3;
            if (lvHS.SelectedItems != null)
            {
                for (int i = 0; i < lvHS.Items.Count; i++)
                {
                    if (lvHS.Items[i].Selected)
                    {
                        lvHS.Items[i].Remove();
                        i--;
                    }
                }
            }
        }

        private void txtmahs_TextChanged(object sender, EventArgs e)
        {

        }
        bool check = true;
        private void btnthemhs_Click(object sender, EventArgs e)
        {
            kths = 1;
            string mahs = "";
            foreach (string us in lst)
            {
                if (us.Contains(txtmahs.Text))
                {
                    MessageBox.Show("Mã học sinh đã tồn tại !");
                    check = false;
                    break;
                }
                check = true;
            }
            if (check == true)
            {
                mahs = txtmahs.Text;
                ListViewItem liv = new ListViewItem(mahs);
                liv.SubItems.Add(txttenhs.Text);
                if (rdnam.Checked == true)
                {
                    liv.SubItems.Add(rdnam.Text);
                }
                else
                {
                    liv.SubItems.Add(rdnu.Text);
                }
                liv.SubItems.Add(dtNS.Text);
                liv.SubItems.Add(txtdiachi.Text);
                liv.SubItems.Add(cblop.Text);
                liv.SubItems.Add(txtsdt.Text);
                lvHS.Items.Add(liv);
               
            }
        }

        public void AddHsToDatabase()
        {
            dt.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "THEMHS";
            cmd.Connection = dt.conn;

            cmd.Parameters.Add("@MAHS", SqlDbType.NVarChar).Value = txtmahs.Text;
            cmd.Parameters.Add("@TENHS", SqlDbType.NVarChar).Value = txttenhs.Text;
            if(rdnam.Checked == true)
            {
                cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = rdnam.Text;
            }
            else
            {
                cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = rdnu.Text;
            }
            cmd.Parameters.Add("@NGAYSINH", SqlDbType.Date).Value = dtNS.Value;
            cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = txtdiachi.Text;
            cmd.Parameters.Add("@LOPHOC", SqlDbType.VarChar).Value = malop;
            cmd.Parameters.Add("@SODIENTHOAI", SqlDbType.VarChar).Value = txtsdt.Text;
            int ret = cmd.ExecuteNonQuery();
            lvHS.Items.Clear();
            if (ret > 0)
                ShowData();
        }
        private void btnSuahs_Click(object sender, EventArgs e)
        {
            kths = 2;
            btnthemhs.Enabled = true;
            if (lvHS.SelectedItems.Count == 0) return;
            ListViewItem liv = lvHS.SelectedItems[0];
            liv.SubItems[0].Text = txtmahs.Text;
            liv.SubItems[1].Text = txttenhs.Text;
            if (rdnam.Checked == true)
            {
                liv.SubItems[2].Text = rdnam.Text;
                liv.SubItems[2].Text = rdnu.Text;
            }
            else
            {
                liv.SubItems[2].Text = rdnam.Text;
                liv.SubItems[2].Text = rdnu.Text;
            }
            liv.SubItems[3].Text = dtNS.Text;
            liv.SubItems[4].Text = txtdiachi.Text;
            liv.SubItems[5].Text = cblop.Text;
            liv.SubItems[6].Text = txtsdt.Text;
        }
        public void FixHsToDatabase()
        {
            dt.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SUAHS";
            cmd.Connection = dt.conn;

            cmd.Parameters.Add("@MAHS", SqlDbType.NVarChar).Value = txtmahs.Text;
            cmd.Parameters.Add("@TENHS", SqlDbType.NVarChar).Value = txttenhs.Text;
            if (rdnam.Checked == true)
            {
                cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = rdnam.Text;
            }
            else
            {
                cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = rdnu.Text;
            }
            cmd.Parameters.Add("@NGAYSINH", SqlDbType.Date).Value = dtNS.Value;
            cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = txtdiachi.Text;
            cmd.Parameters.Add("@LOPHOC", SqlDbType.VarChar).Value = cblop.Text;
            cmd.Parameters.Add("@SODIENTHOAI", SqlDbType.VarChar).Value = txtsdt.Text;
            int ret = cmd.ExecuteNonQuery();
            lvHS.Items.Clear();
            if (ret > 0)
                ShowData();
        }
        string malop = "";
        private void cblop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valuePM = cblop.SelectedItem.ToString();
            string[] arrPM1 = valuePM.Split('-');
            malop = arrPM1[0];
        }

        private void btnReseths_Click(object sender, EventArgs e)
        {
            btnthemhs.Enabled = true;
            btnSuahs.Enabled = false;
            btnXoahs.Enabled = false;
            txtmahs.Enabled = true;
            txtmahs.ResetText();
            txttenhs.ResetText();
            dtNS.ResetText();
            txtdiachi.ResetText();
            cblop.ResetText();
            txtsdt.ResetText();
        }

        private void dtNS_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiemhs_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiemhs_Click(object sender, EventArgs e)
        {
            string sr = txtTimKiemhs.Text;
            dt.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from HOSOHOCSINH Where MAHS like '%" + sr + "%'";
            cmd.Connection = dt.conn;
            SqlDataReader reader = cmd.ExecuteReader();
            lvHS.Items.Clear();
            while (reader.Read())
            {
                ListViewItem liv = new ListViewItem(reader.GetString(0));
                liv.SubItems.Add(reader.GetString(1));
                liv.SubItems.Add(reader.GetString(2));
                liv.SubItems.Add(DateTime.Parse(reader[3].ToString()).ToString("dd/MM/yyyy"));
                liv.SubItems.Add(reader.GetString(4));
                liv.SubItems.Add(reader.GetString(8));
                liv.SubItems.Add(reader.GetString(5));
     
                lvHS.Items.Add(liv);
            }
            reader.Close();
        }
    }
}
