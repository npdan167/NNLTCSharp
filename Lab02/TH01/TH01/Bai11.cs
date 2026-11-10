using System;
using System.Collections.Generic;
using System.Text;

namespace TH01
{
    public class Bai11
    {
        public string chuoi { get; set; }
        public string chuoidao = "";
        public void DaoChuoi()
        {
            Console.Write("Nhap chuoi: ");
            chuoi = Console.ReadLine();
            for (int i = chuoi.Length - 1; i >= 0; i--)
            {
                chuoidao = chuoidao + chuoi[i];
            }
            Console.WriteLine("Chuoi sau khi dao: " + chuoidao);
        }
    }
}