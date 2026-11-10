<Query Kind="Statements" />

public class He
{
    public string MaHe { get; set; } = "";
    public string TenHe { get; set; } = "";
}

public class DuLieu
{
    public List<He> DS_He()
    {
        return new List<He>
        {
            new He { MaHe = "KTV", TenHe = "Kỹ thuật viên" },
            new He { MaHe = "CD",  TenHe = "Chuyên đề" },
            new He { MaHe = "QT",  TenHe = "Chứng chỉ quốc tế" }
        };
    }
}