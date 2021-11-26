using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTX_Management.Entities
{
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
}
