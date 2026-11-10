using System;
using System.Collections.Generic;
using System.Text;

namespace TH02
{
    public class Mang2Chieu
    {
        public int[,] a;

        //(a) Constructor
        public Mang2Chieu()
        {
            a = new int[0, 0];
        }
        public Mang2Chieu(int n, int m)
        {
            a = new int[n, m];
        }
        public Mang2Chieu(Mang2Chieu b)
        {
            int n = b.a.GetLength(0);
            int m = b.a.GetLength(1);
            a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = b.a[i, j];
                }
            }
        }
        //(b) Indexer
        public int this[int i, int j]
        {
            get
            {
                return a[i, j];
            }
            set
            {
                a[i, j] = value;
            }
        }

        //(c) Nhap, xuat mang
        public void Nhap()
        {
            Console.WriteLine("Nhap mang: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        //(d) Tim so nguyen to
        public bool LaSoNguyenTo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
        public void TimSoNguyenTo()
        {
            Console.Write("\nCac so nguyen to: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (LaSoNguyenTo(a[i, j]))
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}