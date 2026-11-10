using System;
using System.Collections.Generic;
using System.Text;

namespace TH02
{
    public class SinhVien
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public int nam = DateTime.Now.Year;
        public void Nhap()
        {
            Console.Write("Ten sinh vien: ");
            HoTen = Console.ReadLine();
            Console.Write("Nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
        }
        public void Tuoi()
        {
            Console.WriteLine("\nTuoi sinh vien: " + (nam - NamSinh));
        }
    }
}
