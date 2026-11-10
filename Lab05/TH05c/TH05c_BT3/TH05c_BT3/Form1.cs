using System.Collections.Generic;
using System.Globalization;
using Microsoft.VisualBasic;

namespace TH05c_BT3
{
    public partial class frm_Chuoi : Form
    {
        public frm_Chuoi()
        {
            InitializeComponent();
        }

        private void btnNgauNhien_Click(object sender, EventArgs e)
        {
            string[] HO = { "Lê", "Nguyễn", "Lý", "Trần", "Lâm", "Hồ", "Lai", "Huỳnh", "La" };

            string[] TENLOT = { "Quang", "Thành", "Ngọc", "Anh", "Xuân", "Bảo", "Cẩm", "Thị", "Kim", "Thái", "Hồng" };

            string[] TEN = { "Hà", "Danh", "Sơn", "Mai", "Thắng", "Kỳ", "Thành", "Lâm", "Tâm", "Phụng", "Thắm" };

            Random rd = new Random();

            for (int i = 0; i < 50; i++)
            {
                string ho = HO[rd.Next(HO.Length)];
                string tenLot = TENLOT[rd.Next(TENLOT.Length)];
                string ten = TEN[rd.Next(TEN.Length)];

                string hoTen = ho + " " + tenLot + " " + ten;

                lst_HoTen.Items.Add(hoTen);
            }
        }
        // xóa phần tử đang chọn
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            lst_HoTen.Items.Remove(lst_HoTen.SelectedItem);
        }
        //xóa phần tử tên Sơn
        private void btn_XoaSon_Click(object sender, EventArgs e)
        {
            for (int i = lst_HoTen.Items.Count - 1; i >= 0; i--)
            {
                if (lst_HoTen.Items[i].ToString().Contains("Sơn"))
                {
                    lst_HoTen.Items.RemoveAt(i);
                }
            }
        }
        // xóa phần tử họ Lê
        private void btn_XoaLe_Click(object sender, EventArgs e)
        {
            for (int i = lst_HoTen.Items.Count - 1; i >= 0; i--)
            {
                if (lst_HoTen.Items[i].ToString().Contains("Lê"))
                {
                    lst_HoTen.Items.RemoveAt(i);
                }
            }
        }
        // chuyển thành chuỗi in hoa
        private void btn_ChuyenHOA_Click(object sender, EventArgs e)
        {
            List<string> dsTen = new List<string>();

            foreach (var item in lst_HoTen.Items)
            {
                dsTen.Add(item.ToString().ToUpper());
            }

            lst_HoTen.DataSource = null;
            lst_HoTen.Items.Clear();
            lst_HoTen.Items.AddRange(dsTen.ToArray());
        }
        // chuyển thành chuỗi thường
        private void btn_ChuyenThuong_Click(object sender, EventArgs e)
        {
            List<string> dsTen = new List<string>();
            foreach (var item in lst_HoTen.Items)
            {
                dsTen.Add(item.ToString().ToLower());
            }

            lst_HoTen.DataSource = null;
            lst_HoTen.Items.Clear();
            lst_HoTen.Items.AddRange(dsTen.ToArray());
        }
        // chuyển thành chuỗi viết hoa chữ đầu tiên
        private void btn_ChuyenHDT_Click(object sender, EventArgs e)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            List<string> dsTen = new List<string>();

            foreach (var item in lst_HoTen.Items)
            {
                dsTen.Add(textInfo.ToTitleCase(item.ToString().ToLower()));
            }

            lst_HoTen.DataSource = null;
            lst_HoTen.Items.Clear();
            lst_HoTen.Items.AddRange(dsTen.ToArray());
        }
        // xóa tất cả phần tử
        private void btn_XoaAll_Click(object sender, EventArgs e)
        {
            lst_HoTen.Items.Clear();
        }

        private void lst_HoTen_DoubleClick(object sender, EventArgs e)
        {
            // Kiem tra da chon ten chua
            if (lst_HoTen.SelectedIndex == -1)
            {
                return;
            }
            // Lay ten dang duoc chon
            int viTri = lst_HoTen.SelectedIndex;
            string tenCu = lst_HoTen.SelectedItem.ToString();

            // Mo InputBox de nhap ten moi
            string tenMoi = Interaction.InputBox(
                "Nhập tên mới: ",
                tenCu
            );
            // Neu nguoi dung nhap ten moi thi cap nhat
            if (!string.IsNullOrWhiteSpace(tenMoi))
            {
                lst_HoTen.Items[viTri] = tenMoi.Trim();
            }
        }
    }
}


