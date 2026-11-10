namespace TH05C
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void lst_Trai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_Phai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnQuaPhai_Click(object sender, EventArgs e)
        {
            // Chuyển giá trị chọn bên trái sang phải
            lst_Phai.Items.Add(lst_Trai.SelectedItem);
            // Xóa giá trị chọn bên trái
            lst_Trai.Items.Remove(lst_Trai.SelectedItem);
        }

        private void btnQuaPhaiAll_Click(object sender, EventArgs e)
        {
            // Chuyển giá trị items bên trái sang phải
            lst_Phai.Items.AddRange(lst_Trai.Items);
            // Xóa giá trị bên trái
            lst_Trai.Items.Clear();
        }

        private void btnQuaTrai_Click(object sender, EventArgs e)
        {
            // Chuyen gia tri chon ben phai sang trai
            lst_Trai.Items.Add(lst_Phai.SelectedItem);
            // Xoa gia tri chon ben phai
            lst_Phai.Items.Remove(lst_Phai.SelectedItem);
        }

        private void btnQuaTraiAll_Click(object sender, EventArgs e)
        {
            // Chuyển giá trị items bên trái sang phải
            lst_Trai.Items.AddRange(lst_Phai.Items);
            // Xóa giá trị bên trái
            lst_Phai.Items.Clear();
        }

        private void frmListBox_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
