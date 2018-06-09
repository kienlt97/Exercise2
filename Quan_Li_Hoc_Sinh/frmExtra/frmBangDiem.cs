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
    public partial class frmBangDiem : UserControl
    {
        public frmBangDiem()
        {
            InitializeComponent();
        }
        DataConnection dt = new DataConnection();

        #region ShowData
        private void frmBangDiem_Load(object sender, EventArgs e)
        {
            ShowData();
            Monhoc();
            Hocsinh();
        }
        List<string> lst = new List<string>();
        public void ShowData()
        {
            dt.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from BANGDIEM";
            cmd.Connection = dt.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            lvDB.Items.Clear();
            while (reader.Read())
            {
                ListViewItem liv = new ListViewItem(reader.GetString(0));
                liv.SubItems.Add(reader.GetString(1));
                liv.SubItems.Add(reader.GetString(2));
                liv.SubItems.Add(reader.GetDouble(3).ToString());
                liv.SubItems.Add(reader.GetDouble(4).ToString());
                liv.SubItems.Add(reader.GetDouble(5).ToString());
                liv.SubItems.Add(reader.GetDouble(6).ToString());
                lst.Add(reader.GetString(0));
                lvDB.Items.Add(liv);
            }
            reader.Close();
        }

        public void Monhoc()
        {
            dt.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from MONHOC";
            cmd.Connection = dt.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            cbmamon.Items.Clear();
            while (reader.Read())
            {
                string mamh = reader.GetString(0);
                string tenmh = reader.GetString(1);
                cbmamon.Items.Add(mamh + "- " + tenmh);
            }
            reader.Close();
        }

        public void Hocsinh()
        {
            dt.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from HOSOHOCSINH";
            cmd.Connection = dt.conn;

            SqlDataReader reader = cmd.ExecuteReader();
            cbmahs.Items.Clear();
            while (reader.Read())
            {
                string mahocsinh = reader.GetString(0);

                cbmahs.Items.Add(mahocsinh);
            }
            reader.Close();
        }
        #endregion

        #region SelectedListview
        private void lvDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmahs.Enabled = false;
            cbmamon.Enabled = false;
            btnthemd.Enabled = false;
            btnXoad.Enabled = true;
            btnSuad.Enabled = true;
            if (lvDB.SelectedItems.Count == 0) return;
            ListViewItem liv = lvDB.SelectedItems[0];
            cbmahs.Text = liv.SubItems[0].Text;
            cbmamon.Text = liv.SubItems[1].Text;
            txthocky.Text = liv.SubItems[2].Text;
            txtdiemmieng.Text = liv.SubItems[3].Text;
            txt15p.Text = liv.SubItems[4].Text;
            txt1tiet.Text = liv.SubItems[5].Text;
            txtdiemhk.Text = liv.SubItems[6].Text;
        }
        string mahs = "";
        private void cbmahs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valuePM = cbmahs.SelectedItem.ToString();
            string[] arrPM = valuePM.Split('-');
            mahs = arrPM[0];
        }
        string mamon = "";
        private void cbmamon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valuePM = cbmamon.SelectedItem.ToString();
            string[] arrPM1 = valuePM.Split('-');
            mamon = arrPM1[0];
        }
        #endregion

        #region Database
        public void AddBD_Database()
        {
            dt.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ThemBD";
            cmd.Connection = dt.conn;

            cmd.Parameters.Add("@MAHS", SqlDbType.NVarChar).Value = mahs;
            cmd.Parameters.Add("@MAMON", SqlDbType.NVarChar).Value = mamon;
            cmd.Parameters.Add("@HOCKY", SqlDbType.NVarChar).Value = txthocky.Text;
            cmd.Parameters.Add("@DIEMMIENG", SqlDbType.Float).Value =Convert.ToDouble( txtdiemmieng.Text);
            cmd.Parameters.Add("@DIEM15P", SqlDbType.Float).Value = Convert.ToDouble(txt15p.Text);
            cmd.Parameters.Add("@DIEM1TIET", SqlDbType.Float).Value = Convert.ToDouble(txt1tiet.Text);
            cmd.Parameters.Add("@DIEMHOCKY", SqlDbType.Float).Value = Convert.ToDouble(txtdiemhk.Text);
            int ret = cmd.ExecuteNonQuery();
            lvDB.Items.Clear();
            if (ret > 0)
                ShowData();
        }

        public void repairBD_Database()
        {
            dt.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SuaBD";
            cmd.Connection = dt.conn;
            cmd.Parameters.Add("@MAHS", SqlDbType.NVarChar).Value = cbmahs.Text;
            cmd.Parameters.Add("@MAMON", SqlDbType.NVarChar).Value = cbmamon.Text;
            cmd.Parameters.Add("@HOCKY", SqlDbType.NVarChar).Value = txthocky.Text;
            cmd.Parameters.Add("@DIEMMIENG", SqlDbType.Float).Value = Convert.ToDouble(txtdiemmieng.Text);
            cmd.Parameters.Add("@DIEM15P", SqlDbType.Float).Value = Convert.ToDouble(txt15p.Text);
            cmd.Parameters.Add("@DIEM1TIET", SqlDbType.Float).Value = Convert.ToDouble(txt1tiet.Text);
            cmd.Parameters.Add("@DIEMHOCKY", SqlDbType.Float).Value = Convert.ToDouble(txtdiemhk.Text);
            int ret = cmd.ExecuteNonQuery();
            lvDB.Items.Clear();
            if (ret > 0)
                ShowData();


        }

        public void DeleteBD_Database()
        {
            dt.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
             cmd.CommandText = "XoaBD";
          //  cmd.CommandText = "DELETE FROM dbo.BANGDIEM WHERE MAMON ="+ cbmamon.Text + " AND MAHS="+ cbmahs.Text;
            cmd.Connection = dt.conn;

            cmd.Parameters.Add("@MAHS", SqlDbType.NVarChar).Value = cbmahs.Text;
            cmd.Parameters.Add("@MAMON", SqlDbType.NVarChar).Value = cbmamon.Text;

            int ret = cmd.ExecuteNonQuery();
            lvDB.Items.Clear();
            if (ret > 0)
                ShowData();
        }

        #endregion

        #region Control

        public int ktbd ;
        public int idx()
        {
            return ktbd;
        }
        
        private void btnthemd_Click(object sender, EventArgs e)
        {            
            bool check = true;
            ktbd = 1;
            if (check == true)
                {
                ListViewItem liv = new ListViewItem(mahs);
                liv.SubItems.Add(mamon);
                liv.SubItems.Add(txthocky.Text);
                liv.SubItems.Add(txtdiemmieng.Text);
                liv.SubItems.Add(txt15p.Text);
                liv.SubItems.Add(txt1tiet.Text);
                liv.SubItems.Add(txtdiemhk.Text);
                lvDB.Items.Add(liv);
                
                }
        }
    

        private void btnSuad_Click(object sender, EventArgs e)
        {
            ktbd = 2;
            btnthemd.Enabled = true;
            if (lvDB.SelectedItems.Count == 0) return;
            ListViewItem liv = lvDB.SelectedItems[0];
            liv.SubItems[0].Text = cbmahs.Text;
            liv.SubItems[1].Text = cbmamon.Text;
            liv.SubItems[2].Text = txthocky.Text;
            liv.SubItems[3].Text = txtdiemmieng.Text;
            liv.SubItems[4].Text = txt15p.Text;
            liv.SubItems[5].Text = txt1tiet.Text;
            liv.SubItems[6].Text = txtdiemhk.Text;
            
            
        }

        private void btnXoad_Click(object sender, EventArgs e)
        {
            ktbd = 3;
            if (lvDB.SelectedItems != null)
            {
                for (int i = 0; i < lvDB.Items.Count; i++)
                {
                    if (lvDB.Items[i].Selected)
                    {
                        lvDB.Items[i].Remove();
                        i--;
                    }
                }
            }
            
        }

        private void btnTimKiemd_Click(object sender, EventArgs e)
        {
            if (cbbTKd.SelectedIndex == 0)
            {
                string sr = txtTimKiemd.Text;

                dt.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from BANGDIEM Where MAHS like '%" + sr + "%'";
                cmd.Connection = dt.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvDB.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem liv = new ListViewItem(reader.GetString(0));
                    liv.SubItems.Add(reader.GetString(1));
                    liv.SubItems.Add(reader.GetString(2));
                    liv.SubItems.Add(reader.GetDouble(3).ToString());
                    liv.SubItems.Add(reader.GetDouble(4).ToString());
                    liv.SubItems.Add(reader.GetDouble(5).ToString());
                    liv.SubItems.Add(reader.GetDouble(6).ToString());
                    lvDB.Items.Add(liv);
                }
                reader.Close();
            }
            else if (cbbTKd.SelectedIndex == 1)
            {
                string sr = txtTimKiemd.Text;

                dt.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from BANGDIEM Where MAMON like '%" + sr + "%'";
                cmd.Connection = dt.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvDB.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem liv = new ListViewItem(reader.GetString(0));
                    liv.SubItems.Add(reader.GetString(1));
                    liv.SubItems.Add(reader.GetString(2));
                    liv.SubItems.Add(reader.GetDouble(3).ToString());
                    liv.SubItems.Add(reader.GetDouble(4).ToString());
                    liv.SubItems.Add(reader.GetDouble(5).ToString());
                    liv.SubItems.Add(reader.GetDouble(6).ToString());
                    lvDB.Items.Add(liv);
                }
                reader.Close();
            }
            else if (cbbTKd.SelectedIndex == 2)
            {
                string sr = txtTimKiemd.Text;

                dt.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from BANGDIEM Where HOCKY like '%" + sr + "%'";
                cmd.Connection = dt.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                lvDB.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem liv = new ListViewItem(reader.GetString(0));
                    liv.SubItems.Add(reader.GetString(1));
                    liv.SubItems.Add(reader.GetString(2));
                    liv.SubItems.Add(reader.GetDouble(3).ToString());
                    liv.SubItems.Add(reader.GetDouble(4).ToString());
                    liv.SubItems.Add(reader.GetDouble(5).ToString());
                    liv.SubItems.Add(reader.GetDouble(6).ToString());
                    lvDB.Items.Add(liv);
                }
                reader.Close();
            }
        }

        private void btnResetd_Click(object sender, EventArgs e)
        {
            btnthemd.Enabled = true;
            btnSuad.Enabled = false;
            btnXoad.Enabled = false;
            cbmahs.Enabled = true;
            cbmamon.Enabled = true;
            cbmahs.Refresh();
            cbmahs.ResetText();
            cbmamon.Refresh();
            cbmamon.ResetText();
            txthocky.ResetText();
            txtdiemmieng.ResetText();
            txt15p.ResetText();
            txt1tiet.ResetText();
            txtdiemhk.ResetText();

        }
        #endregion

    }
}
