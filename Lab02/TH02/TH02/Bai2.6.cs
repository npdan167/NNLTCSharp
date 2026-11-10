using System;
using System.Collections.Generic;
using System.Text;

namespace TH02
{
    public class DayPhanSo
    {
        public PhanSo[] a;
        //Constructor
        public DayPhanSo()
        {
            a = new PhanSo[0];
        }
        public DayPhanSo(int n)
        {
            a = new PhanSo[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = new PhanSo();
            }
        }
        public DayPhanSo(DayPhanSo d)
        {
            a = new PhanSo[d.a.Length];
            for (int i = 0; i < d.a.Length; i++)
            {
                a[i] = new PhanSo(d.a[i]);
            }
        }
        //Indexer
        public PhanSo this[int i]
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
        //Nhap, xuat
        public void Nhap()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Nhap phan so: ");
                a[i].Nhap();
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                if (i < a.Length - 1)
                    Console.Write(" + ");
            }
        }
        // Tinh tong
        public PhanSo TinhTong()
        {
            PhanSo tong = new PhanSo(0, 1);
            for (int i = 0; i < a.Length; i++)
            {
                tong = tong + a[i];
            }
            return tong;
        }
    }
}