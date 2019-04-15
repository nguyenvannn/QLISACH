using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QLiSach
{
    public partial class QLKH : Form
    {
        public QLKH()
        {
            InitializeComponent();
        }
        SqlConnection con;

        private void QLKH_Load(object sender, EventArgs e)
        {
            string cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString.ToString();
            con = new SqlConnection(cnStr);
            con.Open();
            LoadKH();
        }

        private void QLKH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát form Khách Hàng?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.No)
                e.Cancel = true;
        }

        public void LoadKH()
        {
            string sql = "SELECT * FROM KhachHang";
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvKH.DataSource = dt;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO KhachHang VALUES (@MaKH, @HoTenKH , @DiaChi, @DienThoai, @Email)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaKH", txtMaKH.Text);
            cmd.Parameters.AddWithValue("HoTenKH", txtHoTen.Text);
            cmd.Parameters.AddWithValue("DiaChi",txtDiaChi.Text);
            cmd.Parameters.AddWithValue("DienThoai", txtDT.Text);
            cmd.Parameters.AddWithValue("Email", txtEmail.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã thêm thành công");
            LoadKH();

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sqlXoa, con);
            cmd.Parameters.AddWithValue("MaKH", txtMaKH.Text);
            cmd.Parameters.AddWithValue("HoTenKH", txtHoTen.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("DienThoai", txtDT.Text);
            cmd.Parameters.AddWithValue("Email", txtEmail.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã xóa thành công");
            LoadKH();
        }

        
        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtMaKH.Text = dgvKH.Rows[row].Cells[0].Value.ToString();
            txtHoTen.Text = dgvKH.Rows[row].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKH.Rows[row].Cells[2].Value.ToString();
            txtDT.Text = dgvKH.Rows[row].Cells[3].Value.ToString();
            txtEmail.Text = dgvKH.Rows[row].Cells[4].Value.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE KhachHang SET  HoTenKH = @HoTenKH, DiaChi = @DiaChi , DienThoai = @DienThoai, Email = @Email WHERE MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            cmd.Parameters.AddWithValue("MaKH", txtMaKH.Text);
            cmd.Parameters.AddWithValue("HoTenKH", txtHoTen.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("DienThoai", txtDT.Text);
            cmd.Parameters.AddWithValue("Email", txtEmail.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã sửa thành công");
            LoadKH();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            string sqlTim = "SELECT *FROM KhachHang WHERE MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sqlTim, con);
            cmd.Parameters.AddWithValue("MaKH", txtTimMa.Text);
            cmd.Parameters.AddWithValue("HoTenKH", txtHoTen.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("DienThoai", txtDT.Text);
            cmd.Parameters.AddWithValue("Email", txtEmail.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            MessageBox.Show("Tìm khách hàng thành công");

            dt.Load(dr);
            dgvKH.DataSource = dt;
            
        }

        private void btSPham_Click(object sender, EventArgs e)
        {
            SanPham fm = new SanPham();
            fm.ShowDialog();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát form Quản Lý Khách Hàng");
            this.Close();
        }
    }
}
