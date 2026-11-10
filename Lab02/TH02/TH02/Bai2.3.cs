using System;
using System.Collections.Generic;
using System.Text;

namespace TH02
{
    public class DaySo
    {
        // Field
        public int[] a;
        //(a) Constructor mac nhien
        public DaySo()
        {
            a = new int[0];
        }
        // Constructor truyen tham so
        public DaySo(int n)
        {
            a = new int[n];
        }
        // Constructor sao chep
        public DaySo(DaySo d)
        {
            a = new int[d.a.Length];
            for (int i = 0; i < d.a.Length; i++)
            {
                a[i] = d.a[i];
            }
        }
        //(b) Indexer
        public int this[int i]
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
        //(c) Nhap, xuat day so
        public void Nhap()
        {
            Console.Write("Nhap mang a: ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        //(d) Tim so chan
        public void TimSoChan()
        {
            Console.Write("\nCac so chan: ");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write(a[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
