using System;
using System.Collections.Generic;
using System.Text;

namespace TH01
{
    public class Bai5
    {
        public int choose { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public void Menu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1.Nhap hai gia tri so thuc cho x, y");
            Console.WriteLine("2.Tinh x^y");
            Console.WriteLine("3.Tinh can bac hai cua x va y");
            Console.WriteLine("4.Thoat");
            Console.Write("Chon chuc nang: ");
            choose = int.Parse(Console.ReadLine());

            if (choose == 1)
            {
                Bai3 bai3 = new Bai3();
                bai3.HamNhap();
                x = bai3.x;
                y = bai3.y;
                Console.WriteLine("\n");
                Menu();
            }
            else if (choose == 2)
            {
                Bai3 bai3 = new Bai3();
                bai3.x = x;
                bai3.y = y;
                bai3.HamMu();
                Console.WriteLine("\n");
                Menu();
            }
            else if (choose == 3)
            {
                Console.WriteLine("Can bac hai cua " + x + " la: " + Math.Sqrt(x));
                Console.WriteLine("Can bac hai cua " + y + " la: " + Math.Sqrt(y));
                Console.WriteLine("\n");
                Menu();
            }
            else if (choose == 4)
            {
                Console.WriteLine("\n");
                Menu();
            }
            else
            {
               
            }
        }
    }
}
