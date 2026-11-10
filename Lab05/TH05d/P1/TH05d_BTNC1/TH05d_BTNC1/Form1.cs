namespace TH05d_BTNC1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lstLopA.Items.Add("Trần Hùng");
            lstLopA.Items.Add("Nguyễn Hưng");
            lstLopA.Items.Add("Lâm Tứ");

            lstLopB.Items.Add("Tuấn Hưng");
            lstLopB.Items.Add("Hồng Ngọc");
            lstLopB.Items.Add("Anh Minh");
            lstLopB.Items.Add("Bảo Lâm");

        }

        private void tsmiChuyenB_Click(object sender, EventArgs e)
        {

            if (lstLopA.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn học viên ở lớp A!");
                return;
            }

            while (lstLopA.SelectedItems.Count > 0)
            {
                object hocVien = lstLopA.SelectedItems[0];

                lstLopB.Items.Add(hocVien);
                lstLopA.Items.Remove(hocVien);
            }

        }

        private void tsmiChuyenA_Click(object sender, EventArgs e)
        {

            if (lstLopB.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn học viên ở lớp B!");
                return;
            }

            while (lstLopB.SelectedItems.Count > 0)
            {
                object hocVien = lstLopB.SelectedItems[0];

                lstLopA.Items.Add(hocVien);
                lstLopB.Items.Remove(hocVien);
            }

        }

        private void tsmiXoa_Click(object sender, EventArgs e)
        {

            if (lstLopA.SelectedItems.Count == 0 &&
                lstLopB.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn học viên cần xóa!");
                return;
            }

            while (lstLopA.SelectedItems.Count > 0)
            {
                lstLopA.Items.Remove(lstLopA.SelectedItems[0]);
            }

            while (lstLopB.SelectedItems.Count > 0)
            {
                lstLopB.Items.Remove(lstLopB.SelectedItems[0]);
            }

        }

        private void tsmiNhap_Click(object sender, EventArgs e)
        {

            using (frmNhap f = new frmNhap())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    if (f.LopDuocChon == "Lớp A")
                    {
                        lstLopA.Items.Add(f.HoTenNhap);
                    }
                    else if (f.LopDuocChon == "Lớp B")
                    {
                        lstLopB.Items.Add(f.HoTenNhap);
                    }
                }
            }

        }

        private void tmsKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Xác nhận kết thúc?",
                "Xác nhận kết thúc",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
