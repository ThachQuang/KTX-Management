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
    }
}
