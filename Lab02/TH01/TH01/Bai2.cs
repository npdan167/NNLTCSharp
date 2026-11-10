using System;
using System.Collections.Generic;
using System.Text;

namespace TH01
{
    public class Bai2
    {
        public string name { get; set; }
        public void InTen()
        {
            Console.Write("Nhap ho ten cua ban: ");
            name = Console.ReadLine();
            Console.WriteLine("Chao ban " + name + "!");
        }
    }
}
