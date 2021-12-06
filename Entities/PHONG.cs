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
        private int idphong;
        private string tenphong;
        private CAUTRUC.VT vitri;
        private short succhuanguoi;
        private short songuoihientai;
        private CAUTRUC.NT noithat;
        private double dientich;
        private double giathue;
        private CAUTRUC.DIENNUOC dien;
        private CAUTRUC.DIENNUOC nuoc;
        private CAUTRUC.DV dichvuphong;
        private double tongthuthang;
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
            this.idphong = IDPhong;
            this.tenphong = TenPhong;
            this.vitri = ViTri;
            this.succhuanguoi = SucChuaNguoi;
            this.songuoihientai = SoNguoiHienTai;
            this.dientich = DienTich;
            this.giathue = GiaThue;
        }
        // Getter & setter
        public int IDPhong
        {
            get { return idphong; }
            set { idphong = value; }
        }
        public string TenPhong
        {
            get { return tenphong; }
            set { tenphong = value; }
        }
        public string Khu
        {
            get { return vitri.Khu; }
            set { vitri.Khu = value; }
        }
        public short Tang
        {
            get { return vitri.Tang; }
            set { vitri.Tang = value; }
        }
        public short SucChua
        {
            get { return succhuanguoi; }
            set { succhuanguoi = value; }
        }
        public short SoNguoi
        {
            get { return songuoihientai; }
            set { songuoihientai = value; }
        }
        public CAUTRUC.NT NoiThat
        {
            get { return noithat; }
            set { noithat = value; }
        }
        public double DienTich
        {
            get { return dientich; }
            set { dientich = value; }
        }
        public double GiaThue
        {
            get { return giathue; }
            set { giathue = value; }
        }
        public CAUTRUC.DIENNUOC Dien
        {
            get { return dien; }
            set { dien = value; }
        }
        public CAUTRUC.DIENNUOC Nuoc
        {
            get { return nuoc; }
            set { nuoc = value; }
        }
        public CAUTRUC.DV DichVuPhong
        {
            get { return dichvuphong; }
            set { dichvuphong = value; }
        }
        public double TongThu
        {
            get { return tongthuthang; }
            set { tongthuthang = value; }
        }
        // Methods
        // Take: lay va xuat thong tin len console
        // Get: lay va luu thong tin vao data
        // Ham ve Info phong
        public void TakeInfoPhong()
        {
            Console.WriteLine("ID phong: ", this.idphong);
            Console.WriteLine("Ten phong: ", this.tenphong);
            Console.WriteLine("Khu: ", this.vitri.Khu);
            Console.WriteLine("Tang: ", this.vitri.Tang);
            Console.WriteLine("Loai phong: " + this.succhuanguoi + " nguoi");
            Console.WriteLine("So nguoi tam tru: ", this.songuoihientai);
            Console.WriteLine("Dien tich phong: " + this.dientich + "m3");
            Console.WriteLine("Gia thue hang thang: ", this.giathue);
        }
        public void GetInfoPhong(int IDPhong,
                                 string TenPhong,
                                 CAUTRUC.VT ViTri,
                                 short SucChuaNguoi,
                                 short SoNguoiHienTai,
                                 double DienTich,
                                 double GiaThue)
        {
            this.idphong = IDPhong;
            this.tenphong = TenPhong;
            this.vitri = ViTri;
            this.succhuanguoi = SucChuaNguoi;
            this.songuoihientai = SoNguoiHienTai;
            this.dientich = DienTich;
            this.giathue = GiaThue;
        }
        // Ham ve Info noi that
        public void TakeInfoNT()
        {
            Console.WriteLine("Thong tin noi that co san cua phong!");
            for (int i = 0; i < this.noithat.SoLuongNT; i++)
            {
                Console.WriteLine("Ten loai noi that: ", this.noithat.PhanLoai[i].Ten);
                Console.WriteLine("So luong: ", this.noithat.PhanLoai[i].SoLuong);
                Console.Write("Tinh trang hong hoc: ");
                if (this.noithat.PhanLoai[i].TinhTrang)
                    Console.WriteLine("Co hong hoc");
                else
                    Console.WriteLine("Khong hong hoc");
            }
        }
        public void GetInfoNT()
        {
            this.noithat = new CAUTRUC.NT();
            this.noithat = CAUTRUC.GetNoiThat();
        }
        // Ham ve Info dien
        public void TakeInfoDien()
        {
            Console.WriteLine("So ki dien thang truoc: " + this.dien.SoDau + "kWh");
            Console.WriteLine("So ki dien thang nay: " + this.dien.SoCuoi + "kWh");
            Console.WriteLine("Tong so ki dien da dung: " + (this.dien.SoCuoi - this.dien.SoDau) + "kWh");
            CAUTRUC.ThanhTienDien(ref this.dien);
            Console.WriteLine("Thanh tien dien thang nay: " + this.dien.ThanhTien + "d");
        }
        public void GetInfoDien()
        {
            this.dien = new CAUTRUC.DIENNUOC();
            this.dien = CAUTRUC.GetDienNuoc();
        }
        // Ham ve Info nuoc
        public void TakeInfoNuoc()
        {
            Console.WriteLine("So ki nuoc thang truoc: " + this.nuoc.SoDau + "m3");
            Console.WriteLine("So ki nuoc thang nay: " + this.nuoc.SoCuoi + "m3");
            Console.WriteLine("Tong so ki nuoc da dung: " + (this.nuoc.SoCuoi - this.nuoc.SoDau) + "m3");
            CAUTRUC.ThanhTienNuoc(ref this.nuoc);
            Console.WriteLine("Thanh tien nuoc thang nay: " + this.nuoc.ThanhTien + "d");
        }
        public void GetInfoNuoc()
        {
            this.nuoc = new CAUTRUC.DIENNUOC();
            this.nuoc = CAUTRUC.GetDienNuoc();
        }
        // Ham ve Info dich vu phong hang thang
        public void TakeInfoDV()
        {
            Console.WriteLine("Cac dich vu phong cua thang nay:");
            Console.Write("+ WiFi chung: ");
            if (this.dichvuphong.LanSuDung[0] != 0)
                Console.WriteLine("Co su dung");
            else
                Console.WriteLine("Khong su dung");
            Console.WriteLine("+ Sua chua noi that: " + this.dichvuphong.LanSuDung[1] + " lan");
            Console.WriteLine("Thanh tien dich vu: " + this.dichvuphong.ThanhTien + "d");
        }
        public void GetInfoDV()
        {
            this.dichvuphong = new CAUTRUC.DV();
            this.dichvuphong = CAUTRUC.GetDV(true);
        }
        // Ham ve Info phi thu hang thang
        public void TakeInfoPhi()
        {
            Console.WriteLine("Thu phi phong thang nay: " + this.tongthuthang + "d");
        }
        public void GetInfoPhi()
        {
            this.tongthuthang = 0;
            this.tongthuthang = this.giathue + this.dien.ThanhTien + this.nuoc.ThanhTien + this.dichvuphong.ThanhTien;
        }
    }
}
