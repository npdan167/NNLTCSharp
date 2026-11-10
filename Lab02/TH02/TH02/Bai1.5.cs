using System;
using System.Collections.Generic;
using System.Text;

namespace TH02
{
    public class DonThuc
    {
        public double a { get; set; }
        public int n { get; set; }
        public DonThuc()
        {
            a = 0;
            n = 0;
        }
        public DonThuc(double a, int n)
        {
            this.a = a;
            this.n = n;
        }

        public void Nhap()
        {
            Console.Write("Nhap a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"{a}x^{n}");
        }

        //(a) Tinh gia tri P(x)
        public double TinhGiaTri(double x)
        {
            return a * Math.Pow(x, n);
        }

        //(b) Dao ham
        public DonThuc DaoHam()
        {
            if (n == 0)
                return new DonThuc(0, 0);

            return new DonThuc(a * n, n - 1);
        }
    }
}
