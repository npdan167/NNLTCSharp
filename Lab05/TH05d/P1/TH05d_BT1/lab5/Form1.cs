using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class frmBai1 : Form
    {

        public frmBai1()
        {
            InitializeComponent();
            lvSinhVien.View = View.Details;
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.GridLines = true;
            lvSinhVien.MultiSelect = false;
            cboDanToc.Items.AddRange(new string[]
            {
                "Kinh", "Tày", "Thái", "Hoa", "Khmer", "Mường", "Nùng", "Dao"
            });
            cboDanToc.SelectedIndex = 0;
            radNam.Checked = true;
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Xoá", null, (s, e) => XoaSinhVien());
            lvSinhVien.ContextMenuStrip = menu;
            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
            btnSua.Click += btnSua_Click;
            lvSinhVien.SelectedIndexChanged += lvSinhVien_SelectedIndexChanged;
            this.FormClosing += frmBai1_FormClosing; 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            if (maSV == "" || hoTen == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên và mã sinh viên");
                return;
            }
            foreach (ListViewItem item in lvSinhVien.Items)
            {
                if (item.SubItems[0].Text == maSV)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại");
                    return;
                }
            }
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string ngoaiNgu = "";
            if (chkAnh.Checked) ngoaiNgu += "Anh ";
            if (chkPhap.Checked) ngoaiNgu += "Pháp ";
            if (chkHoa.Checked) ngoaiNgu += "Hoa ";

            ListViewItem sv = new ListViewItem(hoTen);
            sv.SubItems.Add(maSV);
            sv.SubItems.Add(gioiTinh);
            sv.SubItems.Add(ngoaiNgu.Trim());
            sv.SubItems.Add(cboDanToc.Text);
            lvSinhVien.Items.Add(sv);
            MessageBox.Show("Thêm sinh viên thành công");
            LamMoi();
        }
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
                return;
            ListViewItem sv = lvSinhVien.SelectedItems[0];
            txtHoTen.Text = sv.SubItems[0].Text;
            txtMaSV.Text = sv.SubItems[1].Text;
            radNam.Checked = sv.SubItems[2].Text == "Nam";
            radNu.Checked = sv.SubItems[2].Text == "Nữ";
            string nn = sv.SubItems[3].Text;
            chkAnh.Checked = nn.Contains("Anh");
            chkPhap.Checked = nn.Contains("Pháp");
            chkHoa.Checked = nn.Contains("Hoa");
            cboDanToc.Text = sv.SubItems[4].Text;
            txtMaSV.ReadOnly = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaSinhVien();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa");
                return;
            }
            ListViewItem sv = lvSinhVien.SelectedItems[0];
            sv.SubItems[0].Text = txtHoTen.Text.Trim();
            sv.SubItems[2].Text = radNam.Checked ? "Nam" : "Nữ";
            string ngoaiNgu = "";
            if (chkAnh.Checked) ngoaiNgu += "Anh ";
            if (chkPhap.Checked) ngoaiNgu += "Pháp ";
            if (chkHoa.Checked) ngoaiNgu += "Hoa ";
            sv.SubItems[3].Text = ngoaiNgu.Trim();
            sv.SubItems[4].Text = cboDanToc.Text;
            MessageBox.Show("Sửa thông tin sinh viên thành công");
        }

        private void XoaSinhVien()
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Xác nhận xóa?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (kq == DialogResult.Yes)
            {
                lvSinhVien.SelectedItems[0].Remove();
            }
        }

        private void LamMoi()
        {
            txtHoTen.Clear();
            txtMaSV.Clear();
            txtMaSV.ReadOnly = false;
            radNam.Checked = true;
            chkAnh.Checked = false;
            chkPhap.Checked = false;
            chkHoa.Checked = false;
            cboDanToc.SelectedIndex = 0;
            lvSinhVien.SelectedItems.Clear();
            txtHoTen.Focus();
        }

        private void frmBai1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show(
                "Xác nhận thoát?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {

        }
    }
}
