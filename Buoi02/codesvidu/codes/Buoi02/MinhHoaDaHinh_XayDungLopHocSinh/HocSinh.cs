using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNLTCS.BaiTap.XayDungLopHocSinh
{
    public class HocSinh: IComparable
    {
        public String HoTen { get; set; }
        public Nullable<DateTime> NgaySinh { get; set; }
        public String LopHoc { get; set; }
        public Nullable<int> DiemThi { get; set; }

        public HocSinh(string hoten, DateTime? ngaysinh, string lophoc, int? diem)
        {
            HoTen = hoten;
            NgaySinh = ngaysinh;
            LopHoc = lophoc;
            DiemThi = diem;
        }

        public override string ToString()
        {
            string kq = "";
            
            kq += HoTen + " - ";
            
            if (NgaySinh.HasValue)
                kq += NgaySinh.ToString() + " - ";
            else kq += "Empty - ";

            kq += LopHoc + " - ";

            if (DiemThi.HasValue)
                kq += DiemThi.ToString();
            else kq += " Vang thi";

            return kq;
        }

        public int CompareTo(object obj)
        {
            HocSinh hs = obj as HocSinh;

            return this.HoTen.CompareTo(hs.HoTen);
        }
    }
}
