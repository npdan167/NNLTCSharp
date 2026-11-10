<Query Kind="Program" />

void Main()
{
	Bai22.Caua();
	Bai22.Caub();
	Bai22.Cauc();
	Bai22.Caud();
}

public static class Bai22
{
	public static string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga", "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };
	public static void Caua()
	{
		Console.WriteLine("a)Phan tu co 4 ky tu va sap xep tang dan: ");
		var ketQuaa = mangChuoi
		.Where(x => x.Length == 4)
		.OrderBy(x => x);
		foreach (var x in ketQuaa)
		{
			Console.WriteLine(x);
		}
	}
	public static void Caub()
	{
		Console.WriteLine("\nb) Bien doi phan tu thanh dang: <chuthuong>-<CHUHOA>");
		var ketQuab = mangChuoi.Select(x => x.ToLower() + " - " + x.ToUpper());
		foreach (var x in ketQuab)
		{
			Console.WriteLine(x);
		}
	}
	public static void Cauc()
	{
		Console.WriteLine("\nc) Liet ke phan tu chua ky tu u ");
		var ketQuac = mangChuoi.Where(x => x.Contains("u"));
		foreach (var x in ketQuac)
		{
			Console.Write(x + " ");
		}
		Console.WriteLine();
	}
	public static void Caud()
	{
		Console.WriteLine("\nd) Liet ke cac tu Thuy Kieu Thuy Van bang cach chon cac phan tu bat dau bang chu in hoa");
		var ketQuad = mangChuoi.Where( x => char.IsUpper(x[0]));
		foreach (var x in ketQuad)
		{
			Console.Write(x + " ");
		}
	}
}
