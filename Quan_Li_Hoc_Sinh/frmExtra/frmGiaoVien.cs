using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Quan_Li_Hoc_Sinh
{
	public partial class frmGiaoVien : UserControl
	{
		public frmGiaoVien()
		{
			InitializeComponent();
		}
		DataConnection dt = new DataConnection();
		public int idx = 0;
		public int index()
		{
			return idx;
		}
		#region ShowData
		private void fixGiaoVien_Load(object sender, EventArgs e)
		{
			ShowData();
			Lop();
		}

		List<string> lst = new List<string>();
		List<string> lstMaLp = new List<string>();
		public void ShowData()
		{
			dt.OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from GIAO_VIEN";
			cmd.Connection = dt.conn;

			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				string magv = reader.GetString(0);
				string malop = reader.GetString(3);
				ListViewItem liv = new ListViewItem(magv);
				liv.SubItems.Add(reader.GetString(1));
				liv.SubItems.Add(reader.GetString(2));
				liv.SubItems.Add(malop);
				liv.SubItems.Add(reader.GetString(4));

				lst.Add(magv);
				lstMaLp.Add(malop);
				lvGV.Items.Add(liv);
			}
			reader.Close();
		}

		public void Lop()
		{
			dt.OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from LOP";
			cmd.Connection = dt.conn;

			SqlDataReader reader = cmd.ExecuteReader();
			cbMalop.Items.Clear();
			while (reader.Read())
			{
				string malop = reader.GetString(0);
				string tenlop = reader.GetString(1);

				cbMalop.Items.Add(malop + "- " + tenlop);
				cblopgiangday.Items.Add(malop + "- " + tenlop);
			}
			reader.Close();
		}
		#endregion
		#region selectedCombobox
		string malopcn = "";
 		private void cbMalop_SelectedIndexChanged(object sender, EventArgs e)
		{

			string valuePM = cbMalop.SelectedItem.ToString();
			string []arrPM = valuePM.Split('-');
			//string malp = arrPM[0];
			foreach (string ix in lstMaLp)
			{
				if (ix.Contains(arrPM[0]))
				{
					MessageBox.Show("Lớp đã giáo viên chủ nhiệm");
					malopcn = null;
					check = false;
					break;
				}
				check = true;
			}
			if (check == true)
			{
				malopcn = arrPM[0];
			}
		}
		string malpgd = "";
  		private void cblopgiangday_SelectedIndexChanged(object sender, EventArgs e)
		{
			string valuePM = cblopgiangday.SelectedItem.ToString();
			string[] arrPM1 = valuePM.Split('-');
			malpgd = arrPM1[0];
		}

		#endregion
		#region seletedListView
		private void lvGV_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtmagv.Enabled = false;
			btnthem.Enabled = false;
			btnXoa.Enabled = true;
			btnSua.Enabled = true;
			if (lvGV.SelectedItems.Count == 0) return;
			ListViewItem liv = lvGV.SelectedItems[0];
			txtmagv.Text = liv.SubItems[0].Text;
			txttenGV.Text = liv.SubItems[1].Text;
			txtthongtin.Text = liv.SubItems[2].Text;
			cbMalop.Text = liv.SubItems[3].Text;
			cblopgiangday.Text = liv.SubItems[4].Text;
		}
		#endregion
		#region Database
		public void repairGV_Database()
		{
			dt.OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SuaGV";
			cmd.Connection = dt.conn;

			cmd.Parameters.Add("@MAGV", SqlDbType.NVarChar).Value = txtmagv.Text;
			cmd.Parameters.Add("@TENGV", SqlDbType.NVarChar).Value = txttenGV.Text;
			cmd.Parameters.Add("@THONGTIN", SqlDbType.NVarChar).Value = txtthongtin.Text;
			cmd.Parameters.Add("@CNLOP", SqlDbType.NVarChar).Value = cbMalop.Text;
			cmd.Parameters.Add("@GDAY", SqlDbType.NVarChar).Value = cblopgiangday.Text;
			int ret = cmd.ExecuteNonQuery();
			lvGV.Items.Clear();
			if (ret > 0)
				ShowData();
		}
		public void AddGV_Database()
		{
			dt.OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "ThemGV";
			cmd.Connection = dt.conn;

			cmd.Parameters.Add("@MAGV", SqlDbType.NVarChar).Value = txtmagv.Text;
			cmd.Parameters.Add("@TENGV", SqlDbType.NVarChar).Value = txttenGV.Text;
			cmd.Parameters.Add("@THONGTIN", SqlDbType.NVarChar).Value = txtthongtin.Text;
			cmd.Parameters.Add("@CNLOP", SqlDbType.NVarChar).Value = malopcn;
			cmd.Parameters.Add("@GDAY", SqlDbType.NVarChar).Value = malpgd;
			int ret = cmd.ExecuteNonQuery();
			lvGV.Items.Clear();
			if (ret > 0)
				ShowData();
		}
		public void DeleteGV_Database()
		{
			dt.OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "XoaGV";
			cmd.Connection = dt.conn;

			cmd.Parameters.Add("@MAGV", SqlDbType.NVarChar).Value = txtmagv.Text;

			int ret = cmd.ExecuteNonQuery();
			lvGV.Items.Clear();
			if (ret > 0)
				ShowData();
		}
		#endregion
		#region Control
		private void btnSua_Click(object sender, EventArgs e)
		{
			idx = 2;
			btnthem.Enabled = true;
			if (lvGV.SelectedItems.Count == 0) return;
			ListViewItem liv = lvGV.SelectedItems[0];
			liv.SubItems[0].Text = txtmagv.Text;
			liv.SubItems[1].Text = txttenGV.Text;
			liv.SubItems[2].Text = txtthongtin.Text;
			liv.SubItems[3].Text = cbMalop.Text;
			liv.SubItems[4].Text = cblopgiangday.Text;
			 
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
            if (cbbTKGV.SelectedIndex == 0)
            {
                string sr = txtTimKiemGV.Text;
                dt.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from GIAO_VIEN Where MAGV like '%" + sr + "%'";
                cmd.Connection = dt.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvGV.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem liv = new ListViewItem(reader.GetString(0));
                    liv.SubItems.Add(reader.GetString(1));
                    liv.SubItems.Add(reader.GetString(2));
                    liv.SubItems.Add(reader.GetString(3));
                    liv.SubItems.Add(reader.GetString(4));
                    lvGV.Items.Add(liv);
                }
                reader.Close();
            }
            else if (cbbTKGV.SelectedIndex == 1)
            {
                string sr = txtTimKiemGV.Text;
                dt.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from GIAO_VIEN Where TENGV like '%" + sr + "%'";
                cmd.Connection = dt.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvGV.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem liv = new ListViewItem(reader.GetString(0));
                    liv.SubItems.Add(reader.GetString(1));
                    liv.SubItems.Add(reader.GetString(2));
                    liv.SubItems.Add(reader.GetString(3));
                    liv.SubItems.Add(reader.GetString(4));
                    lvGV.Items.Add(liv);
                }
                reader.Close();
            }
            else if (cbbTKGV.SelectedIndex == 2)
            {
                string sr = txtTimKiemGV.Text;
                dt.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from GIAO_VIEN Where THONGTIN like '%" + sr + "%'";
                cmd.Connection = dt.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvGV.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem liv = new ListViewItem(reader.GetString(0));
                    liv.SubItems.Add(reader.GetString(1));
                    liv.SubItems.Add(reader.GetString(2));
                    liv.SubItems.Add(reader.GetString(3));
                    liv.SubItems.Add(reader.GetString(4));
                    lvGV.Items.Add(liv);
                }
                reader.Close();
            }
            else if (cbbTKGV.SelectedIndex == 3)
            {
                string sr = txtTimKiemGV.Text;
                dt.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from GIAO_VIEN Where CNLOP like '%" + sr + "%'";
                cmd.Connection = dt.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvGV.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem liv = new ListViewItem(reader.GetString(0));
                    liv.SubItems.Add(reader.GetString(1));
                    liv.SubItems.Add(reader.GetString(2));
                    liv.SubItems.Add(reader.GetString(3));
                    liv.SubItems.Add(reader.GetString(4));
                    lvGV.Items.Add(liv);
                }
                reader.Close();
            }
            else if (cbbTKGV.SelectedIndex == 4)
            {
                string sr = txtTimKiemGV.Text;
                dt.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from GIAO_VIEN Where GDAY like '%" + sr + "%'";
                cmd.Connection = dt.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvGV.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem liv = new ListViewItem(reader.GetString(0));
                    liv.SubItems.Add(reader.GetString(1));
                    liv.SubItems.Add(reader.GetString(2));
                    liv.SubItems.Add(reader.GetString(3));
                    liv.SubItems.Add(reader.GetString(4));
                    lvGV.Items.Add(liv);
                }
                reader.Close();
            }
           
        }
		bool check = true;
		private void btnthem_Click(object sender, EventArgs e)
		{
			idx = 1;
			string magv = "";
			foreach (string us in lst)
			{

				if (us.Contains(txtmagv.Text))
				{
					MessageBox.Show("Mã nhân viên tồn tại !");
					check = false;
					break;
				}
				check = true;
			}
			if (check == true)
			{
				magv = txtmagv.Text;
				ListViewItem liv = new ListViewItem(magv);
				liv.SubItems.Add(txttenGV.Text);
				liv.SubItems.Add(txtthongtin.Text);
				liv.SubItems.Add(malopcn);
				liv.SubItems.Add(malpgd);
				lvGV.Items.Add(liv);
			}

		}
		private void btnReset_Click(object sender, EventArgs e)
		{
			btnthem.Enabled = true;
			btnSua.Enabled = false;
			btnXoa.Enabled = false;
			txtmagv.Enabled = true;
			txtmagv.ResetText();
			txttenGV.ResetText();
			txtthongtin.ResetText();
			cbMalop.Refresh();
			cbMalop.ResetText();
			cblopgiangday.Refresh();
			cblopgiangday.ResetText();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			idx = 3;
			if (lvGV.SelectedItems != null)
			{
				for (int i = 0; i < lvGV.Items.Count; i++)
				{
					if (lvGV.Items[i].Selected)
					{
						lvGV.Items[i].Remove();
						i--;
					}
				}
			}
		}
        #endregion

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
