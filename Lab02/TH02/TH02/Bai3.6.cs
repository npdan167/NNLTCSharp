using System;
using System.Collections.Generic;
using System.Text;

namespace TH02
{
    //Lop cha
    public class ThiSinh
    {
        public string SBD { get; set; }
        public string HoTen { get; set; }
        public double Bai1 { get; set; }
        public double Bai2 { get; set; }
        public double Bai3 { get; set; }
        public ThiSinh()
        {
            SBD = "";
            HoTen = "";
            Bai1 = 0;
            Bai2 = 0;
            Bai3 = 0;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhap so bao danh: ");
            SBD = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap diem bai 1: ");
            Bai1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem bai 2: ");
            Bai2 = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem bai 3: ");
            Bai3 = double.Parse(Console.ReadLine());
        }
        public virtual double TongDiem()
        {
            return Bai1 + Bai2 + Bai3;
        }
        public virtual void Xuat()
        {
            Console.WriteLine("SBD: " + SBD);
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Tong diem: " + TongDiem());
        }
    }

    // Thi sinh Chuyen
    public class ThiSinhChuyen : ThiSinh
    {
        public double TiengAnh { get; set; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap diem tieng Anh: ");
            TiengAnh = double.Parse(Console.ReadLine());
        }
        public override double TongDiem()
        {
            double tong = Bai1 + Bai2 + Bai3;
            if (TiengAnh >= 7 && TiengAnh <= 8)
            {
                tong += 1;
            }
            else if (TiengAnh >= 9 && TiengAnh <= 10)
            {
                tong += 2;
            }
            return tong;
        }
    }

    // Thi sinh Sieu cup
    public class ThiSinhSieuCup : ThiSinh
    {
        public double CSDL { get; set; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap diem CSDL: ");
            CSDL = double.Parse(Console.ReadLine());
        }

        public override double TongDiem()
        {
            return Bai1 + Bai2 + Bai3 + CSDL;
        }
    }
}
