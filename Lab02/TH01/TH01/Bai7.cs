using System;
using System.Collections.Generic;
using System.Text;

namespace TH01
{
    public class Bai7
    {
        public int n { get; set; }
        public void KiemTraSoNguyenTo()
        {
            Console.Write("Nhap so nguyen n: ");
            n = int.Parse(Console.ReadLine());
            bool kq = true;
            if (n < 2)
            {
                kq = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        kq = false;
                    }
                }
            }
            if (kq)
            {
                Console.WriteLine(n + " la so nguyen to");
            }
            else
            {
                Console.WriteLine(n + " khong phai so nguyen to");
            }
        }
    }
}
