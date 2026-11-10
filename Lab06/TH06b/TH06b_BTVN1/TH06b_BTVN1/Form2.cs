using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH06b_BTVN1
{
    public partial class frmThemSP : Form
    {
        string connectionString = @"Server=PHUONGDAN;Database=QuanLyBanHang;Integrated Security=True;TrustServerCertificate=True;";
        public frmThemSP()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtThemSP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string sqlThemSP = @"
                INSERT INTO SANPHAM (TenSP)
                OUTPUT INSERTED.MaSP
                VALUES (@TenSP);";

                    int maSP;

                    using (SqlCommand cmd = new SqlCommand(sqlThemSP, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@TenSP", txtThemSP.Text.Trim());
                        maSP = (int)cmd.ExecuteScalar();
                    }

                    string sqlThemTonKho = @"
                INSERT INTO TONKHO (MaSP, NgayTon, SLDau, SLNhap, SLBan)
                VALUES (@MaSP, CAST(GETDATE() AS DATE), 0, 0, 0);";

                    using (SqlCommand cmd = new SqlCommand(sqlThemTonKho, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@MaSP", maSP);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show("Thêm sản phẩm thành công");
                    txtThemSP.Clear();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
