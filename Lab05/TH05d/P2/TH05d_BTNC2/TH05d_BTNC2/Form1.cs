using System.Data.SqlClient;

namespace TH05d_BTNC2
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
            if (txtMaSV.Text.Trim() == "" ||
            txtMaMH.Text.Trim() == "" ||
            txtDiem.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            string sql = @"INSERT INTO DIEM (MASV, MAMH, DIEM)
               VALUES (@MASV, @MAMH, @DIEM)";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MASV", txtMaSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@MAMH", txtMaMH.Text.Trim());
                    cmd.Parameters.AddWithValue("@DIEM", txtDiem.Text.Trim());
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm điểm thành công");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "" ||
            txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên và mã môn học không được để trống!");
                return;
            }

            string sql = @"DELETE FROM DIEM
               WHERE MASV = @MASV AND MAMH = @MAMH";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MASV", txtMaSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@MAMH", txtMaMH.Text.Trim());
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa điểm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "" ||
            txtMaMH.Text.Trim() == "" || txtDiem.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên và mã môn học và điểm không được để trống");
                return;
            }

            if (!double.TryParse(txtDiem.Text.Trim(), out double diem))
            {
                MessageBox.Show("Điểm chỉ được nhập số");
                return;
            }

            string sql = @"UPDATE DIEM
               SET DIEM = @DIEM
               WHERE MASV = @MASV AND MAMH = @MAMH";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MASV", txtMaSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@MAMH", txtMaMH.Text.Trim());
                    cmd.Parameters.AddWithValue("@DIEM", diem);
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa điểm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu");
                    }
                }
            }
        }
    }
}
