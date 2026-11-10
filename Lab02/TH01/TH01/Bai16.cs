using System;

namespace TH01
{
    public class Bai16
    {
        public void SapXepHoTen()
        {
            Console.Write("Nhap so nguoi: ");
            int n = int.Parse(Console.ReadLine());
            string[] a = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap ho ten nguoi: ");
                a[i] = Console.ReadLine();
            }
            Array.Sort(a);
            Console.WriteLine("\nDanh sach sap xep:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}