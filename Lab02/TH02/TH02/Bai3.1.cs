using System;
using System.Collections.Generic;
using System.Text;

namespace TH02
{
    public class SinhVien3 : IComparable<SinhVien3>
    {
        public string HoTen { get; set; }
        public double Diem { get; set; }
        public SinhVien3()
        {
            HoTen = "";
            Diem = 0;
        }
        public SinhVien3(string HoTen, double Diem)
        {
            this.HoTen = HoTen;
            this.Diem = Diem;
        }

        public void Xuat()
        {
            Console.WriteLine(HoTen + " - " + Diem);
        }
        //Sap xep
        public int CompareTo(SinhVien3 sv)
        {
            return Diem.CompareTo(sv.Diem);
        }
    }
}
