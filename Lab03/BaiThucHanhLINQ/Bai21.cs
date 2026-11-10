using System;
using System.Collections.Generic;
using System.Linq;
namespace BaiThucHanhLINQ;

public static class Bai21
{
	public static int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };
	public static void Caua()
	{
		Console.Write("a) Cac so chia het cho 3: ");
		var ketQuaa1 = mangSo.Where(x => x % 3 == 0);
		foreach (var x in ketQuaa1)
		{
			Console.Write(x + " ");
		}
		Console.Write("\nCac so chia het cho 4: ");
		var ketQuaa2 = mangSo.Where(x => x % 4 == 0);
		foreach (var x in ketQuaa2)
		{
			Console.Write(x + " ");
		}
	}
	public static void Caub()
	{
		Console.Write("\nb) Cac so nho hon hoac bang 3: ");
		var ketQuab = mangSo.Where(x => x <= 3);
		foreach (var x in ketQuab)
		{
		Console.Write(x + " ");
		}
	}
	public static void Cauc()
	{
		Console.Write("\nc) Day moi: ");
		List<int> Mangc = new List<int>();
		foreach(var x in mangSo)
		{
			if( x % 2 == 0)
		 	{
		 		Mangc.Add(x / 2);
		 	}
			else
			{
				Mangc.Add(x);
			}
		}
		foreach(var x in Mangc)
		{
			Console.Write(x + " ");
		}
	}
}
