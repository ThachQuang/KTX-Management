using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTXManagement
{
    public class CAUTRUC
    {
        // Cac struct
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
                public bool TinhTrang;
            };
            public PHANLOAI[] PhanLoai;
        };
        public struct DIENNUOC
        {
            public int SoDau, SoCuoi;
            public int[] HeSoBac;
            public int[] HeSoPhi;
            public float ThanhTien;
        };
        public struct DV
        {
            public bool LoaiDV;
            public int[] LanSuDung;
            public float ThanhTien;
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
        public static VT GetViTri()
        {
            VT temp = new VT();
            Console.WriteLine("Nhap khu vuc cua phong: ");
            temp.Khu = Console.ReadLine();
            Console.WriteLine("Nhap tang cua phong: ");
            temp.Tang = short.Parse(Console.ReadLine());
            return temp;
        }

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

        public static DIENNUOC GetDienNuoc()
        {
            DIENNUOC temp = new DIENNUOC();
            Console.WriteLine("Nhap so dau: ");
            temp.SoDau = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cuoi: ");
            temp.SoCuoi = int.Parse(Console.ReadLine());
            return temp;
        }

        public static DV GetDV()
        {
            DV temp = new DV();
            if (temp.LoaiDV == true) // DV chung
            {
                Console.WriteLine("Nhap so lan su dung DV1: ");
                temp.LanSuDung[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so lan su dung DV2: ");
                temp.LanSuDung[1] = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Nhap so lan su dung DV1: ");
                temp.LanSuDung[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so lan su dung DV2: ");
                temp.LanSuDung[1] = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so lan su dung DV3: ");
                temp.LanSuDung[2] = int.Parse(Console.ReadLine());
            }
            return temp;
        }
    }

    class PHONG
    {

    }

    class SINHVIEN
    {
        private CAUTRUC.NGUOI SinhVien;
        private string CMND;
        private string BHYT;
        private string NoiLamViec;
        private string DiaChiHK;
        private short SVNam;
        private CAUTRUC.NGUOI PhuHuynh1, PhuHuynh2;
        private CAUTRUC.DATE HopDongStart, HopDongEnd;
        private CAUTRUC.DV PhiDichVu;
        private short LanViPham;
        private string[] LyDoVP = new string[5];
        public SINHVIEN()
        {
        }
        public SINHVIEN(CAUTRUC.NGUOI SinhVien,
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
        public void GetInfoSV(CAUTRUC.NGUOI SinhVien,
                              string CMND,
                              string BHYT,
                              string NoiLamViec,
                              string DiaChiHK,
                              short SVNam)
        {
            this.SinhVien = SinhVien;
            this.CMND = CMND;
            this.BHYT = BHYT;
            this.NoiLamViec = NoiLamViec;
            this.DiaChiHK = DiaChiHK;
            this.SVNam = SVNam;
        }
        public void GetInfoPH(CAUTRUC.NGUOI PhuHuynh1, CAUTRUC.NGUOI PhuHuynh2)
        {
            this.PhuHuynh1 = PhuHuynh1;
            this.PhuHuynh2 = PhuHuynh2;
        }
        public void GetInfoHD(CAUTRUC.DATE HopDongStart, CAUTRUC.DATE HopDongEnd)
        {
            this.HopDongStart = HopDongStart;
            this.HopDongEnd = HopDongEnd;
        }
        public void GetInfoVP()
        {
            Console.WriteLine("Vi pham: " + this.LanViPham + " lan!");
            for (int i = 0; i < this.LanViPham; i++)
                Console.WriteLine("Lan thu " + i + 1 + " : " + LyDoVP[i]);
        }
        public void TakeInfoVP()
        {
            ResetInfoVP();
            Console.Write("So lan vi pham: ");
            Int16.TryParse(Console.ReadLine(), out this.LanViPham);
            for (int i = 0; i < LanViPham; i++)
            {
                Console.Write("Ly do vi pham lan " + i + 1 + " : ");
                this.LyDoVP[i] = Console.ReadLine();
            }
        }
        public void ResetInfoVP()
        {
            this.LanViPham = 0;
            LyDoVP = new string[5];
        }
        public void GetInfoDV(CAUTRUC.DV PhiDichVu)
        {
            this.PhiDichVu = PhiDichVu;
        }
        public CAUTRUC.DV GetInfoPhi()
        {
            return this.PhiDichVu;
        }
        public void ResetInfoDV()
        {
            this.PhiDichVu = new CAUTRUC.DV();
        }
    }
}
