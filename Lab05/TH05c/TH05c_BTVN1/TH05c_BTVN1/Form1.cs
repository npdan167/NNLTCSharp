using System.Collections.Generic;

namespace TH05c_BTVN1
{
    public partial class frm_BTVN1 : Form
    {

        Dictionary<string, string> AnhViet = new Dictionary<string, string>()
        {
            { "student", "Sinh viên, học sinh" },
            { "teacher", "Giáo viên" },
            { "worker", "Công nhân" },
            { "hat", "Cái mũ" },
            { "head", "Đầu" },
            { "mouse", "Con chuột" },
            { "cat", "Con mèo" },
            { "dog", "Con chó" },
            { "snake", "Con rắn" },
            { "lumb", "Khối" },
            {"loan", "Khoản vay" },
            {"frog", "Con ếch" },
            {"sheep", "Con cừu" }
        };

        public frm_BTVN1()
        {
            InitializeComponent();
        }

        private void frm_BTVN1_Load(object sender, EventArgs e)
        {
            // Load toàn bộ từ tiếng Anh vào ListBox tab 1
            foreach (string tu in AnhViet.Keys)
            {
                lstTiengAnh.Items.Add(tu);
            }

            // Load toàn bộ nghĩa tiếng Việt vào ListBox tab 2
            foreach (string tu in AnhViet.Values)
            {
                lstTiengViet.Items.Add(tu);
            }
        }

        private void cboTiengAnh_KeyDown(object sender, KeyEventArgs e)
        {
            // Chọn từ trong cboTiengAnh tra nghĩa TV
            if (e.KeyCode == Keys.Enter)
            {
                string tu = cboTiengAnh.Text;

                if (AnhViet.ContainsKey(tu))
                {
                    txtNghiaViet.Text = AnhViet[tu];
                }
                e.SuppressKeyPress = true;
            }
        }

        private void lstTiengAnh_DoubleClick(object sender, EventArgs e)
        {
            // DoubleClick vào từ trong list tra nghĩa TV
            if (lstTiengAnh.SelectedItem != null)
            {
                string tu = lstTiengAnh.SelectedItem.ToString();
                cboTiengAnh.Text = tu;
                txtNghiaViet.Text = AnhViet[tu];
            }
        }

        private void cboTiengViet_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chọn từ TV tra nghĩa TA
            string tu = cboTiengViet.Text;
            foreach (var item in AnhViet)
            {
                if (item.Value == tu)
                {
                    txtNghiaAnh.Text = item.Key;
                    break;
                }
            }
        }

        private void lstTiengViet_DoubleClick(object sender, EventArgs e)
        {
            if (lstTiengViet.SelectedItem != null)
            {
                string nghiaViet = lstTiengViet.SelectedItem.ToString();

                foreach (var item in AnhViet)
                {
                    if (item.Value == nghiaViet)
                    {
                        cboTiengViet.Text = nghiaViet;
                        txtNghiaAnh.Text = item.Key;
                        break;
                    }
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboTiengAnh_TextUpdate(object sender, EventArgs e)
        {
            // Tìm chữ khớp kí tự Anh-Việt
            string tuNhap = cboTiengAnh.Text.ToLower();
            lstTiengAnh.Items.Clear();

            foreach (string tu in AnhViet.Keys)
            {
                if (tu.StartsWith(tuNhap))
                {
                    lstTiengAnh.Items.Add(tu);
                }
            }
        }

        private void cboTiengViet_TextUpdate(object sender, EventArgs e)
        {
            // Tìm chữ khớp kí tự Việt-Anh
            string tuNhap = cboTiengViet.Text.ToLower();
            lstTiengViet.Items.Clear();

            foreach (string tu in AnhViet.Values)
            {
                if (tu.ToLower().StartsWith(tuNhap))
                {
                    lstTiengViet.Items.Add(tu);
                }
            }
        }
    }
}
