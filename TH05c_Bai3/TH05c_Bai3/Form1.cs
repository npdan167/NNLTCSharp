namespace TH05c_Bai3
{
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        private bool kiemtra(string s)
        {
            foreach (TreeNode node in trv_DS.Nodes)
            {
                if (string.Compare(node.Text, s, true) == 0)
                {
                    return false;
                }
            }

            return true;
        }


        private void frmTreeView_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void frmTreeView_Load(object sender, EventArgs e)
        {
            string[] pb = { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế Toán" };

            foreach (string s in pb)
            {
                trv_DS.Nodes.Add(s); //thêm node vào treeview
                cbo_phongban.Items.Add(s); //thêm item vào combobox
            }
            cbo_phongban.SelectedIndex = 0; //item đầu tiên trên được chọn
        }

        private void btn_ThemPB_Click(object sender, EventArgs e)
        {
            // Kiểm tra txt_Phongban có tồn tại trong TreeView chưa
            if (kiemtra(txt_phongban.Text))
            {
                trv_DS.Nodes.Add(txt_phongban.Text);
                cbo_phongban.Items.Add(txt_phongban.Text);
            }
            else
                MessageBox.Show("Phòng ban đã tồn tại!");
            txt_phongban.Text = "";
            txt_phongban.Focus();
        }

        private void btn_XoaPB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == DialogResult.Yes)

            {
                // Một phòng ban trong treeView được chọn
                if (trv_DS.SelectedNode != null)
                {
                    cbo_phongban.Items.Remove(trv_DS.SelectedNode.Text);
                    trv_DS.Nodes.Remove(trv_DS.SelectedNode);
                }
            }
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            //tìm index của node có nội dung là item được chọn trong
            //combobox phòng ban
            int index = -1;
            foreach (TreeNode node in trv_DS.Nodes)
                if (node.Text == cbo_phongban.Text)
                {
                    index = node.Index;
                    break;
                }
            trv_DS.Nodes[index].Nodes.Add(txt_hoten.Text + "("+txt_maso.Text+")");
            
            trv_DS.ExpandAll(); //mở rộng treeview
        }
    }
}
