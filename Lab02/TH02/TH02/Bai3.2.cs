using System;
using System.Collections.Generic;
using System.Text;

namespace TH02
{
    public class Bai3_2
    {
        public static void Sort<T>(T[] a) where T : IComparable<T>
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i].CompareTo(a[j]) > 0)
                    {
                        T temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
    }
}