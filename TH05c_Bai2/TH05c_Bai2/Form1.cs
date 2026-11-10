namespace TH05c_Bai2
{
    public partial class Cbo_Dantoc : Form
    {
        public Cbo_Dantoc()
        {
            InitializeComponent();
        }

        private void btn_loadDL_Click(object sender, EventArgs e)
        {
            string[] dt = { "Kinh", "Hoa", "K’Me", "H’Mong", "Khac" };
            foreach (string s in dt)
            {
                cbo_dt.Items.Add(s);
            }
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            string s = "Dân tộc được chọn: ";
            if (cbo_dt.SelectedIndex >= 0)
                lbl_kq.Text = s + cbo_dt.SelectedItem.ToString();
            else
                lbl_kq.Text = "Bạn chưa chọn dân tộc";
        }

        private void cboDanToc_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Dân tộc được chọn: " + cbo_dt.SelectedItem.ToString()
            );
        }

        private void cbo_dt_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Dân tộc được chọn: " + cbo_dt.SelectedItem.ToString()
            );
        }
    }
}
