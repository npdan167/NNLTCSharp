using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab5
{
    public partial class frmBaiTap2 : Form
    {
        public frmBaiTap2()
        {
            InitializeComponent();
            // Thiết lập ListView
            lvTaiKhoan.View = View.Details;
            lvTaiKhoan.FullRowSelect = true;
            lvTaiKhoan.GridLines = true;
            lvTaiKhoan.MultiSelect = false;

            // Trạng thái ban đầu
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            txtTongTien.ReadOnly = true;

            // Gắn sự kiện
            Load += frmBaiTap2_Load;
            btnThem.Click += btnThem_Click;
            btnLuu.Click += btnLuu_Click;
            btnXoa.Click += btnXoa_Click;
            btnThoat.Click += btnThoat_Click;
            lvTaiKhoan.SelectedIndexChanged += lvTaiKhoan_SelectedIndexChanged;
            // Thêm các cột cho ListView
            lvTaiKhoan.Columns.Clear();

            lvTaiKhoan.Columns.Add("STT", 45);
            lvTaiKhoan.Columns.Add("Số tài khoản", 120);
            lvTaiKhoan.Columns.Add("Tên khách hàng", 150);
            lvTaiKhoan.Columns.Add("Địa chỉ", 180);
            lvTaiKhoan.Columns.Add("Số tiền", 130);
        }



        // Tổng tiền tất cả tài khoản
        private void CapNhatTongTien()
        {
            decimal tong = 0;

            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                decimal soTien;
                decimal.TryParse(
                    item.SubItems[4].Text,
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out soTien);

                tong += soTien;
            }

            txtTongTien.Text = tong.ToString("N0");
        }

        // Đánh số thứ tự tự động
        private void CapNhatSTT()
        {
            for (int i = 0; i < lvTaiKhoan.Items.Count; i++)
            {
                lvTaiKhoan.Items[i].Text = (i + 1).ToString();
            }
        }

        // Xóa trắng các ô nhập liệu
        private void LamMoi()
        {
            txtSTK.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            txtSTK.ReadOnly = false;
            lvTaiKhoan.SelectedItems.Clear();
            btnXoa.Enabled = false;
            txtSTK.Focus();
        }

        // Form Load
        private void frmBaiTap2_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            CapNhatTongTien();
        }

        // Nút Thêm / Hủy
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;

                LamMoi();
            }
            else
            {
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;

                LamMoi();
            }
        }

        // Nút Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string soTK = txtSTK.Text.Trim();
            string ten = textBox1.Text.Trim();
            string diaChi = textBox2.Text.Trim();

            decimal soTien;

            if (soTK == "" || ten == "" ||
                diaChi == "" || textBox3.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Chấp nhận số tiền dạng 1200000
            // hoặc 1,200,000 theo thiết lập CultureInfo
            if (!decimal.TryParse(
                textBox3.Text.Trim(),
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out soTien))
            {
                MessageBox.Show("Số tiền không hợp lệ!");
                textBox3.Focus();
                return;
            }

            if (soTien < 0)
            {
                MessageBox.Show("Số tiền không được âm!");
                return;
            }

            // Kiểm tra số tài khoản trùng
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                if (item.SubItems[1].Text == soTK)
                {
                    MessageBox.Show("Số tài khoản đã tồn tại!");
                    return;
                }
            }

            ListViewItem dong = new ListViewItem("");

            dong.SubItems.Add(soTK);
            dong.SubItems.Add(ten);
            dong.SubItems.Add(diaChi);
            dong.SubItems.Add(
                soTien.ToString(CultureInfo.InvariantCulture));

            lvTaiKhoan.Items.Add(dong);

            CapNhatSTT();
            CapNhatTongTien();

            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;

            LamMoi();

            MessageBox.Show("Lưu tài khoản thành công!");
        }

        // Chọn một tài khoản trong ListView
        private void lvTaiKhoan_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count == 0)
            {
                btnXoa.Enabled = false;
                return;
            }

            ListViewItem dong = lvTaiKhoan.SelectedItems[0];

            txtSTK.Text = dong.SubItems[1].Text;
            textBox1.Text = dong.SubItems[2].Text;
            textBox2.Text = dong.SubItems[3].Text;

            decimal soTien = decimal.Parse(
                dong.SubItems[4].Text,
                CultureInfo.InvariantCulture);

            textBox3.Text = soTien.ToString("N0");

            btnXoa.Enabled = true;
        }

        // Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count == 0)
                return;

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa tài khoản này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                lvTaiKhoan.SelectedItems[0].Remove();

                CapNhatSTT();
                CapNhatTongTien();
                LamMoi();
            }
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBaiTap2_Load_1(object sender, EventArgs e)
        {

        }

        private void frmBaiTap2_Load_2(object sender, EventArgs e)
        {

        }
    }
}
