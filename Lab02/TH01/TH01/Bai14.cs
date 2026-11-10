using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TH01
{
    public class Bai14
    {
        public string HoTen { get; set; }
        public int MucLuong { get; set; }
        public int SoNgayVang { get; set; }
        public void NhanVien()
        {
            Console.Write("Ho ten nhan vien: ");
            HoTen = Console.ReadLine();
            Console.Write("Muc luong: ");
            MucLuong = int.Parse(Console.ReadLine());
            Console.Write("So ngay vang: ");
            SoNgayVang = int.Parse(Console.ReadLine());

            Console.WriteLine("\nLuong: " + (MucLuong - (SoNgayVang * 100000)));
        }
    }
}
