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
                liv.SubItems.Add(DateTime.Parse(reader[3].ToString()).ToString("dd/MM/yyyy"));
                liv.SubItems.Add(reader.GetString(4));
				liv.SubItems.Add(reader.GetString(8));
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
            rdnam.Text = liv.SubItems[2].Text;
            rdnu.Text = liv.SubItems[2].Text;
            dtNS.Text = liv.SubItems[3].Text;
            txtdiachi.Text = liv.SubItems[4].Text;
            cblop.Text = liv.SubItems[5].Text;
        }


        public int kths = 0;
        public int kt()
        {
            return kths;
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
            kths = 1;
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

        private void btnthemhs_Click(object sender, EventArgs e)
        {

        }

        private void btnSuahs_Click(object sender, EventArgs e)
        {

        }
    }
}
