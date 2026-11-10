using System;

namespace TH01
{
    public class Bai9
    {
        public void TimMaxMin(float a, float b, float c, out float max, out float min)
        {
            max = a;
            min = a;

            if (b > max)
                max = b;
            if (c > max)
                max = c;
            if (b < min)
                min = b;
            if (c < min)
                min = c;
        }

        public void TimMaxMin()
        {
            float a, b, c;
            float max, min;

            Console.Write("Nhap a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = float.Parse(Console.ReadLine());

            TimMaxMin(a, b, c, out max, out min);

            Console.WriteLine("Gia tri lon nhat: " + max);
            Console.WriteLine("Gia tri nho nhat: " + min);
        }
    }
}