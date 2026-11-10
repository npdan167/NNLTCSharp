using System;

namespace TH01
{
    public class Bai8
    {
        public void HoanVi(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
        public void NhapVaHoanVi()
        {
            Console.Write("Nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Truoc khi hoan vi: a = " + a + ", b = " + b);
            HoanVi(ref a, ref b);
            Console.WriteLine("Sau khi hoan vi: a = " + a + ", b = " + b);
        }
    }
}