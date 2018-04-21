﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Hoc_Sinh.frmExtra
{
	public partial class frmForm : UserControl
	{
		public frmForm()
		{
			InitializeComponent();
		}
		frmGiaoVien fgv = new frmGiaoVien();
		#region Save_DataBase
		private void Luu_Click(object sender, EventArgs e)
		{
			int x = fgv.index();
			int y = frmhs.kt();
			int z = frmLop.index();
			// giáo viên
			switch (x)
			{
				case 1:
					fgv.AddGV_Database();
					MessageBox.Show("Đã thêm thành công!");
					break;
				case 2:
					fgv.repairGV_Database();
					MessageBox.Show("Đã sửa thành công!");
					break;
				case 3:
					fgv.DeleteGV_Database();
					MessageBox.Show("Đã xóa!");
					break;
				
			}
			// lớp học và môn học
			switch (z)
			{
				case 1:
					frmLop.AddLH_Database();
					MessageBox.Show("Đã thêm thành công!");
					break;
				case 2:
					frmLop.repairLH_Database();
					MessageBox.Show("Đã sửa thành công!");
					break;
				case 4:
					frmLop.AddMH_Database();
					MessageBox.Show("Đã thêm thành công!");
					break;
				case 5:
					frmLop.repairMH_Database();
					MessageBox.Show("Đã sửa thành công!");
					break;
				case 6:
					frmLop.DeleteMH_Database();
					MessageBox.Show("Đã xóa!");
					break;
			}

			switch (y)
			{
				case 1:
					frmhs.AddHsToDatabase();
					MessageBox.Show("Đã thêm thành công!");
					break;
                case 2:
                    frmhs.FixHsToDatabase();
                    MessageBox.Show("Đã sửa thành công!");
                    break;
                case 3:
                    frmhs.DeleteHS_Database();
                    MessageBox.Show("Đã xóa!");
                    break;
            }
		}	
		#endregion
		#region GiaoVien
		
		private void open_Click(object sender, EventArgs e)
		{
			pnMainGV.Controls.Clear();
			fgv.Dock = DockStyle.Fill;
			pnMainGV.Controls.Add(fgv);
		}
		#endregion
		#region LopHoc
		frmLop_MonHoc frmLop = new frmLop_MonHoc();
			private void openToolStripMenuItem1_Click(object sender, EventArgs e)
			{
				pnMainGV.Controls.Clear();
				frmLop.Dock = DockStyle.Fill;
				pnMainGV.Controls.Add(frmLop);
			}
		#endregion
		#region HoSoHS
			frmHoSoHS frmhs = new frmHoSoHS();
			private void newToolStripMenuItem_Click(object sender, EventArgs e)
			{
				pnMainGV.Controls.Clear();
				frmhs.Dock = DockStyle.Fill;
				pnMainGV.Controls.Add(frmhs);
			}
		#endregion
		#region BangDiem
			frmBangDiem frmbd = new frmBangDiem();
			private void openToolStripMenuItem_Click(object sender, EventArgs e)
			{
				pnMainGV.Controls.Clear();
				frmbd.Dock = DockStyle.Fill;
				pnMainGV.Controls.Add(frmbd);
			}


		#endregion

		private void trangChuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pnMainGV.Controls.Clear();
		}
	}
}
