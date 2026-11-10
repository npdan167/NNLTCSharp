using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNLTCS.BaiTap.XayDungLopHocSinh
{
    public class SoSanhHocSinh: IComparer<HocSinh>
    {

        public int Compare(HocSinh x, HocSinh y)
        {
            int diemx, diemy;
           
            if (x.DiemThi.HasValue)
            {
                diemx = x.DiemThi.Value;
            }
            else diemx = -1;

            if (y.DiemThi.HasValue)
            {
                diemy = y.DiemThi.Value;
            }
            else diemy = -1;

            return diemx.CompareTo(diemy);
        }
    }

    public class SoSanhHocSinhLopHoc : IComparer<HocSinh>
    {

        public int Compare(HocSinh x, HocSinh y)
        {
            return x.LopHoc.CompareTo(y.LopHoc);
        }
    }

    class Program
    {
        public static void Sort(IList list)
        {
            for(int i=0; i<=list.Count-2; i++)
            {
                for(int j=i+1; j<=list.Count-1; j++)
                {
                    IComparable ai = list[i] as IComparable;
                    IComparable aj = list[j] as IComparable;
                    if(ai.CompareTo(aj)>0)
                    {
                        object tmp = list[i];
                        list[i] = list[j];
                        list[j] = tmp;
                    }
                }
            }
        }
        public static void InHocSinh(HocSinh hs)
        {
            Console.WriteLine(hs);
        }

        public static void InSo(int ai)
        {
            Console.Write(ai+ " ");
        }
        public static int SoSanhNgaySinh(HocSinh x, HocSinh y)
        {
            if (!x.NgaySinh.HasValue && !y.NgaySinh.HasValue) return 0;
            if (!x.NgaySinh.HasValue && y.NgaySinh.HasValue) return -1;
            if (x.NgaySinh.HasValue && !y.NgaySinh.HasValue) return 1;
            return x.NgaySinh.Value.CompareTo(y.NgaySinh.Value);
        }

        static void Main(string[] args)
        {
            List<HocSinh> ds = new List<HocSinh>();
            ds.Add(new HocSinh("A", new DateTime(1990, 10, 2), "TH15", null));
            ds.Add(new HocSinh("C", new DateTime(1991, 10, 2), "TH14", 5));
            ds.Add(new HocSinh("B", new DateTime(1995, 10, 2), "TH12", 10));
            ds.Add(new HocSinh("E", new DateTime(1996, 10, 2), "TH15", 0));
            ds.Add(new HocSinh("D", null, "TH12", 2));
            ds.Add(new HocSinh("F", new DateTime(1994, 10, 2), "TH14", 4));

            Console.WriteLine(""); Console.WriteLine("");
            Array.ForEach<HocSinh>(ds.ToArray(), InHocSinh);

            

            Sort(ds);
            // ds.Sort();
            // ds.Sort(new SoSanhHocSinh());
            // ds.Sort(new SoSanhHocSinhLopHoc());
            // ds.Sort(SoSanhNgaySinh);
            // ds.Sort();

            Console.WriteLine(""); Console.WriteLine("");
            Array.ForEach<HocSinh>(ds.ToArray(), InHocSinh);

            int[] a = new int[5] { 1, 5, 2, 3, 4 };
            Array.ForEach<int>(a, InSo);
            Console.WriteLine(); Console.WriteLine();

            Sort(a);
            Array.ForEach<int>(a, InSo);
            Console.WriteLine(); Console.WriteLine();

        }
    }
}
