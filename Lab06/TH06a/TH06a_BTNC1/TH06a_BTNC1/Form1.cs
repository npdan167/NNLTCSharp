using System.Data.SqlClient;

namespace TH06a_BTNC1
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
            // Ktra nhap du tt
            if (txtMaLop.Text.Trim() == "" ||
            txtMaSV.Text.Trim() == "" ||
            txtHoTen.Text.Trim() == "" ||
            !mxtxNgaySinh.MaskCompleted)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            // insert database
            string sql = @"INSERT INTO SINHVIEN (MASV, MALOP, HOTEN, NGAYSINH)
            VALUES (@MASV, @MALOP, @HOTEN, @NGAYSINH)";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MASV", txtMaSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@MALOP", txtMaLop.Text.Trim());
                    cmd.Parameters.AddWithValue("@HOTEN", txtHoTen.Text.Trim());
                    cmd.Parameters.AddWithValue("@NGAYSINH", DateTime.ParseExact(
                        mxtxNgaySinh.Text, "dd/MM/yyyy",
                        System.Globalization.CultureInfo.InvariantCulture));
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm sinh viên thành công");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "" ||
            txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên và họ tên");
                return;
            }

            // Xac nhan xoa sv
            DialogResult xacNhan = MessageBox.Show(
                "Xác nhận xóa?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (xacNhan != DialogResult.Yes)
            {
                return;
            }
            //Xoa sv trên dtb
            string sql = @"DELETE FROM SINHVIEN
               WHERE MASV = @MASV AND HOTEN = @HOTEN";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MASV", txtMaSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@HOTEN", txtHoTen.Text.Trim());
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa sinh viên thành công");
                        txtMaSV.Clear();
                        txtHoTen.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Ktra nhap msv
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên");
                return;
            }
            //Ktra it nhat 1 thong tin sua
            if (txtMaLop.Text.Trim() == "" &&
                txtHoTen.Text.Trim() == "" &&
                !mxtxNgaySinh.MaskCompleted)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần sửa");
                return;
            }

            //update dtb
            string sql = @"UPDATE SINHVIEN SET
               MALOP = CASE WHEN @MALOP <> '' THEN @MALOP ELSE MALOP END,
               HOTEN = CASE WHEN @HOTEN <> '' THEN @HOTEN ELSE HOTEN END,
               NGAYSINH = CASE WHEN @CO_NGAYSINH = 1 THEN @NGAYSINH ELSE NGAYSINH END
               WHERE MASV = @MASV";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MASV", txtMaSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@MALOP", txtMaLop.Text.Trim());
                    cmd.Parameters.AddWithValue("@HOTEN", txtHoTen.Text.Trim());

                    bool coNgaySinh = mxtxNgaySinh.MaskCompleted;
                    cmd.Parameters.AddWithValue("@CO_NGAYSINH", coNgaySinh ? 1 : 0);
                    cmd.Parameters.AddWithValue(
                        "@NGAYSINH",
                        coNgaySinh ? mxtxNgaySinh.Text : DateTime.Today.ToString("dd/MM/yyyy"));

                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa thông tin sinh viên thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên");
                    }
                }
            }
        }
    }
}
