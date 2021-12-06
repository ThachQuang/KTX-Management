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
        private short lanvipham;
        private string[] lydovp = new string[5];
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
                        string HopDongStart,
                        string HopDongEnd)
        {
            this.idphong = IDPhong;
            this.sinhvien = SinhVien;
            this.cmnd = CMND;
            this.bhyt = BHYT;
            this.noilamviec = NoiLamViec;
            this.diachihk = DiaChiHK;
            this.svnam = SVNam;
            this.phuhuynh1 = PhuHuynh1;
            this.phuhuynh2 = PhuHuynh2;
            this.hopdongstart = HopDongStart;
            this.hopdongend = HopDongEnd;
        }
        // Getter and setter
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
        public CAUTRUC.NGUOI SinhVien
        {
            get { return sinhvien; }
            set { sinhvien = value; }
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
        public short LanViPham
        {
            get { return lanvipham; }
            set { lanvipham = value; }
        }
        public string[] LyDDoVP
        {
            get { return lydovp; }
            set { lydovp = value; }
        }
    }
}
