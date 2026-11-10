using System;
using System.Collections.Generic;
using System.Text;

namespace TH02
{
    public class PhanSo
    {
        public int mau { get; set; }
        public int tu { get; set; }
        
        //Constructor mac nhien
        public PhanSo()
        {
            tu = 0;
            mau = 1;
        }
        //Constructor sao chep
        public PhanSo(PhanSo p)
        {
            tu = p.tu;
            mau = p.mau;
        }
        //Constructor truyen tham so
        public PhanSo(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }
        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            tu = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            mau = int.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine($"{tu}/{mau}");
        }
        public override string ToString()
        {
            return $"{tu}/{mau}";
        }
        //Toan tu mot ngoi
        //+p
        public static PhanSo operator +(PhanSo p)
        {
            return new PhanSo(p.tu, p.mau);
        }
        //-p
        public static PhanSo operator -(PhanSo p)
        {
            return new PhanSo(-p.tu, p.mau);
        }

        //Toan tu hai ngoi
        //p1 + p2
        public static PhanSo operator +(PhanSo p1, PhanSo p2)
        {
            return new PhanSo(
                p1.tu * p2.mau + p2.tu * p1.mau,
                p1.mau * p2.mau
            );
        }
        //p1 - p2
        public static PhanSo operator -(PhanSo p1, PhanSo p2)
        {
            return new PhanSo(
                p1.tu * p2.mau - p2.tu * p1.mau,
                p1.mau * p2.mau
            );
        }
        //p1 * p2
        public static PhanSo operator *(PhanSo p1, PhanSo p2)
        {
            return new PhanSo(
                p1.tu * p2.tu,
                p1.mau * p2.mau
            );
        }
        //p1 / p2
        public static PhanSo operator /(PhanSo p1, PhanSo p2)
        {
            return new PhanSo(
                p1.tu * p2.mau,
                p1.mau * p2.tu
            );
        }

        //Toan tu so sanh
        //>
        public static bool operator >(PhanSo p1, PhanSo p2)
        {
            return p1.tu * p2.mau > p2.tu * p1.mau;
        }
        //<
        public static bool operator <(PhanSo p1, PhanSo p2)
        {
            return p1.tu * p2.mau < p2.tu * p1.mau;
        }
        //>=
        public static bool operator >=(PhanSo p1, PhanSo p2)
        {
            return p1.tu * p2.mau >= p2.tu * p1.mau;
        }
        //<=
        public static bool operator <=(PhanSo p1, PhanSo p2)
        {
            return p1.tu * p2.mau <= p2.tu * p1.mau;
        }
        //==
        public static bool operator ==(PhanSo p1, PhanSo p2)
        {
            return p1.tu * p2.mau == p2.tu * p1.mau;
        }
        //!=
        public static bool operator !=(PhanSo p1, PhanSo p2)
        {
            return p1.tu * p2.mau != p2.tu * p1.mau;
        }
    }
}
