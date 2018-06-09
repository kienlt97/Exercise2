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
	public partial class frmLop_MonHoc : UserControl
	{
		public frmLop_MonHoc()
		{
			InitializeComponent();
		}
		DataConnection dt = new DataConnection();
		public int idx = 0;
		public int index()
		{
			return idx;
		}
		// Lớp Học
 		#region ShowData
			private void frmLop_MonHoc_Load(object sender, EventArgs e)
			{
				LopHoc();
				MonHoc();
			}
			public void MonHoc()
			{
				dt.OpenConnection();
				SqlCommand cmd = new SqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "SELECT *FROM MONHOC";
				cmd.Connection = dt.conn;

				SqlDataReader reader = cmd.ExecuteReader();
				lvMonHoc.Items.Clear();
				while (reader.Read())
				{
					ListViewItem liv = new ListViewItem(reader.GetString(0));
					liv.SubItems.Add(reader.GetString(1));
					liv.SubItems.Add(reader.GetString(2));
					lvMonHoc.Items.Add(liv);
				}
				reader.Close();
			}

			public void LopHoc()
			{
				dt.OpenConnection();
				SqlCommand cmd = new SqlCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "select * from LOP";
				cmd.Connection = dt.conn;

				SqlDataReader reader = cmd.ExecuteReader();
				lvLopHoc.Items.Clear();
				while (reader.Read())
				{
					ListViewItem liv = new ListViewItem(reader.GetString(0));
					liv.SubItems.Add(reader.GetString(1));
 					lvLopHoc.Items.Add(liv);
				}
				reader.Close();
			}
		#endregion
 		#region Control_lophoc
			private void btnthemlh_Click(object sender, EventArgs e)
			{
				idx = 1;
				ListViewItem liv = new ListViewItem(txtmalp.Text);
				liv.SubItems.Add(txttenlp.Text);
				lvLopHoc.Items.Add(liv);
			}
			private void btnsualh_Click(object sender, EventArgs e)
			{
				idx = 2;
				btnthemlh.Enabled = true;
				if (lvLopHoc.SelectedItems.Count == 0) return;
				ListViewItem liv = lvLopHoc.SelectedItems[0];
				liv.SubItems[0].Text = txtmalp.Text;
				liv.SubItems[1].Text = txttenlp.Text;
		 	}

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            idx = 3;
            if (lvLopHoc.SelectedItems != null)
            {
                for (int i = 0; i < lvLopHoc.Items.Count; i++)
                {
                    if (lvLopHoc.Items[i].Selected)
                    {
                        lvLopHoc.Items[i].Remove();
                        i--;
                    }
                }
            }
        }
        private void btnresetlh_Click(object sender, EventArgs e)
			{
				btnthemlh.Enabled = true;
				btnsualh.Enabled = false;
 				txtmalp.Enabled = true;
				txttenlp.Clear();
				txtmalp.Clear();
		}
		#endregion
		#region SelectedListView_lophoc
			private void lvLopHoc_SelectedIndexChanged(object sender, EventArgs e)
			{
				txtmalp.Enabled = false;
				btnthemlh.Enabled = false;
 				btnsualh.Enabled = true;
				if (lvLopHoc.SelectedItems.Count == 0) return;
				ListViewItem liv = lvLopHoc.SelectedItems[0];
				txtmalp.Text = liv.SubItems[0].Text;
				txttenlp.Text = liv.SubItems[1].Text;
			}
		#endregion
		#region Database_lophoc
		public void repairLH_Database()
		{
			dt.OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SuaLH";
			cmd.Connection = dt.conn;

			cmd.Parameters.Add("@MALOP", SqlDbType.NVarChar).Value = txtmalp.Text;
			cmd.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = txttenlp.Text;
			 
			int ret = cmd.ExecuteNonQuery();
			lvLopHoc.Items.Clear();
			if (ret > 0)
				LopHoc();
		}
		public void AddLH_Database()
		{
			dt.OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "ThemLH";
			cmd.Connection = dt.conn;

			cmd.Parameters.Add("@MALOP", SqlDbType.NVarChar).Value = txtmalp.Text;
			cmd.Parameters.Add("@TENLOP", SqlDbType.NVarChar).Value = txttenlp.Text;
			int ret = cmd.ExecuteNonQuery();
			lvLopHoc.Items.Clear();
			if (ret > 0)
				LopHoc();
		}
		 
		#endregion
		// Môn học
		#region Control_monhoc
		private void btnthemmh_Click(object sender, EventArgs e)
			{
			idx = 4;
				ListViewItem liv = new ListViewItem(txtmamh.Text);
				liv.SubItems.Add(txttenmh.Text);
				liv.SubItems.Add(txtghichu.Text);

				lvMonHoc.Items.Add(liv);
			}
			private void btnsuamh_Click(object sender, EventArgs e)
			{
				idx = 5;
				btnthemmh.Enabled = true;
				if (lvMonHoc.SelectedItems.Count == 0) return;
				ListViewItem liv = lvMonHoc.SelectedItems[0];
				liv.SubItems[0].Text = txtmamh.Text;
				liv.SubItems[1].Text = txttenmh.Text;
				liv.SubItems[2].Text = txtghichu.Text;
			}

			private void btnxoamh_Click(object sender, EventArgs e)
			{
				idx = 6;
				if (lvMonHoc.SelectedItems != null)
				{
					for (int i = 0; i < lvMonHoc.Items.Count; i++)
					{
						if (lvMonHoc.Items[i].Selected)
						{
							lvMonHoc.Items[i].Remove();
							i--;
						}
					}
				}
			}
			private void btnresetmh_Click(object sender, EventArgs e)
			{
				btnthemmh.Enabled = true;
				btnsuamh.Enabled = false;
				btnxoamh.Enabled = false;
				txtmamh.Enabled = true;
				txtmamh.Clear();
				txttenmh.Clear();
				txtghichu.Clear();
			}
		#endregion
		#region SelectedLisbView_monhoc
			private void lvMonHoc_SelectedIndexChanged(object sender, EventArgs e)
			{
				txtmamh.Enabled = false;
				btnthemmh.Enabled = false;
				btnxoamh.Enabled = true;
				btnsuamh.Enabled = true;
				if (lvMonHoc.SelectedItems.Count == 0) return;
				ListViewItem liv = lvMonHoc.SelectedItems[0];
				txtmamh.Text = liv.SubItems[0].Text;
				txttenmh.Text = liv.SubItems[1].Text;
				txtghichu.Text = liv.SubItems[2].Text;
			}
		#endregion
		#region Database_monhoc
		public void repairMH_Database()
		{
			dt.OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SuaMH";
			cmd.Connection = dt.conn;

			cmd.Parameters.Add("@MAMON", SqlDbType.NVarChar).Value = txtmamh.Text;
			cmd.Parameters.Add("@TENMON", SqlDbType.NVarChar).Value = txttenmh.Text;
			cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = txtghichu.Text;
			 
			int ret = cmd.ExecuteNonQuery();
			lvMonHoc.Items.Clear();
			if (ret > 0)
				MonHoc();
		}
		public void AddMH_Database()
		{
			dt.OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "ThemMH";
			cmd.Connection = dt.conn;

			cmd.Parameters.Add("@MAMON", SqlDbType.NVarChar).Value = txtmamh.Text;
			cmd.Parameters.Add("@TENMON", SqlDbType.NVarChar).Value = txttenmh.Text;
			cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = txtghichu.Text;
			int ret = cmd.ExecuteNonQuery();
			lvMonHoc.Items.Clear();
			if (ret > 0)
				MonHoc();
		}
		public void DeleteMH_Database()
		{
			dt.OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "XoaGV";
			cmd.Connection = dt.conn;

			cmd.Parameters.Add("@MAMON", SqlDbType.NVarChar).Value = txtmamh.Text;

			int ret = cmd.ExecuteNonQuery();
			lvMonHoc.Items.Clear();
			if (ret > 0)
				MonHoc();
		}
        #endregion

        #region TimKiem_LopHoc
        private void btnTimKiemLop_Click(object sender, EventArgs e)
        {
            if (cbbTKLop.SelectedIndex == 0)
            {
                string sr = txtTimKiemLop.Text;
                dt.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from LOP Where MALOP like '%" + sr + "%'";
                cmd.Connection = dt.conn;

                SqlDataReader reader = cmd.ExecuteReader();
                lvLopHoc.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem liv = new ListViewItem(reader.GetString(0));
                    liv.SubItems.Add(reader.GetString(1));
                    lvLopHoc.Items.Add(liv);
                }
                reader.Close();
            }
            else if (cbbTKLop.SelectedIndex == 1)
            {
                string sr = txtTimKiemLop.Text;
                dt.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from LOP Where TENLOP like '%" + sr + "%'";
                cmd.Connection = dt.conn;

                SqlDataReader reader = cmd.ExecuteReader();
                lvLopHoc.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem liv = new ListViewItem(reader.GetString(0));
                    liv.SubItems.Add(reader.GetString(1));
                    lvLopHoc.Items.Add(liv);
                }
                reader.Close();
            }
        }
        #endregion

        #region TimKiem_MonHoc
        private void btnTimKiemMon_Click(object sender, EventArgs e)
        {
            if (cbbTKMon.SelectedIndex == 0)
            {
                string sr = txtTimKiemMon.Text;
                dt.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT *FROM MONHOC Where MAMON like '%" + sr + "%'";
                cmd.Connection = dt.conn;

                SqlDataReader reader = cmd.ExecuteReader();
                lvMonHoc.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem liv = new ListViewItem(reader.GetString(0));
                    liv.SubItems.Add(reader.GetString(1));
                    liv.SubItems.Add(reader.GetString(2));
                    lvMonHoc.Items.Add(liv);
                }
                reader.Close();
            }
            else if (cbbTKMon.SelectedIndex == 1)
            {
                string sr = txtTimKiemMon.Text;
                dt.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT *FROM MONHOC Where TENMON like '%" + sr + "%'";
                cmd.Connection = dt.conn;

                SqlDataReader reader = cmd.ExecuteReader();
                lvMonHoc.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem liv = new ListViewItem(reader.GetString(0));
                    liv.SubItems.Add(reader.GetString(1));
                    liv.SubItems.Add(reader.GetString(2));
                    lvMonHoc.Items.Add(liv);
                }
                reader.Close();
            }
        }
        #endregion

    }
}
