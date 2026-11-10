using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TH01
{
    public class Bai13
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int Nam { get; set; }
        public void SinhVien()
        {
            //Nhap thong tin sv
            Console.Write("Nhap ma sinh vien: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap ho ten sinh vien: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap dia chi sinh vien: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap nam sinh vien: ");
            Nam = int.Parse(Console.ReadLine());

            //Xuat thong tin sv
            Console.WriteLine("\nMa sinh vien: " + MaSV);
            Console.WriteLine("Ho ten sinh vien: " + HoTen);
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.WriteLine("Sinh vien nam: " + Nam);
        }
        
    }
}
