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
    public partial class frmBanHang : Form
    {
        string connectionString = @"Server=PHUONGDAN;Database=QuanLyBanHang;Integrated Security=True;TrustServerCertificate=True;";
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            txtMaHD.Enabled = false;
            cboMaSP.Enabled = false;
            txtSoLuong.Enabled = false;
            btnThem.Enabled = false;
            btnHuy.Enabled = false;
            btnThanhToan.Enabled = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT MaSP FROM SANPHAM";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboMaSP.DataSource = dt;
                    cboMaSP.DisplayMember = "MaSP";
                    cboMaSP.ValueMember = "MaSP";
                    cboMaSP.SelectedIndex = -1;
                }
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"
            INSERT INTO HOADON (NgayTao, TinhTrangThanhToan)
            OUTPUT INSERTED.MaHD
            VALUES (GETDATE(), 0);";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    int maHD = (int)cmd.ExecuteScalar();
                    txtMaHD.Text = maHD.ToString();
                }
            }

            cboMaSP.Enabled = true;
            txtSoLuong.Enabled = true;
            btnThem.Enabled = true;
            btnHuy.Enabled = true;
            btnThanhToan.Enabled = true;

            MessageBox.Show("Tạo hóa đơn thành công");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || cboMaSP.SelectedIndex == -1 ||
        txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên lớn hơn 0");
                return;
            }

            int maHD = int.Parse(txtMaHD.Text);
            int maSP = Convert.ToInt32(cboMaSP.SelectedValue);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sqlTonKho = @"
            SELECT SLDau + SLNhap - SLBan
            FROM TONKHO
            WHERE MaSP = @MaSP
              AND NgayTon = (
                  SELECT MAX(NgayTon)
                  FROM TONKHO
                  WHERE MaSP = @MaSP
              );";

                using (SqlCommand cmd = new SqlCommand(sqlTonKho, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSP", maSP);

                    object ketQua = cmd.ExecuteScalar();

                    if (ketQua == null || ketQua == DBNull.Value)
                    {
                        MessageBox.Show("Sản phẩm chưa có tồn kho");
                        return;
                    }

                    int tonKho = Convert.ToInt32(ketQua);

                    if (soLuong >= tonKho)
                    {
                        MessageBox.Show("Số lượng bán phải nhỏ hơn số lượng tồn kho");
                        return;
                    }
                }

                string sqlThemCTHD = @"
            INSERT INTO CHITIET_HOADON (MaHD, MaSP, SoLuong)
            VALUES (@MaHD, @MaSP, @SoLuong);";

                using (SqlCommand cmd = new SqlCommand(sqlThemCTHD, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);

                    cmd.ExecuteNonQuery();
                }

                string sqlCapNhatTonKho = @"
            UPDATE TONKHO
            SET SLBan = SLBan + @SoLuong
            WHERE MaSP = @MaSP
              AND NgayTon = (
                  SELECT MAX(NgayTon)
                  FROM TONKHO
                  WHERE MaSP = @MaSP
              );";

                using (SqlCommand cmd = new SqlCommand(sqlCapNhatTonKho, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Thêm sản phẩm vào hóa đơn thành công");

            cboMaSP.SelectedIndex = -1;
            txtSoLuong.Clear();
        }
    }
}
