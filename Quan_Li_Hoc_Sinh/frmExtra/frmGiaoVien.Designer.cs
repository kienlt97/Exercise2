namespace Quan_Li_Hoc_Sinh
{
	partial class frmGiaoVien
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvGV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbbTKGV = new System.Windows.Forms.ComboBox();
            this.cblopgiangday = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbMalop = new System.Windows.Forms.ComboBox();
            this.txtTimKiemGV = new System.Windows.Forms.TextBox();
            this.btnTimKiemGV = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtthongtin = new System.Windows.Forms.TextBox();
            this.txttenGV = new System.Windows.Forms.TextBox();
            this.txtmagv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.UseWaitCursor = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cbbTKGV);
            this.splitContainer1.Panel2.Controls.Add(this.cblopgiangday);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.btnReset);
            this.splitContainer1.Panel2.Controls.Add(this.cbMalop);
            this.splitContainer1.Panel2.Controls.Add(this.txtTimKiemGV);
            this.splitContainer1.Panel2.Controls.Add(this.btnTimKiemGV);
            this.splitContainer1.Panel2.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel2.Controls.Add(this.btnSua);
            this.splitContainer1.Panel2.Controls.Add(this.btnthem);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtthongtin);
            this.splitContainer1.Panel2.Controls.Add(this.txttenGV);
            this.splitContainer1.Panel2.Controls.Add(this.txtmagv);
            this.splitContainer1.Size = new System.Drawing.Size(652, 547);
            this.splitContainer1.SplitterDistance = 368;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvGV);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Giáo Viên";
            this.groupBox1.UseWaitCursor = true;
            // 
            // lvGV
            // 
            this.lvGV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvGV.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lvGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGV.FullRowSelect = true;
            this.lvGV.GridLines = true;
            this.lvGV.HideSelection = false;
            this.lvGV.Location = new System.Drawing.Point(3, 16);
            this.lvGV.Name = "lvGV";
            this.lvGV.Size = new System.Drawing.Size(646, 349);
            this.lvGV.TabIndex = 2;
            this.lvGV.UseCompatibleStateImageBehavior = false;
            this.lvGV.UseWaitCursor = true;
            this.lvGV.View = System.Windows.Forms.View.Details;
            this.lvGV.SelectedIndexChanged += new System.EventHandler(this.lvGV_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Giáo Viên";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Giáo Viên";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thông Tin Cá Nhân";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lớp Chủ Nhiệm";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giảng Dạy";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // cbbTKGV
            // 
            this.cbbTKGV.FormattingEnabled = true;
            this.cbbTKGV.Items.AddRange(new object[] {
            "Theo Mã Giáo Viên",
            "Theo Tên Giáo Viên ",
            "Theo Thông Tin Cá Nhân ",
            "Theo Lớp Chủ Nhiệm ",
            "Theo Giảng Dạy"});
            this.cbbTKGV.Location = new System.Drawing.Point(25, 141);
            this.cbbTKGV.Name = "cbbTKGV";
            this.cbbTKGV.Size = new System.Drawing.Size(149, 21);
            this.cbbTKGV.TabIndex = 41;
            // 
            // cblopgiangday
            // 
            this.cblopgiangday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cblopgiangday.FormattingEnabled = true;
            this.cblopgiangday.Location = new System.Drawing.Point(393, 24);
            this.cblopgiangday.Name = "cblopgiangday";
            this.cblopgiangday.Size = new System.Drawing.Size(163, 21);
            this.cblopgiangday.TabIndex = 40;
            this.cblopgiangday.SelectedIndexChanged += new System.EventHandler(this.cblopgiangday_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Lớp Giảng Dạy : ";
            this.label5.UseWaitCursor = true;
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(481, 119);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 38;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbMalop
            // 
            this.cbMalop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbMalop.FormattingEnabled = true;
            this.cbMalop.Location = new System.Drawing.Point(217, 72);
            this.cbMalop.Name = "cbMalop";
            this.cbMalop.Size = new System.Drawing.Size(149, 21);
            this.cbMalop.TabIndex = 37;
            this.cbMalop.SelectedIndexChanged += new System.EventHandler(this.cbMalop_SelectedIndexChanged);
            // 
            // txtTimKiemGV
            // 
            this.txtTimKiemGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemGV.Location = new System.Drawing.Point(25, 103);
            this.txtTimKiemGV.Name = "txtTimKiemGV";
            this.txtTimKiemGV.Size = new System.Drawing.Size(149, 20);
            this.txtTimKiemGV.TabIndex = 36;
            this.txtTimKiemGV.UseWaitCursor = true;
            this.txtTimKiemGV.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTimKiemGV
            // 
            this.btnTimKiemGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemGV.Location = new System.Drawing.Point(217, 119);
            this.btnTimKiemGV.Name = "btnTimKiemGV";
            this.btnTimKiemGV.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemGV.TabIndex = 35;
            this.btnTimKiemGV.Text = "Tìm Kiếm";
            this.btnTimKiemGV.UseVisualStyleBackColor = true;
            this.btnTimKiemGV.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Location = new System.Drawing.Point(393, 119);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Location = new System.Drawing.Point(481, 72);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.Location = new System.Drawing.Point(393, 72);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 32;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Lớp Chủ Nhiệm : ";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Thông Tin - Cá Nhân : ";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên Giáo Viên : ";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã Giáo Viên : ";
            this.label1.UseWaitCursor = true;
            // 
            // txtthongtin
            // 
            this.txtthongtin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtthongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthongtin.Location = new System.Drawing.Point(217, 24);
            this.txtthongtin.Name = "txtthongtin";
            this.txtthongtin.Size = new System.Drawing.Size(149, 20);
            this.txtthongtin.TabIndex = 26;
            // 
            // txttenGV
            // 
            this.txttenGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenGV.Location = new System.Drawing.Point(25, 72);
            this.txttenGV.Name = "txttenGV";
            this.txttenGV.Size = new System.Drawing.Size(149, 20);
            this.txttenGV.TabIndex = 25;
            // 
            // txtmagv
            // 
            this.txtmagv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmagv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmagv.Location = new System.Drawing.Point(25, 24);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.Size = new System.Drawing.Size(149, 20);
            this.txtmagv.TabIndex = 24;
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmGiaoVien";
            this.Size = new System.Drawing.Size(652, 547);
            this.Load += new System.EventHandler(this.fixGiaoVien_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtthongtin;
		private System.Windows.Forms.TextBox txttenGV;
		private System.Windows.Forms.TextBox txtmagv;
		private System.Windows.Forms.Button btnTimKiemGV;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnthem;
		private System.Windows.Forms.TextBox txtTimKiemGV;
		private System.Windows.Forms.ComboBox cbMalop;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.ComboBox cblopgiangday;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView lvGV;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox cbbTKGV;
    }
}
