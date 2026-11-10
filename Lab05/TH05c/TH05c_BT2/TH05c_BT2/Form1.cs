namespace TH05c_BT2
{
    public partial class frm_QLSV : Form
    {
        public frm_QLSV()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void frm_QLSV_Load(object sender, EventArgs e)
        {
            // Xoa du lieu cu
            trv_DSLop.Nodes.Clear();
            cbo_ChonLop.Items.Clear();

            // Tao cac lop
            string[] dsLop = { "05DHTH1", "05DHTH2", "05DHTH3", "05DHTH4" };

            foreach (string tenLop in dsLop)
            {
                trv_DSLop.Nodes.Add(tenLop);
                cbo_ChonLop.Items.Add(tenLop);
            }

            // Them sinh vien mau vao lop 05DHTH2
            TreeNode lop = trv_DSLop.Nodes[1];

            TreeNode sinhVien = lop.Nodes.Add("2001140001, Nguyễn Văn A");
            sinhVien.Nodes.Add("TPHCM");

            // Mo cac node de hien thi du lieu mau
            trv_DSLop.ExpandAll();

            // Chon lop dau tien trong ComboBox
            cbo_ChonLop.SelectedIndex = 0;

            // Group box mac dinh false 
            cb_ThemLop.Checked = false;
            grp_ThemLop.Visible = false;
        }

        private void cb_ThemLop_CheckedChanged(object sender, EventArgs e)
        {
            grp_ThemLop.Visible = cb_ThemLop.Checked;
        }

        private void btn_ThemLop_Click(object sender, EventArgs e)
        {
            string tenLop = txt_TTL.Text.Trim();

            // Kiem tra ten lop da ton tai
            foreach (TreeNode node in trv_DSLop.Nodes)
            {
                if (string.Compare(node.Text, tenLop, true) == 0)
                {
                    MessageBox.Show("Tên lớp đã tồn tại");
                    txt_TTL.Focus();
                    return;
                }
            }

            // Them lop vao TreeView va ComboBox
            trv_DSLop.Nodes.Add(tenLop);
            cbo_ChonLop.Items.Add(tenLop);

            txt_TTL.Clear();
            txt_TTL.Focus();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            // Lay thong tin sinh vien
            string msv = txt_MSV.Text.Trim();
            string hoTen = txt_HoTen.Text.Trim();
            string diaChi = txt_DiaChi.Text.Trim();

            // Kiem tra cac o nhap lieu
            if (msv == "" || hoTen == "" || diaChi == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên");
                return;
            }

            // Kiem tra da chon lop chua
            if (cbo_ChonLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn lớp");
                return;
            }

            // Kiem tra ma sinh vien co bi trung khong
            foreach (TreeNode lop in trv_DSLop.Nodes)
            {
                foreach (TreeNode nodeMSV in lop.Nodes)
                {
                    // Tach ma sinh vien khoi chuoi "MaSV, HoTen"
                    string[] thongTin = nodeMSV.Text.Split(
                        new string[] { ", " },
                        StringSplitOptions.None
                    );

                    if (thongTin[0] == msv)
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại");
                        txt_MSV.Focus();
                        return;
                    }
                }
            }

            // Tim lop duoc chon trong TreeView
            string tenLop = cbo_ChonLop.SelectedItem.ToString();
            TreeNode lopDuocChon = null;

            foreach (TreeNode lop in trv_DSLop.Nodes)
            {
                if (lop.Text == tenLop)
                {
                    lopDuocChon = lop;
                    break;
                }
            }

            // Them sinh vien vao lop
            TreeNode nodeSinhVien = lopDuocChon.Nodes.Add(msv + ", " + hoTen);
            nodeSinhVien.Nodes.Add(diaChi);

            // Xoa thong tin vua nhap
            txt_MSV.Clear();
            txt_HoTen.Clear();
            txt_DiaChi.Clear();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            // Lay node dang duoc chon
            TreeNode nodeChon = trv_DSLop.SelectedNode;

            // Chi cho phep xoa node sinh vien
            if (nodeChon.Parent == null || nodeChon.Parent.Parent != null)
            {
                MessageBox.Show("Chỉ cho phép xóa sinh viên");
                return;
            }

            // Xac nhan truoc khi xoa
            DialogResult ketQua = MessageBox.Show(
                "Xác nhận xóa?",
                "Xóa sinh viên",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                // Xoa node sinh vien va node con dia chi
                nodeChon.Remove();
            }
        }

        private void trv_DSLop_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode nodeChon = e.Node;
            // Chi xu ly khi nhap vao node sinh vien
            if (nodeChon.Parent != null && nodeChon.Parent.Parent == null)
            {
                // Tach ma sinh vien va ho ten
                string[] thongTin = nodeChon.Text.Split(new string[] { ", " }, StringSplitOptions.None);

                txt_MSV.Text = thongTin[0];
                txt_HoTen.Text = thongTin.Length > 1 ? thongTin[1] : "";

                // Lay dia chi tu node con
                if (nodeChon.Nodes.Count > 0)
                {
                    txt_DiaChi.Text = nodeChon.Nodes[0].Text;
                }
                else
                {
                    txt_DiaChi.Clear();
                }
            }
        }
    }
}