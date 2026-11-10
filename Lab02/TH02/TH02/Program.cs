using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection.Metadata;

namespace TH02
{
    class Program
    {
        public static void Main(string[] args)
        {
            //1.1
            Console.WriteLine("Bai 1.1");
            SinhVien sv = new SinhVien();
            sv.Nhap();
            sv.Tuoi();

            //1.2
            Console.WriteLine("\nBai 1.2");
            //Tao p1
            Point p1 = new Point();
            Console.WriteLine("Nhap diem p1:");
            p1.Input();

            //Tao p2
            Point p2 = new Point();
            Console.WriteLine("Nhap diem p2:");
            p2.Input();

            //ToString
            Console.WriteLine("Diem p1: " + p1.ToString());
            Console.WriteLine("Diem p2: " + p2.ToString());

            //Khoang cach_PTBinhThuong
            double kc1 = p1.KhoangCach(p2);
            Console.WriteLine("Khoang cach (phuong thuc binh thuong): " + kc1);

            //Khoang cach_PTTinh
            double kc2 = Point.TinhKhoangCach(p1, p2);
            Console.WriteLine("Khoang cach (phuong thuc tinh): " + kc2);

            //Trung diem
            Point p3 = p1.TrungDiem(p2);
            Console.WriteLine("Trung diem cua p1 va p2: " + p3);

            //1.3
            Console.WriteLine("\nBai 1.3");
            Person p = new Person();
            p.Input();
            p.Output();
            p.IsLiving();

            //1.4
            Console.WriteLine("\nBai 1.4");

            //Nhap phan so 1
            PhanSo ps = new PhanSo();
            Console.WriteLine("Nhap phan so 1:");
            ps.Nhap();

            //Nhap phan so 2
            PhanSo ps2 = new PhanSo();
            Console.WriteLine("Nhap phan so 2:");
            ps2.Nhap();

            //ToString
            Console.WriteLine("Phan so 1: " + ps);
            Console.WriteLine("Phan so 2: " + ps2);

            //Toan tu mot ngoi
            Console.WriteLine("+ps = " + (+ps));
            Console.WriteLine("-ps = " + (-ps));

            //Toan tu hai ngoi
            Console.WriteLine("ps1 + ps2 = " + (ps + ps2));
            Console.WriteLine("ps1 - ps2 = " + (ps - ps2));
            Console.WriteLine("ps1 * ps2 = " + (ps * ps2));
            Console.WriteLine("ps1 / ps2 = " + (ps / ps2));

            //Toan tu so sanh
            Console.WriteLine("ps1 > ps2: " + (ps > ps2));
            Console.WriteLine("ps1 < ps2: " + (ps < ps2));
            Console.WriteLine("ps1 >= ps2: " + (ps >= ps2));
            Console.WriteLine("ps1 <= ps2: " + (ps <= ps2));
            Console.WriteLine("ps1 == ps2: " + (ps == ps2));
            Console.WriteLine("ps1 != ps2: " + (ps != ps2));

            //1.5
            Console.WriteLine("\nBai 1.5");
            DonThuc dt = new DonThuc();
            dt.Nhap();
            Console.Write("Don thuc: ");
            dt.Xuat();

            //Tinh gia tri
            Console.Write("Nhap x: ");
            double x = double.Parse(Console.ReadLine());
            double kq = dt.TinhGiaTri(x);
            Console.WriteLine("Gia tri P(x) = " + kq);

            //Dao ham
            DonThuc daoHam = dt.DaoHam();
            Console.Write("Dao ham: ");
            daoHam.Xuat();

            //2.1
            Console.WriteLine("\nBai 2.1");
            ArrayPoint arr = new ArrayPoint();
            Point point1 = new Point(1, 2);
            Point point2 = new Point(3, 4);
            Point point3 = new Point(5, 6);
            arr.Them(point1);
            arr.Them(point2);
            arr.Them(point3);
            Console.WriteLine("Point thu 0: " + arr[0]);
            Console.WriteLine("Point thu 1: " + arr[1]);
            Console.WriteLine("Point thu 2: " + arr[2]);

            //2.2
            Console.WriteLine("\nBai 2.2");
            PersonList ds = new PersonList();
            ds.Input();
            Console.WriteLine("\nDanh sach:");
            ds.Output();
            PersonList dsSong = ds.LivingPeople();
            Console.WriteLine("\nDanh sach nguoi con song:");
            dsSong.Output();

            //2.3
            Console.WriteLine("\nBai 2.3");
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            DaySo dsso = new DaySo(n);
            dsso.Nhap();
            Console.Write("Day so: ");
            dsso.Xuat();
            dsso.TimSoChan();

            //2.4
            Console.WriteLine("\nBai 2.4");
            Console.Write("Nhap so dong n: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot m: ");
            int m2 = int.Parse(Console.ReadLine());
            Mang2Chieu mang = new Mang2Chieu(n2, m2);

            mang.Nhap();
            Console.WriteLine("Mang:");
            mang.Xuat();
            mang.TimSoNguyenTo();

            //2.5
            Console.WriteLine("\nBai 2.5");
            Console.Write("Nhap bac cua da thuc: ");
            int bac = int.Parse(Console.ReadLine());
            DaThuc dathuc = new DaThuc(bac);
            dathuc.Nhap();
            Console.Write("Da thuc: ");
            dathuc.Xuat();
            Console.Write("\nNhap x: ");
            double xdt = double.Parse(Console.ReadLine());

            double kqdt = dathuc.TinhGiaTri(xdt);
            Console.WriteLine("\nGia tri da thuc = " + kqdt);

            //2.6
            Console.WriteLine("\nBai 2.6");
            Console.Write("Nhap so luong phan so: ");
            int n3 = int.Parse(Console.ReadLine());
            DayPhanSo dsps = new DayPhanSo(n3);
            dsps.Nhap();
            Console.Write("Day phan so: ");
            dsps.Xuat();

            PhanSo tong = dsps.TinhTong();
            Console.Write("\nTong cac phan so: ");
            tong.Xuat();

            //2.7
            Console.WriteLine("\nBai 2.7");
            Console.Write("Nhap so luong nhan vien: ");
            int n4 = int.Parse(Console.ReadLine());
            PhongBan pb = new PhongBan(n4);
            pb.Nhap();
            pb.Xuat();

            //3.1
            Console.WriteLine("\nBai 3.1");

            SinhVien3[] a =
            {
                new SinhVien3("Nguyen Van A", 8),
                new SinhVien3("Tran Van B", 6),
                new SinhVien3("Le Van C", 9),
                new SinhVien3("Pham Van D", 7)
            };

            Array.Sort(a);
            Console.WriteLine("Sau khi sap xep: ");
            foreach (SinhVien3 sv3 in a)
            {
                sv3.Xuat();
            }

            //3.2
            Console.WriteLine("\nBai 3.2");

            int[] b = { 8, 6, 9, 7 };

            Bai3_2.Sort(b);

            Console.WriteLine("Sau khi sap xep: ");
            foreach (int x1 in b)
            {
                Console.Write(x1 + " ");
            }

            Console.WriteLine();

            //3.3
            Console.WriteLine("\nBai 3.3");

            int[] c = { 5, 2, 8, 1, 6 };

            Bai3_3.Sort(c);

            Console.WriteLine("Sau khi sap xep: ");
            foreach (int x2 in c)
            {
                Console.Write(x2 + " ");
            }

            Console.WriteLine();

            //3.4
            Console.WriteLine("\nBai 3.4");
            PTBac2Console app = new PTBac2Console();
            app.Choose += (x) =>
            {
                if (x == 1)
                {
                    app.GiaiPTBac2();
                }
                else
                {
                    Console.WriteLine("Chuc nang chua duoc cai dat!");
                }
            };
            app.Run();

            //3.5
            Console.WriteLine("\nBai 3.5");
            Console.Write("Nhap so luong nhan vien: ");
            int n5 = int.Parse(Console.ReadLine());
            NhanVien3_5[] dsNV = new NhanVien3_5[n5];
            for (int i = 0; i < n5; i++)
            {
                Console.WriteLine("\nNhan vien thu " + (i + 1));
                Console.WriteLine("1. Nhan vien kinh doanh");
                Console.WriteLine("2. Nhan vien san xuat");
                Console.Write("Chon: ");
                int loai = int.Parse(Console.ReadLine());
                if (loai == 1)
                    dsNV[i] = new NhanVienKinhDoanh();
                else
                    dsNV[i] = new NhanVienSanXuat();

                dsNV[i].Nhap();
            }

            Console.WriteLine("\nDanh sach nhan vien");
            foreach (NhanVien3_5 nv in dsNV)
            {
                nv.Xuat();
                Console.WriteLine();
            }

            //3.6
            Console.WriteLine("\nBai 3.6");
            Console.Write("Nhap so luong thi sinh: ");
            int n6 = int.Parse(Console.ReadLine());
            ThiSinh[] dsTS = new ThiSinh[n6];
            for (int i = 0; i < n6; i++)
            {
                Console.WriteLine("\nThi sinh thu " + (i + 1));
                Console.WriteLine("1. Thi sinh Chuyen");
                Console.WriteLine("2. Thi sinh Sieu cup");
                Console.Write("Chon: ");
                int loai = int.Parse(Console.ReadLine());
                if (loai == 1)
                    dsTS[i] = new ThiSinhChuyen();
                else
                    dsTS[i] = new ThiSinhSieuCup();
                dsTS[i].Nhap();
            }

            Console.WriteLine("\nKET QUA");
            foreach (ThiSinh ts in dsTS)
            {
                ts.Xuat();
                Console.WriteLine();
            }
        }
    }
}