using System;
using System.Collections.Generic;
using System.Text;

namespace TH02
{
    //ConsoleMenu
    public class ConsoleMenu
    {
        public delegate void ChucNang(int x);
        public event ChucNang Choose;
        public void Run()
        {
            int x;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Giai phuong trinh bac 2");
                Console.WriteLine("2. Chuc nang 2");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.Write("Thuc hien: ");
                x = int.Parse(Console.ReadLine());
                if (x != 0)
                {
                    Choose?.Invoke(x);
                }
            } while (x != 0);
        }
    }

    //PTBac2Console ke thua ConsoleMenu
    public class PTBac2Console : ConsoleMenu
    {
        public void GiaiPTBac2()
        {
            Console.Write("Nhap a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine("x = " + x);
                }
                return;
            }
            //Tinh delta
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep x = " + x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
        }
    }
}
