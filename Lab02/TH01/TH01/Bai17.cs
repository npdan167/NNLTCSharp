using System;
using System.Collections.Generic;

namespace TH01
{
    public class Bai17
    {
        public void Mang()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap m: ");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            Random rd = new Random();
            List<int> mangChan = new List<int>();
            List<int> mangLe = new List<int>();

            // Tao mang
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rd.Next(10, 101);
                }
            }

            // In mang va tach chan le
            Console.WriteLine("Mang A:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                    if (a[i, j] % 2 == 0)
                    {
                        mangChan.Add(a[i, j]);
                    }
                    else
                    {
                        mangLe.Add(a[i, j]);
                    }
                }

                Console.WriteLine();
            }

            Console.Write("Mang so chan: ");
            foreach (int x in mangChan)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();

            Console.Write("Mang so le: ");
            foreach (int x in mangLe)
            {
                Console.Write(x + " ");
            }
        }
    }
}