<Query Kind="Program" />

void Main()
{
	Bai32.Caua();
	Bai32.Caub();
	Bai32.Cauc();
}

public static class Bai32
{
	public static string[] monAn = { "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì", "Nước Cà phê", "Mì quảng", "Cơm tấm", "Nước Chanh dây", "Mì xào", "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang" };
	public static void Caua()
	{
		Console.WriteLine("a) Phan tu co chieu dai dai nhat: " + monAn.MaxBy(x => x.Length));
		Console.WriteLine("Phan tu co chieu dai ngan nhat: " + monAn.MinBy(x => x.Length));
	}
	public static void Caub()
	{
		Console.Write("\nb) Phan nhom theo tu dau tien va liet ke phan tu tung nhom");
		var ketQuab = monAn.GroupBy(x => x[0]);
		foreach(var g in ketQuab)
		{
			Console.WriteLine("\nPhan nhom " + g.Key +  ": ");
			foreach(var x in g)
			{
				Console.WriteLine(x);
			}
		}
	}
	public static void Cauc()
	{
		var ketQuac = monAn.Where(x => x.StartsWith("Bánh"));
		Console.WriteLine("\nSo phan tu co tu dau tien la 'Bánh': " + ketQuac.Count());
		foreach(var x in ketQuac)
		{
			Console.WriteLine(x);
		}
	}
}
