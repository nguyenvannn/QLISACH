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
            con.Close();
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
            LoadKH();

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaKH", txtMaKH.Text);
            cmd.Parameters.AddWithValue("HoTenKH", txtHoTen.Text);
            cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("DienThoai", txtDT.Text);
            cmd.Parameters.AddWithValue("Email", txtEmail.Text);
            cmd.ExecuteNonQuery();
            LoadKH();
        }
    }
}
