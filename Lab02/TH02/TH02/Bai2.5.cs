using System;
using System.Collections.Generic;
using System.Text;

namespace TH02
{
    public class DaThuc
    {
        public DonThuc[] a;

        //(a) Constructor
        public DaThuc()
        {
            a = new DonThuc[0];
        }
        // n la bac cua da thuc -> co n + 1 don thuc
        public DaThuc(int n)
        {
            a = new DonThuc[n + 1];
            for (int i = 0; i <= n; i++)
            {
                a[i] = new DonThuc(0, i);
            }
        }
        public DaThuc(DaThuc p)
        {
            a = new DonThuc[p.a.Length];
            for (int i = 0; i < p.a.Length; i++)
            {
                a[i] = new DonThuc(p.a[i].a, p.a[i].n);
            }
        }

        //(b) Indexer
        public DonThuc this[int i]
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

        //(c) Nhap, xuat
        public void Nhap()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap he so a: ");
                double hs = double.Parse(Console.ReadLine());
                a[i] = new DonThuc(hs, i);
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (i > 0)
                    Console.Write(" + ");
                Console.Write(a[i].a + "x^" + a[i].n);
            }
        }

        //(d) Tinh gia tri da thuc
        public double TinhGiaTri(double x)
        {
            double tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                tong += a[i].TinhGiaTri(x);
            }
            return tong;
        }
    }
}
