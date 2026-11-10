using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace TH06b_BT2
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=PHUONGDAN;Database=QLSINHVIEN;Integrated Security=True;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Load masv
                SqlDataAdapter daSV = new SqlDataAdapter(
                    "SELECT MASV FROM SINHVIEN", conn);

                DataTable dtSV = new DataTable();
                daSV.Fill(dtSV);

                cboSinhVien.DataSource = dtSV;
                cboSinhVien.DisplayMember = "MASV";
                cboSinhVien.ValueMember = "MASV";
                cboSinhVien.SelectedIndex = -1;

                // Load mamh
                SqlDataAdapter daMH = new SqlDataAdapter(
                    "SELECT MAMH FROM MONHOC", conn);

                DataTable dtMH = new DataTable();
                daMH.Fill(dtMH);

                cboMonHoc.DataSource = dtMH;
                cboMonHoc.DisplayMember = "MAMH";
                cboMonHoc.ValueMember = "MAMH";
                cboMonHoc.SelectedIndex = -1;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Ktra masv
            if (cboSinhVien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã sinh viên");
                return;
            }

            // Ktra mamh
            if (cboMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã môn học");
                return;
            }

            // Ktra diem
            if (string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Vui lòng nhập điểm");
                return;
            }

            // Ktra diem tu 0-10
            if (!decimal.TryParse(txtDiem.Text, out decimal diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng (0-10)");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Ktra masv ton tai
                SqlCommand cmdSV = new SqlCommand(
                    "SELECT COUNT(*) FROM SINHVIEN WHERE MASV = @MASV", conn);
                cmdSV.Parameters.AddWithValue("@MASV", cboSinhVien.SelectedValue);

                if ((int)cmdSV.ExecuteScalar() == 0)
                {
                    MessageBox.Show("Mã sinh viên không tồn tại");
                    return;
                }

                // Ktra mamh ton tai
                SqlCommand cmdMH = new SqlCommand(
                    "SELECT COUNT(*) FROM MONHOC WHERE MAMH = @MAMH", conn);
                cmdMH.Parameters.AddWithValue("@MAMH", cboMonHoc.SelectedValue);

                if ((int)cmdMH.ExecuteScalar() == 0)
                {
                    MessageBox.Show("Mã môn học không tồn tại");
                    return;
                }

                // Ktra trung khoa chinh (MASV, MAMH)
                SqlCommand cmdKT = new SqlCommand(
                    "SELECT COUNT(*) FROM DIEM WHERE MASV = @MASV AND MAMH = @MAMH", conn);
                cmdKT.Parameters.AddWithValue("@MASV", cboSinhVien.SelectedValue);
                cmdKT.Parameters.AddWithValue("@MAMH", cboMonHoc.SelectedValue);

                if ((int)cmdKT.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Đã có mã sinh viên và mã môn học này trong bảng ĐIỂM");
                    return;
                }

                // Them diem
                SqlCommand cmdThem = new SqlCommand(
                    "INSERT INTO DIEM (MASV, MAMH, DIEM) VALUES (@MASV, @MAMH, @DIEM)", conn);

                cmdThem.Parameters.AddWithValue("@MASV", cboSinhVien.SelectedValue);
                cmdThem.Parameters.AddWithValue("@MAMH", cboMonHoc.SelectedValue);
                cmdThem.Parameters.AddWithValue("@DIEM", diem);

                cmdThem.ExecuteNonQuery();

                MessageBox.Show("Thêm điểm thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboSinhVien.SelectedIndex == -1 ||
        cboMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã sinh viên và mã môn học!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Ktra ton tai diem
                SqlCommand cmdKT = new SqlCommand(
                    "SELECT COUNT(*) FROM DIEM WHERE MASV = @MASV AND MAMH = @MAMH", conn);
                cmdKT.Parameters.AddWithValue("@MASV", cboSinhVien.SelectedValue);
                cmdKT.Parameters.AddWithValue("@MAMH", cboMonHoc.SelectedValue);

                if ((int)cmdKT.ExecuteScalar() == 0)
                {
                    MessageBox.Show("Không tìm thấy điểm cần xóa");
                    return;
                }

                // Xoa diem
                SqlCommand cmdXoa = new SqlCommand(
                    "DELETE FROM DIEM WHERE MASV = @MASV AND MAMH = @MAMH", conn);
                cmdXoa.Parameters.AddWithValue("@MASV", cboSinhVien.SelectedValue);
                cmdXoa.Parameters.AddWithValue("@MAMH", cboMonHoc.SelectedValue);

                cmdXoa.ExecuteNonQuery();

                MessageBox.Show("Xóa điểm thành công!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cboSinhVien.SelectedIndex == -1 ||
        cboMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã sinh viên và mã môn học");
                return;
            }

            if (!decimal.TryParse(txtDiem.Text, out decimal diem) ||
                diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng (0-10)");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Ktra ton tai diem
                SqlCommand cmdKT = new SqlCommand(
                    "SELECT COUNT(*) FROM DIEM WHERE MASV = @MASV AND MAMH = @MAMH", conn);
                cmdKT.Parameters.AddWithValue("@MASV", cboSinhVien.SelectedValue);
                cmdKT.Parameters.AddWithValue("@MAMH", cboMonHoc.SelectedValue);

                if ((int)cmdKT.ExecuteScalar() == 0)
                {
                    MessageBox.Show("Không tìm thấy điểm cần sửa");
                    return;
                }

                // Update diem
                SqlCommand cmdSua = new SqlCommand(
                    "UPDATE DIEM SET DIEM = @DIEM WHERE MASV = @MASV AND MAMH = @MAMH",
                    conn);

                cmdSua.Parameters.AddWithValue("@MASV", cboSinhVien.SelectedValue);
                cmdSua.Parameters.AddWithValue("@MAMH", cboMonHoc.SelectedValue);
                cmdSua.Parameters.AddWithValue("@DIEM", diem);

                cmdSua.ExecuteNonQuery();

                MessageBox.Show("Sửa điểm thành công");
            }
        }
    }
}
