using System.Data;
using Microsoft.Data.SqlClient;

namespace TH06b_BTNC1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=PHUONGDAN;Database=QLSINHVIEN;Integrated Security=True;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            lvLop.Clear();

            lvLop.View = View.Details;
            lvLop.FullRowSelect = true;
            lvLop.GridLines = true;

            lvLop.Columns.Add("STT", 70);
            lvLop.Columns.Add("Mã lớp", 192);
            lvLop.Columns.Add("Tên lớp", 300);
            lvLop.Columns.Add("Mã khoa", 150);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT MALOP, TENLOP, MAKHOA FROM LOP";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int stt = 1;

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(stt.ToString());

                        item.SubItems.Add(reader["MALOP"].ToString());
                        item.SubItems.Add(reader["TENLOP"].ToString());
                        item.SubItems.Add(reader["MAKHOA"].ToString());

                        lvLop.Items.Add(item);
                        stt++;
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
