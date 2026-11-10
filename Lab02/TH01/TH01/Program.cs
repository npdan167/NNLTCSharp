using TH01;
class Program
{
    public static void Main(string[] args)
    {
        // Nhap xuat co ban
        Console.WriteLine("Bai 2: ");
        Bai2 bai2 = new Bai2();
        bai2.InTen();

        Console.WriteLine("\nBai 3: ");
        Bai3 bai3 = new Bai3();
        bai3.HamNhap();
        bai3.HamMu();

        Console.WriteLine("\nBai 4: ");
        Bai4 bai4 = new Bai4();
        bai4.BaoLoi();

        Console.WriteLine("\nBai 5: ");
        Bai5 bai5 = new Bai5();
        bai5.Menu();

        //Viet phuong thuc 
        Console.WriteLine("\nBai 6: ");
        Bai6 bai6 = new Bai6();
        int max = bai6.GiaTriLonNhat();
        Console.WriteLine("Gia tri lon nhat la: " + max);

        Console.WriteLine("\nBai 7: ");
        Bai7 bai7 = new Bai7();
        bai7.KiemTraSoNguyenTo();

        Console.WriteLine("\nBai 8: ");
        Bai8 bai8 = new Bai8();
        bai8.NhapVaHoanVi();

        Console.WriteLine("\nBai 9: ");
        Bai9 bai9 = new Bai9();
        bai9.TimMaxMin();

        //Chuoi
        Console.WriteLine("\nBai 10: ");
        Bai10 bai10 = new Bai10();
        bai10.KiemTraChuoi();

        Console.WriteLine("\nBai 11: ");
        Bai11 bai11 = new Bai11();
        bai11.DaoChuoi();

        Console.WriteLine("\nBai 12: ");
        Bai12 bai12 = new Bai12();
        bai12.XuLyChuoi();

        //Xay dung lop co ban
        Console.WriteLine("\nBai 13: ");
        Bai13 bai13 = new Bai13();
        bai13.SinhVien();

        Console.WriteLine("\nBai 14: ");
        Bai14 bai14 = new Bai14();
        bai14.NhanVien();

        //Mang
        Console.WriteLine("\nBai 15: ");
        Bai15 bai15 = new Bai15();
        bai15.Mang();

        Console.WriteLine("\nBai 16: ");
        Bai16 bai16 = new Bai16();
        bai16.SapXepHoTen();

        Console.WriteLine("\nBai 17: ");
        Bai17 bai17 = new Bai17();
        bai17.Mang();
    }
}