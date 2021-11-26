using KTX_Management.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTX_Management
{
    // Lop chua cac cau truc du lieu chung
    public class CAUTRUC
    {
        // Fields
        public struct VT
        {
            public short Tang;
            public string Khu;
        };
        public struct NT
        {
            public short SoLuongNT;
            public struct PHANLOAI
            {
                public string Ten;
                public short SoLuong;
                public bool TinhTrang; // true neu co hu hong, false neu khong hu hong
            };
            public PHANLOAI[] PhanLoai; // cau truc mang struct PHANLOAI
        };
        public struct DIENNUOC
        {
            public int SoDau, SoCuoi;
            public double ThanhTien;
        };
        public struct DV
        {
            public int[] LanSuDung; // LanSuDung[i] = so lan su dung dich vu i
            public double ThanhTien;
        };
        public struct DATE
        {
            public short Ngay;
            public short Thang;
            public short Nam;
        };
        public struct NGUOI
        {
            public string HoTen;
            public DATE NgaySinh;
            public bool GioiTinh;
            public string QueQuan;
            public string NgheNghiep;
            public string SDT;
        };
        // Methods
        // Ham lay Info vi tri tu ban phim, xuat ra kieu cau truc VT
        public static VT GetViTri()
        {
            VT temp = new VT();
            Console.WriteLine("Nhap khu vuc cua phong: ");
            temp.Khu = Console.ReadLine();
            Console.WriteLine("Nhap tang cua phong: ");
            temp.Tang = short.Parse(Console.ReadLine());
            return temp;
        }
        // Ham lay Info noi that tu ban phim, xuat ra kieu cau truc NT
        public static NT GetNoiThat()
        {
            NT temp = new NT();
            Console.WriteLine("Nhap so luong noi that co san cua phong: ");
            temp.SoLuongNT = short.Parse(Console.ReadLine());
            temp.PhanLoai = new NT.PHANLOAI[temp.SoLuongNT];
            for (int i = 0; i < temp.SoLuongNT; i++)
            {
                Console.WriteLine("Ten noi that: ");
                temp.PhanLoai[i].Ten = Console.ReadLine();
                Console.WriteLine("So luong noi that do: ");
                temp.PhanLoai[i].SoLuong = short.Parse(Console.ReadLine());
                Console.WriteLine("Co noi that hu hong (Y/N): ");
                char key;
                key = char.Parse(Console.ReadLine());
                if (key == 'Y' || key == 'y')
                    temp.PhanLoai[i].TinhTrang = true;
                else
                    temp.PhanLoai[i].TinhTrang = false;
            }
            return temp;
        }
        // Ham lay Info nuoc tu ban phim, xuat ra kieu cau truc DIENNUOC
        public static DIENNUOC GetDienNuoc()
        {
            DIENNUOC temp = new DIENNUOC();
            Console.WriteLine("Nhap so dau: ");
            temp.SoDau = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cuoi: ");
            temp.SoCuoi = int.Parse(Console.ReadLine());
            return temp;
        }
        // Ham tinh tien nuoc, tham chieu vao gia tri temp kieu DIENNUOC
        public static void ThanhTienNuoc(ref DIENNUOC temp)
        {
            int SoKiNuoc = temp.SoCuoi - temp.SoDau;

            if (SoKiNuoc >= 10)
            {
                SoKiNuoc -= 10;
                temp.ThanhTien = 5.973 * 10;
                if (SoKiNuoc >= 10)
                {
                    SoKiNuoc -= 10;
                    temp.ThanhTien = 10 * 7.052;
                    if (SoKiNuoc >= 10)
                    {
                        SoKiNuoc -= 10;
                        temp.ThanhTien = 10 * 8.669;
                        if (SoKiNuoc > 0)
                        {
                            temp.ThanhTien = SoKiNuoc * 15.929;
                            SoKiNuoc = 0;
                        }
                    }
                    else
                    {
                        temp.ThanhTien = SoKiNuoc * 8.669;
                        SoKiNuoc = 0;
                    }
                }
                else
                {
                    temp.ThanhTien = SoKiNuoc * 7.052;
                    SoKiNuoc = 0;
                }
            }
            else
            {
                temp.ThanhTien = 5.973 * SoKiNuoc;
                SoKiNuoc = 0;
            }
        }
        // Ham tinh tien nuoc, tham chieu vao gia tri temp kieu DIENNUOC
        public static void ThanhTienDien(ref DIENNUOC temp)
        {
            int SoKiDien = temp.SoCuoi - temp.SoDau;

            if (SoKiDien >= 50)
            {
                SoKiDien -= 50;
                temp.ThanhTien = 1.678 * 10;
                if (SoKiDien >= 50)
                {
                    SoKiDien -= 50;
                    temp.ThanhTien = 10 * 1.734;
                    if (SoKiDien >= 100)
                    {
                        SoKiDien -= 100;
                        temp.ThanhTien = 10 * 2.014;
                        if (SoKiDien >= 100)
                        {
                            SoKiDien -= 100;
                            temp.ThanhTien = 100 * 2.536;
                            if (SoKiDien >= 100)
                            {
                                SoKiDien -= 100;
                                temp.ThanhTien = 100 * 2.834;
                                if (SoKiDien >= 1)
                                {
                                    temp.ThanhTien = SoKiDien * 2.927;
                                    SoKiDien = 0;
                                }
                            }
                            else
                            {
                                temp.ThanhTien = SoKiDien * 2.834;
                                SoKiDien = 0;
                            }
                        }
                        else
                        {
                            temp.ThanhTien = SoKiDien * 2.536;
                            SoKiDien = 0;
                        }
                    }
                    else
                    {
                        temp.ThanhTien = SoKiDien * 2.014;
                        SoKiDien = 0;
                    }
                }
                else
                {
                    temp.ThanhTien = SoKiDien * 1.734;
                    SoKiDien = 0;
                }
            }
            else
            {
                temp.ThanhTien = 1.678 * SoKiDien;
                SoKiDien = 0;
            }
        }
        // Ham lay Info dich tu ban phim, xuat ra kieu cau truc DV
        public static DV GetDV(bool LoaiDV)
        {
            DV temp = new DV();
            char key;
            if (LoaiDV == true) // LoaiDV=true se la dich vu chung, false se la dich vu ca nhan
            {
                Console.WriteLine("Su dung Wifi chung thang nay (Y/N): ");
                key = char.Parse(Console.ReadLine());
                if (key == 'Y' || key == 'y')
                    temp.LanSuDung[0] = 1;
                else
                    temp.LanSuDung[0] = 0;
                Console.WriteLine("Nhap so lan su dung Suc chua noi that: "); // Sua chua noi that
                temp.LanSuDung[1] = int.Parse(Console.ReadLine());
                temp.ThanhTien = temp.LanSuDung[0] * DICHVU.DVChung.GiaDV1 + temp.LanSuDung[1] * DICHVU.DVChung.GiaDV2;
            }
            else
            {
                Console.WriteLine("Nhap so lan su dung Giat xa: ");
                temp.LanSuDung[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("Su dung Gui xe thang nay (Y/N): ");
                key = char.Parse(Console.ReadLine());
                if (key == 'Y' || key == 'y')
                    temp.LanSuDung[1] = 1;
                else
                    temp.LanSuDung[1] = 0;
                Console.WriteLine("Su dung Wifi ca nhan thang nay (Y/N): ");
                key = char.Parse(Console.ReadLine());
                if (key == 'Y' || key == 'y')
                    temp.LanSuDung[0] = 1;
                else
                    temp.LanSuDung[0] = 0;
                temp.ThanhTien = temp.LanSuDung[0] * DICHVU.DVCaNhan.GiaDV1 + temp.LanSuDung[1] * DICHVU.DVCaNhan.GiaDV2 + temp.LanSuDung[2] * DICHVU.DVCaNhan.GiaDV3;
            }
            return temp;
        }
        // Ham xuat Info ngay thang nam len console
        public static void TakeDate(DATE temp)
        {
            if (temp.Ngay <= 9)
                Console.Write("0" + temp.Ngay + "/");
            else
                Console.Write(temp.Ngay + "/");
            if (temp.Thang <= 9)
                Console.Write("0" + temp.Thang + "/");
            else
                Console.Write(temp.Thang + "/");
            Console.Write(temp.Nam);
        }
        // Ham xuat Info kieu cau truc NGUOI len console
        public static void TakeInfoNguoi(NGUOI temp)
        {
            Console.WriteLine("Ho ten: ", temp.HoTen);
            Console.WriteLine("Gioi tinh: ");
            if (temp.GioiTinh)
                Console.Write("Nam");
            else
                Console.Write("Nu");
            Console.WriteLine("Ngay sinh: ");
            TakeDate(temp.NgaySinh);
            Console.WriteLine("Que quan: ", temp.QueQuan);
            Console.WriteLine("Nghe nghiep: ", temp.NgheNghiep);
            Console.WriteLine("SDT: ", temp.SDT);
        }
    }
}
