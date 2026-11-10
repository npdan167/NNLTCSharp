using System.Data.SqlClient;

namespace TH06a_BTVN1
{
    public partial class Form1 : Form
    {
        string connStr = @"Data Source=PHUONGDAN;Initial Catalog=QLSINHVIEN;Integrated Security=True;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "" ||
                txtMaLop.Text.Trim() == "" ||
                txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            string sql = @"INSERT INTO LOP (MAKHOA, MALOP, TENLOP)
                   VALUES (@MAKHOA, @MALOP, @TENLOP)";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKHOA", txtMaKhoa.Text.Trim());
                    cmd.Parameters.AddWithValue("@MALOP", txtMaLop.Text.Trim());
                    cmd.Parameters.AddWithValue("@TENLOP", txtTenLop.Text.Trim());
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                        MessageBox.Show("Thêm lớp thành công");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống");
                return;
            }

            string sql = @"DELETE FROM LOP WHERE MALOP = @MALOP";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MALOP", txtMaLop.Text.Trim());
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                        MessageBox.Show("Xóa lớp thành công");
                    else
                        MessageBox.Show("Không tìm thấy lớp");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống");
                return;
            }
            // Ktra mã khoa, tên lớp phải có ít nhất 1
            if (txtMaKhoa.Text.Trim() == "" &&
                txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa hoặc tên lớp phải có");
                return;
            }

            string sql = @"UPDATE LOP SET
                   MAKHOA = CASE WHEN @MAKHOA = '' THEN MAKHOA ELSE @MAKHOA END,
                   TENLOP = CASE WHEN @TENLOP = '' THEN TENLOP ELSE @TENLOP END
                   WHERE MALOP = @MALOP";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MALOP", txtMaLop.Text.Trim());
                    cmd.Parameters.AddWithValue("@MAKHOA", txtMaKhoa.Text.Trim());
                    cmd.Parameters.AddWithValue("@TENLOP", txtTenLop.Text.Trim());
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                        MessageBox.Show("Sửa lớp thành công");
                    else
                        MessageBox.Show("Không tìm thấy lớp");
                }
            }
        }
    }
}
