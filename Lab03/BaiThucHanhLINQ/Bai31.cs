using System;
using System.Collections.Generic;
using System.Linq;
namespace BaiThucHanhLINQ;

public static class Bai31
{
	public static int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };
	public static void Caua()
	{
	//Dem so phan tu
		int ketQuaa1 = mangSo.Count();
		Console.WriteLine("a) Tong so phan tu trong mang: " + ketQuaa1);
	//Dem so phan tu chan, le
		List <int> MangLe = new List<int>();
		List <int> MangChan = new List<int>();
		foreach (var x in mangSo)
		{
			if(x % 2 == 0)
			{
				MangChan.Add(x);
			}
			else
			{
				MangLe.Add(x);
			}
		}
		Console.WriteLine("Tong so phan tu chan: " + MangChan.Count());
		Console.WriteLine("Tong so phan tu le: " + MangLe.Count());
	}
    public static void Caub()
	{
	//Tong cac gia tri cua mang
		int ketQuab1 = mangSo.Sum();
		Console.WriteLine("b) Tong cac gia tri trong mang: " + ketQuab1);
	//Tim gia tri lon nhat
		Console.WriteLine("Gia tri lon nhat mang: " + mangSo.Max());
	//Tim gia tri nho nhat
		Console.WriteLine("Gia tri nho nhat mang: " + mangSo.Min());
	}
	public static void Cauc()
	{
		int ketQuac = mangSo.Distinct().Count();
		Console.Write("\nc) So gia tri khac nhau trong mang: " + ketQuac);
		Console.WriteLine();
	}
	public static void Caud()
	{
		Console.Write("\nd) Phan nhom phan tu theo so du khi chia cho 5");
		var ketQuad = mangSo.GroupBy(x => x % 5);
		{
			foreach(var g in ketQuad)
			{
				Console.Write("\nNhom phan tu chia 5 du " + g.Key + ": ");
				foreach(var x in g)
				{
					Console.Write(x + " ");
				}
			}
		}
	}
}