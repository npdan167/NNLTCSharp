using System;
using System.Collections.Generic;
using System.Text;

namespace TH01
{
    public class Bai4
    {
        public int x { get; set; }
        public int y { get; set; }
        public void BaoLoi()
        {
            int temp;
            Console.Write("Nhap so nguyen x: ");
            while (!int.TryParse(Console.ReadLine(), out temp))
            {
                Console.WriteLine("x khong phai la so nguyen!");
                Console.Write("Nhap so nguyen x: ");
            }
            x = temp;
            Console.Write("Nhap so nguyen y: ");
            while (!int.TryParse(Console.ReadLine(), out temp))
            {
                Console.WriteLine("y khong phai la so nguyen!");
                Console.Write("Nhap so nguyen y: ");
            }
            y = temp;
            Bai3 bai3 = new Bai3();
            bai3.x = x;
            bai3.y = y;
            bai3.HamMu();
        }
    }
}
