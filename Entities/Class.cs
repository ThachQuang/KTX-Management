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

    class PHONG
    {
        // Fields
        private int IDPhong;
        private string TenPhong;
        private CAUTRUC.VT ViTri;
        private short SucChuaNguoi;
        private short SoNguoiHienTai;
        private CAUTRUC.NT NoiThat;
        private double DienTich;
        private double GiaThue;
        private CAUTRUC.DIENNUOC Dien;
        private CAUTRUC.DIENNUOC Nuoc;
        private CAUTRUC.DV DichVuPhong;
        private double TongThuThang;
        // Constructors
        // Khong tham so
        public PHONG()
        {

        }
        // 7 tham so
        public PHONG(int IDPhong,
                     string TenPhong,
                     CAUTRUC.VT ViTri,
                     short SucChuaNguoi,
                     short SoNguoiHienTai,
                     double DienTich,
                     double GiaThue)
        {
            this.IDPhong = IDPhong;
            this.TenPhong = TenPhong;
            this.ViTri = ViTri;
            this.SucChuaNguoi = SucChuaNguoi;
            this.SoNguoiHienTai = SoNguoiHienTai;
            this.DienTich = DienTich;
            this.GiaThue = GiaThue;
        }
        // Methods
        // Take: lay va xuat thong tin len console
        // Get: lay va luu thong tin vao data
        // Ham ve Info phong
        public void TakeInfoPhong()
        {
            Console.WriteLine("ID phong: ", this.IDPhong);
            Console.WriteLine("Ten phong: ", this.TenPhong);
            Console.WriteLine("Khu: ", this.ViTri.Khu);
            Console.WriteLine("Tang: ", this.ViTri.Tang);
            Console.WriteLine("Loai phong: " + this.SucChuaNguoi + " nguoi");
            Console.WriteLine("So nguoi tam tru: ", this.SoNguoiHienTai);
            Console.WriteLine("Dien tich phong: " + this.DienTich + "m3");
            Console.WriteLine("Gia thue hang thang: ", this.GiaThue);
        }
        public void GetInfoPhong(int IDPhong,
                                 string TenPhong,
                                 CAUTRUC.VT ViTri,
                                 short SucChuaNguoi,
                                 short SoNguoiHienTai,
                                 double DienTich,
                                 double GiaThue)
        {
            this.IDPhong = IDPhong;
            this.TenPhong = TenPhong;
            this.ViTri = ViTri;
            this.SucChuaNguoi = SucChuaNguoi;
            this.SoNguoiHienTai = SoNguoiHienTai;
            this.DienTich = DienTich;
            this.GiaThue = GiaThue;
        }
        // Ham ve Info noi that
        public void TakeInfoNT()
        {
            Console.WriteLine("Thong tin noi that co san cua phong!");
            for (int i = 0; i < this.NoiThat.SoLuongNT; i++)
            {
                Console.WriteLine("Ten loai noi that: ", this.NoiThat.PhanLoai[i].Ten);
                Console.WriteLine("So luong: ", this.NoiThat.PhanLoai[i].SoLuong);
                Console.Write("Tinh trang hong hoc: ");
                if (this.NoiThat.PhanLoai[i].TinhTrang)
                    Console.WriteLine("Co hong hoc");
                else
                    Console.WriteLine("Khong hong hoc");
            }
        }
        public void GetInfoNT()
        {
            this.NoiThat = new CAUTRUC.NT();
            this.NoiThat = CAUTRUC.GetNoiThat();
        }
        // Ham ve Info dien
        public void TakeInfoDien()
        {
            Console.WriteLine("So ki dien thang truoc: " + this.Dien.SoDau + "kWh");
            Console.WriteLine("So ki dien thang nay: " + this.Dien.SoCuoi + "kWh");
            Console.WriteLine("Tong so ki dien da dung: " + (this.Dien.SoCuoi - this.Dien.SoDau) + "kWh");
            CAUTRUC.ThanhTienDien(ref this.Dien);
            Console.WriteLine("Thanh tien dien thang nay: " + this.Dien.ThanhTien + "d");
        }
        public void GetInfoDien()
        {
            this.Dien = new CAUTRUC.DIENNUOC();
            this.Dien = CAUTRUC.GetDienNuoc();
        }
        // Ham ve Info nuoc
        public void TakeInfoNuoc()
        {
            Console.WriteLine("So ki nuoc thang truoc: " + this.Nuoc.SoDau + "m3");
            Console.WriteLine("So ki nuoc thang nay: " + this.Nuoc.SoCuoi + "m3");
            Console.WriteLine("Tong so ki nuoc da dung: " + (this.Nuoc.SoCuoi - this.Nuoc.SoDau) + "m3");
            CAUTRUC.ThanhTienNuoc(ref this.Nuoc);
            Console.WriteLine("Thanh tien nuoc thang nay: " + this.Nuoc.ThanhTien + "d");
        }
        public void GetInfoNuoc()
        {
            this.Nuoc = new CAUTRUC.DIENNUOC();
            this.Nuoc = CAUTRUC.GetDienNuoc();
        }
        // Ham ve Info dich vu phong hang thang
        public void TakeInfoDV()
        {
            Console.WriteLine("Cac dich vu phong cua thang nay:");
            Console.Write("+ WiFi chung: ");
            if (this.DichVuPhong.LanSuDung[0] != 0)
                Console.WriteLine("Co su dung");
            else
                Console.WriteLine("Khong su dung");
            Console.WriteLine("+ Sua chua noi that: " + this.DichVuPhong.LanSuDung[1] + " lan");
            Console.WriteLine("Thanh tien dich vu: " + this.DichVuPhong.ThanhTien + "d");
        }
        public void GetInfoDV()
        {
            this.DichVuPhong = new CAUTRUC.DV();
            this.DichVuPhong = CAUTRUC.GetDV(true);
        }
        // Ham ve Info phi thu hang thang
        public void TakeInfoPhi()
        {
            Console.WriteLine("Thu phi phong thang nay: " + this.TongThuThang + "d");
        }
        public void GetInfoPhi()
        {
            this.TongThuThang = 0;
            this.TongThuThang = this.GiaThue + this.Dien.ThanhTien + this.Nuoc.ThanhTien + this.DichVuPhong.ThanhTien;
        }
    }

    class SINHVIEN
    {
        // Fields
        private int IDPhong;
        private CAUTRUC.NGUOI SinhVien;
        private string CMND;
        private string BHYT;
        private string NoiLamViec;
        private string DiaChiHK;
        private short SVNam;
        private CAUTRUC.NGUOI PhuHuynh1, PhuHuynh2;
        private CAUTRUC.DATE HopDongStart, HopDongEnd;
        private CAUTRUC.DV DichVuCaNhan;
        private short LanViPham;
        private string[] LyDoVP = new string[5];
        // Constructors
        // Khong tham so
        public SINHVIEN()
        {
        }
        // 10 tham so
        public SINHVIEN(int IDPhong,
                        CAUTRUC.NGUOI SinhVien,
                        string CMND,
                        string BHYT,
                        string NoiLamViec,
                        string DiaChiHK,
                        short SVNam,
                        CAUTRUC.NGUOI PhuHuynh1,
                        CAUTRUC.NGUOI PhuHuynh2,
                        CAUTRUC.DATE HopDongStart,
                        CAUTRUC.DATE HopDongEnd)
        {
            this.IDPhong = IDPhong;
            this.SinhVien = SinhVien;
            this.CMND = CMND;
            this.BHYT = BHYT;
            this.NoiLamViec = NoiLamViec;
            this.DiaChiHK = DiaChiHK;
            this.SVNam = SVNam;
            this.PhuHuynh1 = PhuHuynh1;
            this.PhuHuynh2 = PhuHuynh2;
            this.HopDongStart = HopDongStart;
            this.HopDongEnd = HopDongEnd;
        }
        // Methods
        // Take: lay va xuat thong tin len console
        // Get: lay va luu thong tin vao data
        // Ham ve Info sinh vien
        public void TakeInfoSV()
        {
            Console.WriteLine("Thong tin sinh vien!");
            Console.WriteLine("ID phong hien tai: ", this.IDPhong);
            CAUTRUC.TakeInfoNguoi(this.SinhVien);
            Console.WriteLine("CMND: ", this.CMND);
            Console.WriteLine("Dia chi ho khau: ", this.DiaChiHK);
            Console.Write("BHYT: ");
            if (BHYT == null)
                Console.WriteLine("Khong co");
            else
                Console.WriteLine(this.BHYT);
            Console.WriteLine("Noi lam viec: ", this.NoiLamViec);
            Console.WriteLine("Sinh vien nam thu: ", this.SVNam);
        }
        public void GetInfoSV(int IDPhong,
                              CAUTRUC.NGUOI SinhVien,
                              string CMND,
                              string BHYT,
                              string NoiLamViec,
                              string DiaChiHK,
                              short SVNam)
        {
            this.IDPhong = IDPhong;
            this.SinhVien = SinhVien;
            this.CMND = CMND;
            this.BHYT = BHYT;
            this.NoiLamViec = NoiLamViec;
            this.DiaChiHK = DiaChiHK;
            this.SVNam = SVNam;
        }
        // Ham ve Info hop dong
        public void TakeInfoHD()
        {
            Console.WriteLine("Ngay ki hop dong: ");
            CAUTRUC.TakeDate(this.HopDongStart);
            Console.WriteLine("Ngay het han hop dong: ");
            CAUTRUC.TakeDate(this.HopDongEnd);
        }
        public void GetInfoHD(CAUTRUC.DATE HopDongStart, CAUTRUC.DATE HopDongEnd)
        {
            this.HopDongStart = HopDongStart;
            this.HopDongEnd = HopDongEnd;
        }
        // Ham ve Info phu huynh, nguoi bao ho
        public void TakeInfoPH()
        {
            CAUTRUC.TakeInfoNguoi(PhuHuynh1);
            CAUTRUC.TakeInfoNguoi(PhuHuynh2);
        }
        public void GetInfoPH(CAUTRUC.NGUOI PhuHuynh1, CAUTRUC.NGUOI PhuHuynh2)
        {
            this.PhuHuynh1 = PhuHuynh1;
            this.PhuHuynh2 = PhuHuynh2;
        }
        // Ham ve Info vi pham, nhac nho
        public void TakeInfoVP()
        {
            Console.WriteLine("Vi pham: " + this.LanViPham + " lan!");
            for (int i = 0; i < this.LanViPham; i++)
                Console.WriteLine("Lan thu " + i + 1 + " : " + LyDoVP[i]);
        }
        public void GetInfoVP()
        {
            this.LanViPham = 0;
            LyDoVP = new string[5];
            Console.Write("So lan vi pham: ");
            Int16.TryParse(Console.ReadLine(), out this.LanViPham);
            for (int i = 0; i < LanViPham; i++)
            {
                Console.Write("Ly do vi pham lan " + i + 1 + " : ");
                this.LyDoVP[i] = Console.ReadLine();
            }
        }
        // Ham ve Info dich vu ca nhan hang thang
        public void TakeInfoDV()
        {
            Console.WriteLine("Cac dich vu ca nhan cua thang nay:");
            Console.Write("+ Giat xa: " + this.DichVuCaNhan.LanSuDung[0] + " lan");
            Console.Write("+ Gui xe: ");
            if (this.DichVuCaNhan.LanSuDung[1] != 0)
                Console.WriteLine("Co su dung");
            else
                Console.WriteLine("Khong su dung");
            Console.Write("+ Wifi ca nhan: ");
            if (this.DichVuCaNhan.LanSuDung[2] != 0)
                Console.WriteLine("Co su dung");
            else
                Console.WriteLine("Khong su dung");
            Console.WriteLine("Thanh tien dich vu: " + this.DichVuCaNhan.ThanhTien + "d");
        }
        public void GetInfoDV()
        {
            this.DichVuCaNhan = new CAUTRUC.DV();
            this.DichVuCaNhan = CAUTRUC.GetDV(false);
        }
    }

    class DICHVU
    {
        // Fields
        public double GiaDV1;
        public double GiaDV2;
        public double GiaDV3;
        public static DICHVU DVChung = new DICHVU(320000, 30000);
        public static DICHVU DVCaNhan = new DICHVU(20000, 60000, 50000);
        // Methods
        public DICHVU()
        {

        }
        public DICHVU(double GiaDV1, double GiaDV2)
        {
            this.GiaDV1 = GiaDV1;
            this.GiaDV2 = GiaDV2;
        }
        public DICHVU(double GiaDV1, double GiaDV2, double GiaDV3)
        {
            this.GiaDV1 = GiaDV1;
            this.GiaDV2 = GiaDV2;
            this.GiaDV3 = GiaDV3;
        }
        // Methods
        public DICHVU GetInfoGiaDV(bool LoaiDV)
        {
            double DV1, DV2, DV3;
            DICHVU temp = new DICHVU();
            if (LoaiDV)
            {
                Console.WriteLine("Nhap gia dich vu 1:");
                DV1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap gia dich vu 2:");
                DV2 = double.Parse(Console.ReadLine());
                temp = new DICHVU(DV1, DV2);
            }
            else
            {
                Console.WriteLine("Nhap gia dich vu 1:");
                DV1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap gia dich vu 2:");
                DV2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap gia dich vu 3:");
                DV3 = double.Parse(Console.ReadLine());
                temp = new DICHVU(DV1, DV2, DV3);
            }
            return temp;
        }

    }
}
