using System;
using System.Collections.Generic;
using System.Text;

namespace TH01
{
    public class Bai12
    {
        public string chuoi { get; set; }
        public void XuLyChuoi()
        {
            Console.Write("Nhap chuoi: ");
            chuoi = Console.ReadLine();
            //chuoi khong sua tung ky tu, dung string builder
            StringBuilder sb = new StringBuilder(chuoi);

            for(int i = 0; i < sb.Length; i++)
            {
                sb[i] = char.ToUpper(sb[i]);
            }
            Console.WriteLine("Chuoi in hoa: " + sb);
            for(int i = 0; i < sb.Length; i++)
            {
                sb[i] = char.ToLower(sb[i]);
            }
            Console.WriteLine("Chuoi in thuong: " + sb);
            Console.WriteLine("Do dai chuoi: " + sb.Length);
        }
    }
}