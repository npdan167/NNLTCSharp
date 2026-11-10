using System;
using System.Collections.Generic;
using System.Text;

namespace TH01
{
    public class Bai10
    {
        public string chuoi { get; set; }
        public void KiemTraChuoi()
        {
            Console.Write("Nhap chuoi: ");
            chuoi = Console.ReadLine();
            bool kq = true;
            for(int i = 0; i < chuoi.Length / 2; i++)
            {
                if (chuoi[i] != chuoi[chuoi.Length - 1 - i])
                {
                    kq = false;
                }
            }
            if (kq)
            {
                Console.WriteLine("Chuoi " + chuoi + " doi xung");
            }
            else
            {
                Console.WriteLine("Chuoi " + chuoi + " khong doi xung");
            }
        }
    }
}