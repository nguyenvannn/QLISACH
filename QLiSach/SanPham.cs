using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QLiSach
{
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }
        SqlConnection con;
        
        private void SanPham_Load(object sender, EventArgs e)
        {
            string cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString.ToString();
            con = new SqlConnection(cnStr);
            con.Open();
            LoadSP();
        }
        public void LoadSP()
        {
            string sql = "SELECT * FROM SanPham";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvSanPham.DataSource = dt;
        }

        private void SanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtMaSP.Text = dgvSanPham.Rows[row].Cells[0].Value.ToString();
            txtTenSP.Text = dgvSanPham.Rows[row].Cells[1].Value.ToString();
            txtDongia.Text = dgvSanPham.Rows[row].Cells[2].Value.ToString();
            
        }

        private void btThemSP_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO SanPham VALUES (@MaSP, @TenSP , @Dongia)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaSP", txtMaSP.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("Dongia", txtDongia.Text);
            
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã thêm thành công");
            LoadSP();
        }

        private void btXoaSP_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE FROM SanPham WHERE MaSP = @MaSP";
            SqlCommand cmd = new SqlCommand(sqlXoa, con);

            cmd.Parameters.AddWithValue("MaSP", txtMaSP.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTenSP.Text);
            cmd.Parameters.AddWithValue("Dongia", txtDongia.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã xóa thành công");
            LoadSP();
        }
    }
}
