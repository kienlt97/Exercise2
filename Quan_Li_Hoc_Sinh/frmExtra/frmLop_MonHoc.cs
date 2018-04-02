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
				cmd.CommandText = "SELECT *FROM dbo.MonHoc";
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
	}
}
