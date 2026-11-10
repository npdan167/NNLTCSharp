using System;
using System.Collections.Generic;
using System.Text;

namespace TH02
{
    // Lop cha
    public class NhanVien3_5
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public NhanVien3_5()
        {
            MaNV = "";
            HoTen = "";
        }
        public NhanVien3_5(string MaNV, string HoTen)
        {
            this.MaNV = MaNV;
            this.HoTen = HoTen;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap ma nhan vien: ");
            MaNV = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
        }
        public virtual double TinhLuong()
        {
            return 0;
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Ma NV: " + MaNV);
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Luong: " + TinhLuong());
        }
    }

    //Nhan vien kinh doanh
    public class NhanVienKinhDoanh : NhanVien3_5
    {
        public double LuongCoBan { get; set; }
        public int SoHopDong { get; set; }
        public NhanVienKinhDoanh() : base()
        {
            LuongCoBan = 0;
            SoHopDong = 0;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap luong co ban: ");
            LuongCoBan = double.Parse(Console.ReadLine());

            Console.Write("Nhap so hop dong: ");
            SoHopDong = int.Parse(Console.ReadLine());
        }
        public override double TinhLuong()
        {
            return LuongCoBan + SoHopDong * 500000;
        }
    }

    //Nhan vien san xuat
    public class NhanVienSanXuat : NhanVien3_5
    {
        public int SoSanPham { get; set; }
        public NhanVienSanXuat() : base()
        {
            SoSanPham = 0;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so san pham: ");
            SoSanPham = int.Parse(Console.ReadLine());
        }
        public override double TinhLuong()
        {
            double luong = SoSanPham * 1000;
            if (SoSanPham > 3000)
            {
                luong = luong * 1.05;
            }
            return luong;
        }
    }
}