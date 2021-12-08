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
            public string Ten;
            public short SoLuong;
            public bool TinhTrang; // true neu co hu hong, false neu khong hu hong
        };
        public struct DIENNUOC
        {
            public int SoDau, SoCuoi;
            public int ThanhTien;
        };
        public struct DV
        {
            public int[] LanSuDung; // LanSuDung[i] = so lan su dung dich vu i
            public double ThanhTien;
        };
        public struct NGUOI
        {
            public string HoTen;
            public string NgaySinh;
            public string GioiTinh;
            public string QueQuan;
            public string NgheNghiep;
            public string SDT;
        };
        // Methods
        // Ham lay Info noi that tu ban phim, xuat ra kieu cau truc NT
        public static NT GetNoiThat()
        {
            NT temp = new NT();
            Console.WriteLine("Tên nội thất: ");
            temp.Ten = Console.ReadLine();
            Console.WriteLine("Số lượng: ");
            temp.SoLuong = short.Parse(Console.ReadLine());
            Console.WriteLine("Tình trạng (Y = hư hỏng/N = bình thường): ");
            char key;
            key = char.Parse(Console.ReadLine());
            if (key == 'Y' || key == 'y')
                temp.TinhTrang = true;
            else
                temp.TinhTrang = false;
            return temp;
        }
        // Ham tinh tien nuoc, tham chieu vao gia tri temp kieu DIENNUOC
        public static int ThanhTienNuoc(DIENNUOC temp)
        {
            int SoKiNuoc = temp.SoCuoi - temp.SoDau;
            if (SoKiNuoc >= 10)
            {
                SoKiNuoc -= 10;
                temp.ThanhTien = 5973 * 10;
                if (SoKiNuoc >= 10)
                {
                    SoKiNuoc -= 10;
                    temp.ThanhTien = 10 * 7052;
                    if (SoKiNuoc >= 10)
                    {
                        SoKiNuoc -= 10;
                        temp.ThanhTien = 10 * 8669;
                        if (SoKiNuoc > 0)
                        {
                            temp.ThanhTien = SoKiNuoc * 15929;
                            SoKiNuoc = 0;
                        }
                    }
                    else
                    {
                        if (SoKiNuoc == 0)
                            return temp.ThanhTien;
                        temp.ThanhTien = SoKiNuoc * 8669;
                        SoKiNuoc = 0;
                    }
                }
                else
                {
                    if (SoKiNuoc == 0)
                        return temp.ThanhTien;
                    temp.ThanhTien = SoKiNuoc * 7052;
                    SoKiNuoc = 0;
                }
            }
            else
            {
                if (SoKiNuoc == 0)
                    return temp.ThanhTien;
                temp.ThanhTien = 5973 * SoKiNuoc;
                SoKiNuoc = 0;
            }
            return temp.ThanhTien;
        }
        // Ham tinh tien nuoc, tham chieu vao gia tri temp kieu DIENNUOC
        public static int ThanhTienDien(DIENNUOC temp)
        {
            int SoKiDien = temp.SoCuoi - temp.SoDau;

            if (SoKiDien >= 50)
            {
                SoKiDien -= 50;
                temp.ThanhTien = 1678 * 10;
                if (SoKiDien >= 50)
                {
                    SoKiDien -= 50;
                    temp.ThanhTien = 10 * 1734;
                    if (SoKiDien >= 100)
                    {
                        SoKiDien -= 100;
                        temp.ThanhTien = 10 * 2014;
                        if (SoKiDien >= 100)
                        {
                            SoKiDien -= 100;
                            temp.ThanhTien = 100 * 2536;
                            if (SoKiDien >= 100)
                            {
                                SoKiDien -= 100;
                                temp.ThanhTien = 100 * 2834;
                                if (SoKiDien > 0)
                                {
                                    temp.ThanhTien = SoKiDien * 2927;
                                    SoKiDien = 0;
                                }
                            }
                            else
                            {
                                if (SoKiDien == 0)
                                    return temp.ThanhTien;
                                temp.ThanhTien = SoKiDien * 2834;
                                SoKiDien = 0;
                            }
                        }
                        else
                        {
                            if (SoKiDien == 0)
                                return temp.ThanhTien;
                            temp.ThanhTien = SoKiDien * 2536;
                            SoKiDien = 0;
                        }
                    }
                    else
                    {
                        if (SoKiDien == 0)
                            return temp.ThanhTien;
                        temp.ThanhTien = SoKiDien * 2014;
                        SoKiDien = 0;
                    }
                }
                else
                {
                    if (SoKiDien == 0)
                        return temp.ThanhTien;
                    temp.ThanhTien = SoKiDien * 1734;
                    SoKiDien = 0;
                }
            }
            else
            {
                if (SoKiDien == 0)
                    return temp.ThanhTien;
                temp.ThanhTien = 1678 * SoKiDien;
                SoKiDien = 0;
            }
            return temp.ThanhTien;
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
    }
}
