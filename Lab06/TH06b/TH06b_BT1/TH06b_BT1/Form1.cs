using System.Data;
using Microsoft.Data.SqlClient;

namespace TH06b_BT1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=PHUONGDAN;Database=QLSINHVIEN;Integrated Security=True;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
        }

        // Load ma lop len cboLop khi form load
        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT MALOP FROM LOP";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();

                da.Fill(dt);

                cboLop.DataSource = dt;
                cboLop.DisplayMember = "MALOP";
                cboLop.ValueMember = "MALOP";
                cboLop.SelectedIndex = -1;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection connsql = new SqlConnection(connectionString);
            try
            {
                connsql.Open();

                // Ktra trung ma sinh vien
                string sqlKT = "SELECT COUNT(*) FROM SINHVIEN WHERE MASV = '"
                               + txtMasv.Text + "'";
                SqlCommand cmdKT = new SqlCommand(sqlKT, connsql);

                if ((int)cmdKT.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Trùng mã sinh viên");
                    return;
                }

                // Ktra nhap tat ca thong tin
                if (txtMasv.Text == "" || txtHoTen.Text == "" ||
                    mtxtNgaySinh.Text.Contains("_") || cboLop.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }

                // Ktra tuoi theo nam sinh
                DateTime ngaySinh = DateTime.ParseExact(
                    mtxtNgaySinh.Text,
                    "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture);
                int namSinh = ngaySinh.Year;
                if (DateTime.Now.Year - namSinh < 17)
                {
                    MessageBox.Show("Sinh viên phải từ 17 tuổi trở lên");
                    return;
                }

                // Lay ma khoa cua lop de them sv
                string sqlKhoa = "SELECT MAKHOA FROM LOP WHERE MALOP = '"
                                 + cboLop.SelectedValue.ToString() + "'";
                SqlCommand cmdKhoa = new SqlCommand(sqlKhoa, connsql);
                object maKhoa = cmdKhoa.ExecuteScalar();

                // Them sinh vien
                string sqlThem = "INSERT INTO SINHVIEN (MASV, HOTEN, NGAYSINH, MALOP, MAKHOA) VALUES ('"
                                 + txtMasv.Text + "', N'"
                                 + txtHoTen.Text + "', '"
                                 + ngaySinh.ToString("yyyy-MM-dd") + "', '"
                                 + cboLop.SelectedValue.ToString() + "', '"
                                 + maKhoa.ToString() + "')";

                SqlCommand cmd = new SqlCommand(sqlThem, connsql);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm sinh viên thành công");
            }

            finally
            {
                if (connsql.State == System.Data.ConnectionState.Open)
                    connsql.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Ktra ton tai ma sinh vien
                SqlCommand cmdKT = new SqlCommand(
                    "SELECT COUNT(*) FROM SINHVIEN WHERE MASV = @MASV", conn);
                cmdKT.Parameters.AddWithValue("@MASV", txtMasv.Text);

                if ((int)cmdKT.ExecuteScalar() == 0)
                {
                    MessageBox.Show("Mã sinh viên không tồn tại");
                    return;
                }

                // Ktra khoa ngoai bang DIEM
                SqlCommand cmdDiem = new SqlCommand(
                    "SELECT COUNT(*) FROM DIEM WHERE MASV = @MASV", conn);
                cmdDiem.Parameters.AddWithValue("@MASV", txtMasv.Text);

                if ((int)cmdDiem.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Không thể xóa sinh viên vì khóa ngoại ĐIỂM");
                    return;
                }

                // Xoa sinh vien
                SqlCommand cmdXoa = new SqlCommand(
                    "DELETE FROM SINHVIEN WHERE MASV = @MASV", conn);
                cmdXoa.Parameters.AddWithValue("@MASV", txtMasv.Text);
                cmdXoa.ExecuteNonQuery();

                MessageBox.Show("Xóa sinh viên thành công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Ktra ton tai ma sinh vien
                SqlCommand cmdKT = new SqlCommand(
                    "SELECT COUNT(*) FROM SINHVIEN WHERE MASV = @MASV", conn);
                cmdKT.Parameters.AddWithValue("@MASV", txtMasv.Text);

                if ((int)cmdKT.ExecuteScalar() == 0)
                {
                    MessageBox.Show("Mã sinh viên không tồn tại!");
                    return;
                }

                // Update sql
                SqlCommand cmdSua = new SqlCommand(
                    @"UPDATE SINHVIEN
                    SET HOTEN = CASE WHEN @HOTEN = '' THEN HOTEN ELSE @HOTEN END,
                    NGAYSINH = CASE WHEN @NGAYSINH IS NULL THEN NGAYSINH ELSE @NGAYSINH END,
                    MALOP = @MALOP
                    WHERE MASV = @MASV", conn);

                cmdSua.Parameters.AddWithValue("@MASV", txtMasv.Text);
                cmdSua.Parameters.AddWithValue("@HOTEN", txtHoTen.Text);

                if (string.IsNullOrWhiteSpace(mtxtNgaySinh.Text.Replace("/", "").Trim()))
                {
                    cmdSua.Parameters.AddWithValue("@NGAYSINH", DBNull.Value);
                }
                else
                {
                    cmdSua.Parameters.AddWithValue("@NGAYSINH",
                        DateTime.ParseExact(mtxtNgaySinh.Text, "dd/MM/yyyy",
                        System.Globalization.CultureInfo.InvariantCulture));
                }

                cmdSua.Parameters.AddWithValue("@MALOP", cboLop.SelectedValue);

                cmdSua.ExecuteNonQuery();

                MessageBox.Show("Sửa sinh viên thành công");
            }
        }
    }
}



