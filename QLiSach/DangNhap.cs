using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLiSach
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void cbHienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienthi.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTendangnhap.Text == "admin" && txtMatKhau.Text == "12345")
            {
                MessageBox.Show("Đăng nhập thành công!");
            }
            else
            {
                if(txtTendangnhap.Text == "admin"&& txtMatKhau.Text =="")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc sai mật khẩu");
                    this.Dispose();
                }
            }
            QLKH formKH = new QLKH();
            formKH.ShowDialog();
        }
    }
}
