using System;
using System.Collections.Generic;
using System.Text;

namespace TH01
{
    public class Bai6
    {
        public int a1 { get; set; }
        public int a2 { get; set; }
        public int a3 { get; set; }

        public int GiaTriLonNhat()
        {
            Console.Write("Nhap ba so a1, a2, a3: ");
            a1 = int.Parse(Console.ReadLine());
            a2 = int.Parse(Console.ReadLine());
            a3 = int.Parse(Console.ReadLine());
            if (a1 > a2 && a1 > a3)
            {
                return a1;
            }
            else if (a2 > a1 && a2 > a3)
            {
                return a2;
            }
            else if (a3 > a1 && a3 > a2)
            {
                return a3;
            }
            else
            {
                Console.WriteLine("Ba so bang nhau");
                return a1;
            }
        }
    }
}
