using System;
using System.Collections.Generic;
using System.Text;

namespace TH01
{
    public class Bai3
    {
        public int x { get; set; }
        public int y { get; set; }

        public void HamNhap()
        {

            Console.Write("Nhap so nguyen x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen y: ");
            y = int.Parse(Console.ReadLine());

        }
        public void HamMu()
        {
            int result = 1;

            for (int i = 1; i <= y; i++)
            {
                result = result * x;
            }
            Console.Write("Ket qua " + x + " mu " + y + " la: " + result);
            Console.WriteLine();
        }
    }
}