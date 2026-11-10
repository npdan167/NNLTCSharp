<Query Kind="Statements">
  <Reference Relative="BaiThucHanhLINQ\bin\Debug\net10.0\BaiThucHanhLINQ.dll">&lt;MyDocuments&gt;\HK1-26-27\C#\Lab03\BaiThucHanhLINQ\bin\Debug\net10.0\BaiThucHanhLINQ.dll</Reference>
</Query>

using BaiThucHanhLINQ;
var dsHe = DuLieu6.DS_He();
var dsMonHoc = DuLieu.DS_Mon();

//a
var ketQuaa = dsHe
    .Join(
        dsMonHoc,
        h => h.MaHe,
        m => m.He,
        (h, m) => new
        {
            TenHe = h.TenHe,
            MaMon = m.MaMon,
            TenMon = m.TenMon
        });
Console.WriteLine("a) Dung join de liet ke Ten he, Ten mon, Ma mon");
foreach (var x in ketQuaa)
{
    Console.WriteLine($"{x.TenHe}, {x.MaMon}, {x.TenMon}");
}

//b
var ketQuab = dsHe
    .GroupJoin(
        dsMonHoc,
        h => h.MaHe,
        m => m.He,
        (h, monHoc) => new
        {
            He = h,
            MonHoc = monHoc
        })
    .SelectMany(
        x => x.MonHoc.DefaultIfEmpty(),
        (x, m) => new
        {
            TenHe = x.He.TenHe,
            MaMon = m?.MaMon,
            TenMon = m?.TenMon
        });
Console.WriteLine("\nb) Liet ke ca nhung he chua co mon hoc");
foreach (var x in ketQuab)
{
    Console.WriteLine(
        $"{x.TenHe}, {x.MaMon}, {x.TenMon}");
}

//c
var leftJoin = dsHe
    .GroupJoin(
        dsMonHoc,
        h => h.MaHe,
        m => m.He,
        (h, monHoc) => new
        {
            He = h,
            MonHoc = monHoc
        })
    .SelectMany(
        x => x.MonHoc.DefaultIfEmpty(),
        (x, m) => new
        {
            MaHe = x.He.MaHe,
            TenHe = x.He.TenHe,
            MaMon = m?.MaMon,
            TenMon = m?.TenMon
        });
var rightJoin = dsMonHoc
    .GroupJoin(
        dsHe,
        m => m.He,
        h => h.MaHe,
        (m, he) => new
        {
            MonHoc = m,
            He = he
        })
    .SelectMany(
        x => x.He.DefaultIfEmpty(),
        (x, h) => new
        {
            MaHe = h?.MaHe,
            TenHe = h?.TenHe,
            MaMon = x.MonHoc.MaMon,
            TenMon = x.MonHoc.TenMon
        });
//Lay tat ca he
var ketQuac = leftJoin
    .Concat(
        rightJoin.Where(x => x.MaHe == null)
    );
Console.WriteLine("\nc) Liet ke ca he chua co mon hoc va mon hoc chua khai bao he");
foreach (var x in ketQuac)
{
    Console.WriteLine(
        $"{x.MaHe}, {x.TenHe}, {x.MaMon}, {x.TenMon}");
}

//d
//liet ke he chua co mon hoc
var heChuaCoMon = dsHe
    .GroupJoin(
        dsMonHoc,
        h => h.MaHe,
        m => m.He,
        (h, monHoc) => new
        {
            He = h,
            MonHoc = monHoc
        })
    .SelectMany(
        x => x.MonHoc.DefaultIfEmpty(),
        (x, m) => new
        {
            MaHe = x.He.MaHe,
            TenHe = x.He.TenHe,
            MaMon = m?.MaMon,
            TenMon = m?.TenMon
        })
    .Where(x => x.MaMon == null)
    .Select(x => new
    {
        MaHe = x.MaHe,
        TenHe = x.TenHe,
        MaMon = "",
        TenMon = ""
    });
//liet ke mon hoc chua khai bao he
var monChuaKhaiBaoHe = dsMonHoc
    .Where(m => string.IsNullOrEmpty(m.He))
    .Select(m => new
    {
        MaHe = "",
        TenHe = "",
        MaMon = m.MaMon,
        TenMon = m.TenMon
    });

//Gop 2 kqua
var ketQuad = heChuaCoMon
    .Concat(monChuaKhaiBaoHe);
Console.WriteLine("\nd) Chi liet ke he chua co mon hoc va mon hoc chua khai bao he");
foreach (var x in ketQuad)
{
    Console.WriteLine(
        $"{x.MaHe}, {x.TenHe}, {x.MaMon}, {x.TenMon}");
}

//e
var ketQuae = dsMonHoc
    .Join(
        dsHe,
        m => m.He,
        h => h.MaHe,
        (m, h) => new
        {
            TenHe = h.TenHe,
            MaMon = m.MaMon,
            TenMon = m.TenMon,
            SoTiet = m.SoTiet
        })
    .OrderByDescending(x => x.SoTiet)
    .Take(5);
Console.WriteLine("\ne) Lay 5 mon hoc dau tien co so tiet giam dan");
foreach (var x in ketQuae)
{
    Console.WriteLine(
        $"{x.TenHe}, {x.MaMon}, {x.TenMon}, {x.SoTiet} tiet");
}

//f
var ketQuaf = dsHe
    .GroupJoin(
        dsMonHoc,
        h => h.MaHe,
        m => m.He,
        (h, monHoc) => new
        {
            MaHe = h.MaHe,
            TenHe = h.TenHe,
            TongSoMon = monHoc.Count()
        });
Console.WriteLine("\nf) Tong so mon cua moi he");
foreach (var x in ketQuaf)
{
    Console.WriteLine(
        $"{x.MaHe}, {x.TenHe}, Tong so mon: {x.TongSoMon}");
}

//g
var ketQuag = dsMonHoc
    .Select(x => x.SoTiet)
    .Distinct()
    .Count();
Console.WriteLine($"\ng) Co {ketQuag} loai so tiet khac nhau");

//h
var ketQuah = dsMonHoc
    .First(x => x.TenMon.StartsWith("Lập trình"));
Console.WriteLine("\nh) Mon hoc dau tien co ten bat dau bang lap trinh");
Console.WriteLine($"{ketQuah.MaMon}, {ketQuah.TenMon}, {ketQuah.SoTiet} tiet");

//i
var ketQuai = dsMonHoc
    .GroupBy(x => x.He)
    .Select(g => new
    {
        MaHe = g.Key,
        MonHoc = g.Select((x, index) => new
        {
            STT = index + 1,
            MaMon = x.MaMon,
            TenMon = x.TenMon,
            SoTiet = x.SoTiet
        })
    });
Console.WriteLine("\ni) Liet ke cac mon theo tung he, danh so thu tu trong moi nhom");
foreach (var group in ketQuai)
{
    Console.WriteLine($"\nHe: {group.MaHe}");
    foreach (var x in group.MonHoc)
    {
        Console.WriteLine(
            $"{x.STT}. {x.MaMon}, {x.TenMon}, {x.SoTiet} tiet");
    }
}