<Query Kind="Statements">
  <Reference Relative="BaiThucHanhLINQ\bin\Debug\net10.0\BaiThucHanhLINQ.dll">&lt;MyDocuments&gt;\HK1-26-27\C#\Lab03\BaiThucHanhLINQ\bin\Debug\net10.0\BaiThucHanhLINQ.dll</Reference>
</Query>

using BaiThucHanhLINQ;
var ds = DuLieu.DS_Mon();

		var ketQuaa = ds
		.Where(x => x.TenMon.StartsWith("Lập trình"))
		.Select(x => x.TenMon);
		Console.WriteLine("a) Cac mon bat dau bang lap trinh: ");
		foreach(var x in ketQuaa)
		{
			Console.WriteLine(x);
		}
		
		var ketQuab = ds
		.Where(x => x.He == "CD")
		.OrderByDescending(x => x.SoTiet)
		.ThenBy(x => x.MaMon);
		Console.WriteLine("\nb) Cac mon thuoc he CD, so tiet giam dan roi ma mon tang dan: ");
		foreach(var x in ketQuab)
		{
			Console.WriteLine($"{x.MaMon}, {x.TenMon}, {x.He}, {x.SoTiet}");
		}
		
		var ketQuac = ds.Where(x => x.TenMon.Contains("Web"));
		Console.WriteLine("\nc) Cac mon co tu Web: ");
		foreach(var x in ketQuac)
		{
			Console.WriteLine($"{x.TenMon}, {x.He}");
		}
		
		var ketQuad = ds.Where(x => x.He == "KTV");
		Console.WriteLine("\nd) Cac mon he KTV, tang dan theo ma mon: ");
		foreach(var x in ketQuad)
		{
			Console.WriteLine($"{x.TenMon}, {x.MaMon}");
		}