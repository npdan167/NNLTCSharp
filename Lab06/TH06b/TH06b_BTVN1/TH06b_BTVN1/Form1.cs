using System.Data;
using Microsoft.Data.SqlClient;

namespace TH06b_BTVN1
{
    public partial class frmChinh : Form
    {
        string connectionString = @"Server=PHUONGDAN;Database=QuanLyBanHang;Integrated Security=True;TrustServerCertificate=True;";
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tsmiTaoTonKho_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"
            INSERT INTO TONKHO (MaSP, NgayTon, SLDau, SLNhap, SLBan)
            SELECT 
                sp.MaSP,
                CAST(GETDATE() AS DATE),
                ISNULL(tk.SLDau + tk.SLNhap - tk.SLBan, 0),
                0,
                0
            FROM SANPHAM sp
            OUTER APPLY
            (
                SELECT TOP 1 SLDau, SLNhap, SLBan
                FROM TONKHO
                WHERE MaSP = sp.MaSP
                ORDER BY NgayTon DESC
            ) tk
            WHERE NOT EXISTS
            (
                SELECT 1
                FROM TONKHO
                WHERE MaSP = sp.MaSP
                  AND NgayTon = CAST(GETDATE() AS DATE)
            );";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Tạo tồn kho thành công");
        }

        private void tsmiThemSP_Click(object sender, EventArgs e)
        {
            frmThemSP f = new frmThemSP();
            f.ShowDialog();
        }

        private void tsmiBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang f = new frmBanHang();
            f.ShowDialog();
        }
    }
}
