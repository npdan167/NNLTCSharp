using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TH01
{
    public class Bai15
    {
        public int n { get; set; }
        public int[] a;
        public void Mang()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            n = int.Parse(Console.ReadLine());
            a = new int[n];

            Console.Write("Nhap mang: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Mang: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");

            }

            //Tim so lon nhat, nho nhat
            Console.WriteLine("\nPhan tu lon nhat mang: " + a.Max());
            Console.WriteLine("Phan tu nho nhat mang: " + a.Min());
            
            //Tim so nguyen to
            Console.Write("Cac so nguyen to trong mang: ");

            for (int i = 0; i < n; i++)
            {
                bool kq = true;

                if (a[i] < 2)
                {
                    kq = false;
                }
                else
                {
                    for (int j = 2; j <= Math.Sqrt(a[i]); j++)
                    {
                        if (a[i] % j == 0)
                        {
                            kq = false;
                        }
                    }
                }

                if (kq)
                {
                    Console.Write(a[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
