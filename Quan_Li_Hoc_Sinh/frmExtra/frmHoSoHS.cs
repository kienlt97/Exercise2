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
		public void ShowData()
		{
			dt.OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from HOSOHOCSINH";
			cmd.Connection = dt.conn;

			SqlDataReader reader = cmd.ExecuteReader();
			lvHS.Items.Clear();
			while (reader.Read())
			{
 				ListViewItem liv = new ListViewItem(reader.GetString(0));
				liv.SubItems.Add(reader.GetString(1));
				liv.SubItems.Add(reader.GetString(2));
				liv.SubItems.Add(reader.GetString(3));
				liv.SubItems.Add(reader.GetString(4));
				liv.SubItems.Add(reader.GetString(8));
				lvHS.Items.Add(liv);
			}
			reader.Close();
		}
		#endregion

	}
}
