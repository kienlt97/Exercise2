namespace Quan_Li_Hoc_Sinh.frmExtra
{
	partial class frmLop_MonHoc
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvLopHoc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbTKLop = new System.Windows.Forms.ComboBox();
            this.txtTimKiemLop = new System.Windows.Forms.TextBox();
            this.btnTimKiemLop = new System.Windows.Forms.Button();
            this.btnresetlh = new System.Windows.Forms.Button();
            this.btnsualh = new System.Windows.Forms.Button();
            this.btnthemlh = new System.Windows.Forms.Button();
            this.txttenlp = new System.Windows.Forms.TextBox();
            this.txtmalp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvMonHoc = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTimKiemMon = new System.Windows.Forms.TextBox();
            this.cbbTKMon = new System.Windows.Forms.ComboBox();
            this.btnTimKiemMon = new System.Windows.Forms.Button();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnresetmh = new System.Windows.Forms.Button();
            this.btnxoamh = new System.Windows.Forms.Button();
            this.btnsuamh = new System.Windows.Forms.Button();
            this.btnthemmh = new System.Windows.Forms.Button();
            this.txttenmh = new System.Windows.Forms.TextBox();
            this.txtmamh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoaLop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(652, 547);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(281, 547);
            this.splitContainer2.SplitterDistance = 348;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lvLopHoc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Lớp Học : ";
            // 
            // lvLopHoc
            // 
            this.lvLopHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLopHoc.FullRowSelect = true;
            this.lvLopHoc.GridLines = true;
            this.lvLopHoc.HideSelection = false;
            this.lvLopHoc.Location = new System.Drawing.Point(3, 16);
            this.lvLopHoc.Name = "lvLopHoc";
            this.lvLopHoc.Size = new System.Drawing.Size(275, 329);
            this.lvLopHoc.TabIndex = 0;
            this.lvLopHoc.UseCompatibleStateImageBehavior = false;
            this.lvLopHoc.View = System.Windows.Forms.View.Details;
            this.lvLopHoc.SelectedIndexChanged += new System.EventHandler(this.lvLopHoc_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Lớp Học";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Lớp Học";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 140;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Controls.Add(this.btnXoaLop);
            this.groupBox3.Controls.Add(this.cbbTKLop);
            this.groupBox3.Controls.Add(this.txtTimKiemLop);
            this.groupBox3.Controls.Add(this.btnTimKiemLop);
            this.groupBox3.Controls.Add(this.btnresetlh);
            this.groupBox3.Controls.Add(this.btnsualh);
            this.groupBox3.Controls.Add(this.btnthemlh);
            this.groupBox3.Controls.Add(this.txttenlp);
            this.groupBox3.Controls.Add(this.txtmalp);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 195);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " ";
            // 
            // cbbTKLop
            // 
            this.cbbTKLop.FormattingEnabled = true;
            this.cbbTKLop.Items.AddRange(new object[] {
            "Theo Mã Lớp Học",
            "Theo Tên Lớp Học "});
            this.cbbTKLop.Location = new System.Drawing.Point(125, 126);
            this.cbbTKLop.Name = "cbbTKLop";
            this.cbbTKLop.Size = new System.Drawing.Size(140, 21);
            this.cbbTKLop.TabIndex = 9;
            // 
            // txtTimKiemLop
            // 
            this.txtTimKiemLop.Location = new System.Drawing.Point(125, 79);
            this.txtTimKiemLop.Name = "txtTimKiemLop";
            this.txtTimKiemLop.Size = new System.Drawing.Size(140, 20);
            this.txtTimKiemLop.TabIndex = 8;
            // 
            // btnTimKiemLop
            // 
            this.btnTimKiemLop.Location = new System.Drawing.Point(190, 166);
            this.btnTimKiemLop.Name = "btnTimKiemLop";
            this.btnTimKiemLop.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemLop.TabIndex = 7;
            this.btnTimKiemLop.Text = "Tìm Kiếm";
            this.btnTimKiemLop.UseVisualStyleBackColor = true;
            this.btnTimKiemLop.Click += new System.EventHandler(this.btnTimKiemLop_Click);
            // 
            // btnresetlh
            // 
            this.btnresetlh.Location = new System.Drawing.Point(19, 139);
            this.btnresetlh.Name = "btnresetlh";
            this.btnresetlh.Size = new System.Drawing.Size(69, 23);
            this.btnresetlh.TabIndex = 6;
            this.btnresetlh.Text = "Reset";
            this.btnresetlh.UseVisualStyleBackColor = true;
            this.btnresetlh.Click += new System.EventHandler(this.btnresetlh_Click);
            // 
            // btnsualh
            // 
            this.btnsualh.Location = new System.Drawing.Point(16, 108);
            this.btnsualh.Name = "btnsualh";
            this.btnsualh.Size = new System.Drawing.Size(72, 23);
            this.btnsualh.TabIndex = 4;
            this.btnsualh.Text = "Sửa";
            this.btnsualh.UseVisualStyleBackColor = true;
            this.btnsualh.Click += new System.EventHandler(this.btnsualh_Click);
            // 
            // btnthemlh
            // 
            this.btnthemlh.Location = new System.Drawing.Point(16, 77);
            this.btnthemlh.Name = "btnthemlh";
            this.btnthemlh.Size = new System.Drawing.Size(72, 23);
            this.btnthemlh.TabIndex = 3;
            this.btnthemlh.Text = "Thêm";
            this.btnthemlh.UseVisualStyleBackColor = true;
            this.btnthemlh.Click += new System.EventHandler(this.btnthemlh_Click);
            // 
            // txttenlp
            // 
            this.txttenlp.Location = new System.Drawing.Point(92, 49);
            this.txttenlp.Name = "txttenlp";
            this.txttenlp.Size = new System.Drawing.Size(173, 20);
            this.txttenlp.TabIndex = 2;
            // 
            // txtmalp
            // 
            this.txtmalp.Location = new System.Drawing.Point(92, 13);
            this.txtmalp.Name = "txtmalp";
            this.txtmalp.Size = new System.Drawing.Size(173, 20);
            this.txtmalp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Lớp Học : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Lớp Học : ";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer3.Size = new System.Drawing.Size(367, 547);
            this.splitContainer3.SplitterDistance = 346;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.lvMonHoc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 346);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Môn Học : ";
            // 
            // lvMonHoc
            // 
            this.lvMonHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMonHoc.FullRowSelect = true;
            this.lvMonHoc.GridLines = true;
            this.lvMonHoc.HideSelection = false;
            this.lvMonHoc.Location = new System.Drawing.Point(3, 16);
            this.lvMonHoc.Name = "lvMonHoc";
            this.lvMonHoc.Size = new System.Drawing.Size(361, 327);
            this.lvMonHoc.TabIndex = 1;
            this.lvMonHoc.UseCompatibleStateImageBehavior = false;
            this.lvMonHoc.View = System.Windows.Forms.View.Details;
            this.lvMonHoc.SelectedIndexChanged += new System.EventHandler(this.lvMonHoc_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã Môn Học";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên Môn Học";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ghi Chú";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 120;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox4.Controls.Add(this.txtTimKiemMon);
            this.groupBox4.Controls.Add(this.cbbTKMon);
            this.groupBox4.Controls.Add(this.btnTimKiemMon);
            this.groupBox4.Controls.Add(this.txtghichu);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnresetmh);
            this.groupBox4.Controls.Add(this.btnxoamh);
            this.groupBox4.Controls.Add(this.btnsuamh);
            this.groupBox4.Controls.Add(this.btnthemmh);
            this.groupBox4.Controls.Add(this.txttenmh);
            this.groupBox4.Controls.Add(this.txtmamh);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(367, 197);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " ";
            // 
            // txtTimKiemMon
            // 
            this.txtTimKiemMon.Location = new System.Drawing.Point(186, 110);
            this.txtTimKiemMon.Name = "txtTimKiemMon";
            this.txtTimKiemMon.Size = new System.Drawing.Size(121, 20);
            this.txtTimKiemMon.TabIndex = 19;
            // 
            // cbbTKMon
            // 
            this.cbbTKMon.FormattingEnabled = true;
            this.cbbTKMon.Items.AddRange(new object[] {
            "Theo Mã Môn Học ",
            "Theo Tên Môn Học"});
            this.cbbTKMon.Location = new System.Drawing.Point(186, 141);
            this.cbbTKMon.Name = "cbbTKMon";
            this.cbbTKMon.Size = new System.Drawing.Size(121, 21);
            this.cbbTKMon.TabIndex = 18;
            // 
            // btnTimKiemMon
            // 
            this.btnTimKiemMon.Location = new System.Drawing.Point(233, 168);
            this.btnTimKiemMon.Name = "btnTimKiemMon";
            this.btnTimKiemMon.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemMon.TabIndex = 17;
            this.btnTimKiemMon.Text = "Tìm Kiếm";
            this.btnTimKiemMon.UseVisualStyleBackColor = true;
            this.btnTimKiemMon.Click += new System.EventHandler(this.btnTimKiemMon_Click);
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(99, 76);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(210, 20);
            this.txtghichu.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ghi Chú : ";
            // 
            // btnresetmh
            // 
            this.btnresetmh.Location = new System.Drawing.Point(99, 152);
            this.btnresetmh.Name = "btnresetmh";
            this.btnresetmh.Size = new System.Drawing.Size(57, 23);
            this.btnresetmh.TabIndex = 14;
            this.btnresetmh.Text = "Reset";
            this.btnresetmh.UseVisualStyleBackColor = true;
            this.btnresetmh.Click += new System.EventHandler(this.btnresetmh_Click);
            // 
            // btnxoamh
            // 
            this.btnxoamh.Location = new System.Drawing.Point(26, 152);
            this.btnxoamh.Name = "btnxoamh";
            this.btnxoamh.Size = new System.Drawing.Size(64, 23);
            this.btnxoamh.TabIndex = 13;
            this.btnxoamh.Text = "Xóa";
            this.btnxoamh.UseVisualStyleBackColor = true;
            this.btnxoamh.Click += new System.EventHandler(this.btnxoamh_Click);
            // 
            // btnsuamh
            // 
            this.btnsuamh.Location = new System.Drawing.Point(99, 110);
            this.btnsuamh.Name = "btnsuamh";
            this.btnsuamh.Size = new System.Drawing.Size(57, 23);
            this.btnsuamh.TabIndex = 12;
            this.btnsuamh.Text = "Sửa";
            this.btnsuamh.UseVisualStyleBackColor = true;
            this.btnsuamh.Click += new System.EventHandler(this.btnsuamh_Click);
            // 
            // btnthemmh
            // 
            this.btnthemmh.Location = new System.Drawing.Point(26, 110);
            this.btnthemmh.Name = "btnthemmh";
            this.btnthemmh.Size = new System.Drawing.Size(64, 23);
            this.btnthemmh.TabIndex = 11;
            this.btnthemmh.Text = "Thêm";
            this.btnthemmh.UseVisualStyleBackColor = true;
            this.btnthemmh.Click += new System.EventHandler(this.btnthemmh_Click);
            // 
            // txttenmh
            // 
            this.txttenmh.Location = new System.Drawing.Point(99, 48);
            this.txttenmh.Name = "txttenmh";
            this.txttenmh.Size = new System.Drawing.Size(210, 20);
            this.txttenmh.TabIndex = 9;
            // 
            // txtmamh
            // 
            this.txtmamh.Location = new System.Drawing.Point(99, 12);
            this.txtmamh.Name = "txtmamh";
            this.txtmamh.Size = new System.Drawing.Size(210, 20);
            this.txtmamh.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên Môn Học : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã Môn Học : ";
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Location = new System.Drawing.Point(19, 165);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(69, 23);
            this.btnXoaLop.TabIndex = 10;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // frmLop_MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmLop_MonHoc";
            this.Size = new System.Drawing.Size(652, 547);
            this.Load += new System.EventHandler(this.frmLop_MonHoc_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView lvLopHoc;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView lvMonHoc;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox txtmalp;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txttenlp;
		private System.Windows.Forms.Button btnresetlh;
		private System.Windows.Forms.Button btnsualh;
		private System.Windows.Forms.Button btnthemlh;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Button btnresetmh;
		private System.Windows.Forms.Button btnxoamh;
		private System.Windows.Forms.Button btnsuamh;
		private System.Windows.Forms.Button btnthemmh;
		private System.Windows.Forms.TextBox txttenmh;
		private System.Windows.Forms.TextBox txtmamh;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtghichu;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbTKLop;
        private System.Windows.Forms.TextBox txtTimKiemLop;
        private System.Windows.Forms.Button btnTimKiemLop;
        private System.Windows.Forms.TextBox txtTimKiemMon;
        private System.Windows.Forms.ComboBox cbbTKMon;
        private System.Windows.Forms.Button btnTimKiemMon;
        private System.Windows.Forms.Button btnXoaLop;
    }
}
