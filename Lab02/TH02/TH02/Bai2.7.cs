using System;
using System.Collections.Generic;
using System.Text;

namespace TH02
{
    public class NhanVien
    {
        public string HoTen { get; set; }
        public int Luong { get; set; }
        public int SoNgayVang { get; set; }
        public NhanVien()
        {
            HoTen = "";
            Luong = 0;
            SoNgayVang = 0;
        }
        public NhanVien(string HoTen, int Luong, int SoNgayVang)
        {
            this.HoTen = HoTen;
            this.Luong = Luong;
            this.SoNgayVang = SoNgayVang;
        }
        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap muc luong: ");
            Luong = int.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay vang: ");
            SoNgayVang = int.Parse(Console.ReadLine());
        }
        public int TinhLuong()
        {
            return Luong - SoNgayVang * 100000;
        }
    }

    public class PhongBan
    {
        public NhanVien[] a;
        public PhongBan()
        {
            a = new NhanVien[0];
        }
        public PhongBan(int n)
        {
            a = new NhanVien[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = new NhanVien();
            }
        }
        public PhongBan(PhongBan p)
        {
            a = new NhanVien[p.a.Length];
            for (int i = 0; i < p.a.Length; i++)
            {
                a[i] = new NhanVien(
                    p.a[i].HoTen,
                    p.a[i].Luong,
                    p.a[i].SoNgayVang
                );
            }
        }
        public NhanVien this[int i]
        {
            get
            {
                return a[i];
            }
            set
            {
                a[i] = value;
            }
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap nhan vien:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i].Nhap();
            }
        }
        public int TongLuong()
        {
            int tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                tong += a[i].TinhLuong();
            }
            return tong;
        }

        public void Xuat()
        {
            int tong = TongLuong();
            Console.WriteLine("\nTong luong: " + tong);
        }
    }
}