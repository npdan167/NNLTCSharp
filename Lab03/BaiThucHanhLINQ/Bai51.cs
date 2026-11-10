using System;
using System.Collections.Generic;
using System.Linq;
namespace BaiThucHanhLINQ;

public static class Bai51
{
    public static void Caua()
    {
        var ds = DuLieu.DS_Mon();
		var ketQuaa = ds
        .Where(x => x.TenMon.StartsWith("Lập trình"))
        .Select(x => x.TenMon);
		Console.WriteLine("a) Cac mon bat dau bang lap trinh: ");
		foreach(var x in ketQuaa)
		{
			Console.WriteLine(x);
		}
    }
    public static void Caub()
    {
        var ds = DuLieu.DS_Mon();
        var ketQuab = ds
		.Where(x => x.He == "CD")
		.OrderByDescending(x => x.SoTiet)
		.ThenBy(x => x.MaMon);
		Console.WriteLine("\nb) Cac mon thuoc he CD, so tiet giam dan roi ma mon tang dan: ");
		foreach(var x in ketQuab)
		{
			Console.WriteLine($"{x.MaMon}, {x.TenMon}, {x.He}, {x.SoTiet}");
		}
    }
    public static void Cauc()
    {
        var ds = DuLieu.DS_Mon();
        var ketQuac = ds.Where(x => x.TenMon.Contains("Web"));
		Console.WriteLine("\nc) Cac mon co tu Web: ");
		foreach(var x in ketQuac)
		{
			Console.WriteLine($"{x.TenMon}, {x.He}");
		}
    }
    public static void Caud()
    {
        var ds = DuLieu.DS_Mon();
        var ketQuad = ds.Where(x => x.He == "KTV");
		Console.WriteLine("\nd) Cac mon he KTV, tang dan theo ma mon: ");
		foreach(var x in ketQuad)
		{
			Console.WriteLine($"{x.TenMon}, {x.MaMon}");
		}
    }
}