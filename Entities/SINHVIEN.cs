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
        // Methods
        // Take: lay va xuat thong tin len console
        // Get: lay va luu thong tin vao data
        // Ham ve Info sinh vien
        public void TakeInfoSV()
        {
            Console.WriteLine("Thong tin sinh vien!");
            Console.WriteLine("ID phong hien tai: ", this.idphong);
            CAUTRUC.TakeInfoNguoi(this.sinhvien);
            Console.WriteLine("CMND: ", this.cmnd);
            Console.WriteLine("Dia chi ho khau: ", this.diachihk);
            Console.Write("BHYT: ");
            if (bhyt == null)
                Console.WriteLine("Khong co");
            else
                Console.WriteLine(this.bhyt);
            Console.WriteLine("Noi lam viec: ", this.noilamviec);
            Console.WriteLine("Sinh vien nam thu: ", this.svnam);
        }
        public void GetInfoSV(int IDPhong,
                              CAUTRUC.NGUOI SinhVien,
                              string CMND,
                              string BHYT,
                              string NoiLamViec,
                              string DiaChiHK,
                              short SVNam)
        {
            this.idphong = IDPhong;
            this.sinhvien = SinhVien;
            this.cmnd = CMND;
            this.bhyt = BHYT;
            this.noilamviec = NoiLamViec;
            this.diachihk = DiaChiHK;
            this.svnam = SVNam;
        }
        // Ham ve Info hop dong
        public void TakeInfoHD()
        {
            Console.WriteLine("Ngay ki hop dong: ");
            CAUTRUC.TakeDate(this.hopdongstart);
            Console.WriteLine("Ngay het han hop dong: ");
            CAUTRUC.TakeDate(this.hopdongend);
        }
        public void GetInfoHD(string HopDongStart, string HopDongEnd)
        {
            this.hopdongstart = HopDongStart;
            this.hopdongend = HopDongEnd;
        }
        // Ham ve Info phu huynh, nguoi bao ho
        public void TakeInfoPH()
        {
            CAUTRUC.TakeInfoNguoi(phuhuynh1);
            CAUTRUC.TakeInfoNguoi(phuhuynh2);
        }
        public void GetInfoPH(CAUTRUC.NGUOI PhuHuynh1, CAUTRUC.NGUOI PhuHuynh2)
        {
            this.phuhuynh1 = PhuHuynh1;
            this.phuhuynh2 = PhuHuynh2;
        }
        // Ham ve Info vi pham, nhac nho
        public void TakeInfoVP()
        {
            Console.WriteLine("Vi pham: " + this.lanvipham + " lan!");
            for (int i = 0; i < this.lanvipham; i++)
                Console.WriteLine("Lan thu " + i + 1 + " : " + lydovp[i]);
        }
        public void GetInfoVP()
        {
            this.lanvipham = 0;
            lydovp = new string[5];
            Console.Write("So lan vi pham: ");
            Int16.TryParse(Console.ReadLine(), out this.lanvipham);
            for (int i = 0; i < lanvipham; i++)
            {
                Console.Write("Ly do vi pham lan " + i + 1 + " : ");
                this.lydovp[i] = Console.ReadLine();
            }
        }
        // Ham ve Info dich vu ca nhan hang thang
        public void TakeInfoDV()
        {
            Console.WriteLine("Cac dich vu ca nhan cua thang nay:");
            Console.Write("+ Giat xa: " + this.dichvurieng.LanSuDung[0] + " lan");
            Console.Write("+ Gui xe: ");
            if (this.dichvurieng.LanSuDung[1] != 0)
                Console.WriteLine("Co su dung");
            else
                Console.WriteLine("Khong su dung");
            Console.Write("+ Wifi ca nhan: ");
            if (this.dichvurieng.LanSuDung[2] != 0)
                Console.WriteLine("Co su dung");
            else
                Console.WriteLine("Khong su dung");
            Console.WriteLine("Thanh tien dich vu: " + this.dichvurieng.ThanhTien + "d");
        }
        public void GetInfoDV()
        {
            this.dichvurieng = new CAUTRUC.DV();
            this.dichvurieng = CAUTRUC.GetDV(false);
        }
    }
}
