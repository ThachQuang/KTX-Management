using KTX_Management.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTX_Management.Entities
{
    class SINHVIEN
    {
        // Fields
        private int idsinhvien;
        private int idphong;
        private CAUTRUC.NGUOI sinhvien;
        private string cmnd;
        private string bhyt;
        private string noilamviec;
        private string diachihk;
        private short svnam;
        private CAUTRUC.NGUOI phuhuynh1, phuhuynh2;
        private string hopdongstart, hopdongend;
        private CAUTRUC.DV dichvurieng;
        // Constructors
        // Khong tham so
        public SINHVIEN()
        {
        }
        // Getter and setter
        public CAUTRUC.NGUOI SinhVien
        {
            get { return sinhvien; }
            set { sinhvien = value; }
        }
        public int IDSinhVien
        {
            get { return idsinhvien; }
            set { idsinhvien = value; }
        }
        public int IDPhong
        {
            get { return idphong; }
            set { idphong = value; }
        }
        public string HoTen
        {
            get { return sinhvien.HoTen; }
            set { sinhvien.HoTen = value; }
        }
        public string GioiTinh
        {
            get { return sinhvien.GioiTinh; }
            set { sinhvien.GioiTinh = value; }
        }
        public string NgaySinh
        {
            get { return sinhvien.NgaySinh; }
            set { sinhvien.NgaySinh = value; }
        }
        public string QueQuan
        {
            get { return sinhvien.QueQuan; }
            set { sinhvien.QueQuan = value; }
        }
        public string NgheNghiep
        {
            get { return sinhvien.NgheNghiep; }
            set { sinhvien.NgheNghiep = value; }
        }
        public string SDT
        {
            get { return sinhvien.SDT; }
            set { sinhvien.SDT = value; }
        }
        public string CMND
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        public string BHYT
        {
            get { return bhyt; }
            set { bhyt = value; }
        }
        public string NoiLamViec
        {
            get { return noilamviec; }
            set { noilamviec = value; }
        }
        public string DiaChiHK
        {
            get { return diachihk; }
            set { diachihk = value; }
        }
        public short SVNam
        {
            get { return svnam; }
            set { svnam = value; }
        }
        public CAUTRUC.NGUOI PhuHuynh1
        {
            get { return phuhuynh1; }
            set { phuhuynh1 = value; }
        }
        public CAUTRUC.NGUOI PhuHuynh2
        {
            get { return phuhuynh2; }
            set { phuhuynh2 = value; }
        }
        public string HopDongStart
        {
            get { return hopdongstart; }
            set { hopdongstart = value; }
        }
        public string HopDongEnd
        {
            get { return hopdongend; }
            set { hopdongend = value; }
        }
        public CAUTRUC.DV DichVuRieng
        {
            get { return dichvurieng; }
            set { dichvurieng = value; }
        }
    }
}
