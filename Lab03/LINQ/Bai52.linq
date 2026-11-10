<Query Kind="Statements">
  <Reference Relative="BaiThucHanhLINQ\bin\Debug\net10.0\BaiThucHanhLINQ.dll">&lt;MyDocuments&gt;\HK1-26-27\C#\Lab03\BaiThucHanhLINQ\bin\Debug\net10.0\BaiThucHanhLINQ.dll</Reference>
</Query>

using BaiThucHanhLINQ;
var ds = DuLieu.DS_Mon();

	var ketQuaa = ds.Count;
	Console.WriteLine($"a) Tong so mon hien co: {ketQuaa}");
	
	var ketQuab = ds.Count(x => x.TenMon.StartsWith("Lập trình"));
	Console.WriteLine($"\nb) So mon bat dau bang Lap trinh: {ketQuab}");
	
	var ketQuac = ds.Where(x => x.He == "KTV")
	.Sum(x => x.SoTiet);
	Console.WriteLine($"\nc) Tong so tiet cua he KTV: {ketQuac}");
	
	var ketQuad = ds
    .GroupBy(x => x.He)
    .Select(g => new
    {
        He = g.Key,
        SoMon = g.Count()
    });
	Console.WriteLine("\nd) Tong so mon cua moi he: ");
	foreach (var x in ketQuad)
	{
    	Console.WriteLine($"{x.He}: {x.SoMon}");
	}
	
	var ketQuae = ds
	.GroupBy(x => x.SoTiet)
	.OrderByDescending(g => g.Key)
	.Select(g => new {SoTiet = g.Key, TongSoMon = g.Count()});
	Console.WriteLine("\ne) Nhom theo so tiet, in so tiet va tong so mon, sap xep so tiet giam dan");
	foreach(var x in ketQuae)
	{
		 Console.WriteLine($"{x.SoTiet}, {x.TongSoMon}");
	}
	
	var ketQuaf = ds
	.GroupBy(x => x.SoTiet)
	.OrderByDescending(g => g.Key)
	.First();
	Console.WriteLine("\nf) Thong tin mon hoc co so tiet cao nhat");
	foreach(var x in ketQuaf)
	{
		Console.WriteLine($"{x.MaMon}, {x.TenMon}, {x.SoTiet}");
	}
	
	var ketQuag = ds
    .GroupBy(x => x.He)
    .Select(g => new
    {
        He = g.Key,
        TongSoMon = g.Count(),
        TongSoTiet = g.Sum(x => x.SoTiet),
        SoTietCaoNhat = g.Max(x => x.SoTiet),
        SoTietThapNhat = g.Min(x => x.SoTiet)
    });
	Console.WriteLine("\ng) Thong ke theo He: ");
	foreach (var x in ketQuag)
	{
   		Console.WriteLine(
        	$"He: {x.He}, So mon: {x.TongSoMon}, " +
        	$"Tong tiet: {x.TongSoTiet}, " +
        	$"So tiet cao nhat: {x.SoTietCaoNhat}, " +
        	$"So tiet thap nhat: {x.SoTietThapNhat}");
	}
	
	var ketQuah = ds
    .GroupBy(x => x.He);
	Console.WriteLine("\nh) Liet ke cac mon hoc duoc phan nhom theo he");
	foreach (var g in ketQuah)
	{
    	Console.WriteLine($"\nHe: {g.Key}");
		foreach (var x in g)
    	{
        	Console.WriteLine($"{x.MaMon}, {x.TenMon}, {x.SoTiet}");
    	}
	}
	
	var ketQuai = ds
    .GroupBy(x => x.SoTiet)
    .OrderBy(g => g.Key);
	Console.WriteLine("\ni) Liet ke cac mon hoc duoc phan nhom theo so tiet");
	foreach (var g in ketQuai)
	{
    	Console.WriteLine($"\nSố tiết: {g.Key}");
    	foreach (var x in g)
    	{
        	Console.WriteLine($"{x.MaMon}, {x.TenMon}");
    	}
	}
	
	var ketQuaj = ds
    .Where(x => x.He == "KTV" &&
            (x.MaMon.StartsWith("HP2")||
            x.MaMon.StartsWith("HP3")||
            x.MaMon.StartsWith("HP4") ||
            x.MaMon.StartsWith("HP5")))
    .GroupBy(x => x.MaMon.Substring(0, 3));
	Console.WriteLine("\nj) Phan nhom theo hoc phan he KTV, sap xep theo ma mon");
	foreach (var g in ketQuaj)
	{
   		Console.WriteLine($"\nHoc phan: {g.Key}");
		foreach (var x in g.OrderBy(x => x.MaMon))
    	{
        	Console.WriteLine($"{x.MaMon}, {x.TenMon}");
    	}
	}
	
	var ketQuak = ds
    .Where(x => x.SoTiet > 40)
    .GroupBy(x => x.He);
	Console.WriteLine("\nk) Phan nhom theo He, lay so mon co So tiet > 40");
	foreach (var g in ketQuak)
	{
    	Console.WriteLine($"\nHệ: {g.Key}");
    	foreach (var x in g.OrderBy(x => x.MaMon))
    	{
        	Console.WriteLine($"{x.MaMon}, {x.TenMon}, {x.SoTiet}");
    	}
	}