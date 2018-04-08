using System;
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
    public partial class frmHelp : UserControl
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Để thêm Học sinh/ Giáo viên/ Lớp/ Điểm/ Môn học, điền đầy đủ thông tin sau đó ấn nút Thêm.", "Thêm");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Để sửa Học sinh/ Giáo viên/ Lớp/ Điểm/ Môn học, điền thông tin cần sửa sau đó ấn nút Sửa.","Sửa");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Để xoá Học sinh/ Giáo viên/ Lớp/ Điểm/ Môn học, chọn đối tượng cần xoá sau đó ấn nút Xoá.","Xoá");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhập thông tin đối tượng cần tìm kiếm sau đó ấn nút Tìm Kiếm.","Tìm Kiếm");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sau khi thực hiện từng thao tác, ấn nút Save để lưu lại.","Save");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Để xoá các thông tin đã nhập, ấn nút Reset.","Reset");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thay đổi mật khẩu cho tài khoản của bạn.","Đổi mật khẩu");
        }
    }
}
