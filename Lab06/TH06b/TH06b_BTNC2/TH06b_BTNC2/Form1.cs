using Microsoft.Data.SqlClient;
using System.Data;

namespace TH06b_BTNC2
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
            if (lvDiem.Columns.Count == 0)
            {
                lvDiem.Columns.Add("STT", 50);
                lvDiem.Columns.Add("Tên sinh viên", 180);
                lvDiem.Columns.Add("Ngày sinh", 100);
                lvDiem.Columns.Add("Tên môn học", 180);
                lvDiem.Columns.Add("Điểm", 70);
            }

            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT MAMH FROM MONHOC ORDER BY MAMH";

            // Load mamh vao combobox
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    cboMonHoc.Items.Clear();
                    cboMonHoc.Items.Add("");

                    while (reader.Read())
                    {
                        cboMonHoc.Items.Add(reader["MAMH"].ToString());
                    }
                }
            }

            // Hien thi diem len listview
            string sqlDiem = @"
                SELECT SV.HOTEN, SV.NGAYSINH, MH.TENMH, D.DIEM
                FROM DIEM D
                INNER JOIN SINHVIEN SV ON D.MASV = SV.MASV
                INNER JOIN MONHOC MH ON D.MAMH = MH.MAMH
                ORDER BY SV.MASV, MH.MAMH";

            using SqlCommand cmdDiem = new SqlCommand(sqlDiem, conn);
            using SqlDataReader readerDiem = cmdDiem.ExecuteReader();

            lvDiem.Items.Clear();
            int stt = 1;

            double tongDiem = 0;
            while (readerDiem.Read())
            {
                ListViewItem item = new ListViewItem(stt.ToString());

                item.SubItems.Add(readerDiem["HOTEN"].ToString());
                item.SubItems.Add(
                    Convert.ToDateTime(readerDiem["NGAYSINH"]).ToString("dd/MM/yyyy"));
                item.SubItems.Add(readerDiem["TENMH"].ToString());
                item.SubItems.Add(readerDiem["DIEM"].ToString());

                lvDiem.Items.Add(item);
                tongDiem += Convert.ToDouble(readerDiem["DIEM"]);
                stt++;
            }
            txtTongDiem.Text = tongDiem.ToString();

        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string maMH = cboMonHoc.Text.Trim();

            string sqlDiem = @"
                SELECT SV.HOTEN, SV.NGAYSINH, MH.TENMH, D.DIEM
                FROM DIEM D
                INNER JOIN SINHVIEN SV ON D.MASV = SV.MASV
                INNER JOIN MONHOC MH ON D.MAMH = MH.MAMH
                WHERE (@MAMH = '' OR D.MAMH = @MAMH)
                ORDER BY SV.MASV, MH.MAMH";

            using SqlCommand cmd = new SqlCommand(sqlDiem, conn);
            cmd.Parameters.AddWithValue("@MAMH", maMH);

            using SqlDataReader reader = cmd.ExecuteReader();

            lvDiem.Items.Clear();
            int stt = 1;
            double tongDiem = 0;

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(stt.ToString());

                item.SubItems.Add(reader["HOTEN"].ToString());
                item.SubItems.Add(
                    Convert.ToDateTime(reader["NGAYSINH"]).ToString("dd/MM/yyyy"));
                item.SubItems.Add(reader["TENMH"].ToString());
                item.SubItems.Add(reader["DIEM"].ToString());

                lvDiem.Items.Add(item);

                tongDiem += Convert.ToDouble(reader["DIEM"]);
                stt++;
            }

            txtTongDiem.Text = tongDiem.ToString();
        }
    }
}
