using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TH02
{
    public class Point
    {
        //Field, property
        public int x { get; set; }
        public int y { get; set; }

        //Constructor
        public Point(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        //Method
        public void Input()
        {
            Console.Write("Nhap x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = int.Parse(Console.ReadLine());
        }
        public virtual void Output()
        {
            Console.WriteLine($"({x}, {y})");
        }

        //Override
        public override string ToString()
        {
            return $"({x}, {y})";
        }

        //(a)
        //Phuong thuc binh thuong
        public double KhoangCach(Point p)
        {
            int dx = this.x - p.x;
            int dy = this.y - p.y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        //Phuong thuc tinh
        public static  double TinhKhoangCach(Point p1, Point p2)
        {
            int dx = p1.x - p2.x;
            int dy = p1.y - p2.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        //(b)
        //Phuong thuc binh thuong
        public Point TrungDiem(Point p)
        {
            int x = (this.x + p.x) / 2;
            int y = (this.y + p.y) / 2;
            return new Point(x, y);
        }
    }
}
