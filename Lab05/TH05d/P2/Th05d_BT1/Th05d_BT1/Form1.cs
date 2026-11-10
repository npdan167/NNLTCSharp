using System.Data.SqlClient;

namespace Th05d_BT1
{
    public partial class Form1 : Form
    {
        string connStr = @"Data Source=PHUONGDAN;Initial Catalog=QLSINHVIEN;Integrated Security=True;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMMH.Text.Trim() == "" || txtTMH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã và tên môn học");
                return;
            }

            string sql = "INSERT INTO MONHOC (MAMH, TENMH) VALUES (@MAMH, @TENMH)";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MAMH", txtMMH.Text.Trim());
                    cmd.Parameters.AddWithValue("@TENMH", txtTMH.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Thêm môn học thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMMH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã môn học");
                return;
            }

            string sql = "DELETE FROM MONHOC WHERE MAMH = @MAMH";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MAMH", txtMMH.Text.Trim());
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                        MessageBox.Show("Xóa môn học thành công");
                    else
                        MessageBox.Show("Không tìm thấy mã môn học");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMMH.Text.Trim() == "" || txtTMH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã và tên môn học");
                return;
            }

            string sql = "UPDATE MONHOC SET TENMH = @TENMH WHERE MAMH = @MAMH";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MAMH", txtMMH.Text.Trim());
                    cmd.Parameters.AddWithValue("@TENMH", txtTMH.Text.Trim());
                    int kq = cmd.ExecuteNonQuery();
                    if (kq > 0)
                        MessageBox.Show("Sửa môn học thành công");
                    else
                        MessageBox.Show("Không tìm thấy mã môn học");
                }
            }
        }
    }
}
