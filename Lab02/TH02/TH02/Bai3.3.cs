using System;

namespace TH02
{
    public class Bai3_3
    {
        public delegate int SoSanh<T>(T a, T b);
        public static void Sort<T>(T[] a, SoSanh<T> ss)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (ss(a[i], a[j]) > 0)
                    {
                        T temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        public static void Sort(int[] a)
        {
            Sort(a, (x, y) => x.CompareTo(y));
        }
    }
}