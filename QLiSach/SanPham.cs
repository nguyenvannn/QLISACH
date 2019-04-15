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

        //private void SanPham_Load(object sender, EventArgs e)
        //{
        //    string cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString.ToString();
        //    con = new SqlConnection(cnStr);
        //    con.Open();
        //    LoadKH();
        //}


        //private void QLKH_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    con.Close();
        //}

        //public void LoadKH()
        //{
        //    string sql = "SELECT * FROM KhachHang";
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Load(dr);
        //    dgvKH.DataSource = dt;
        //}

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
    }
}
