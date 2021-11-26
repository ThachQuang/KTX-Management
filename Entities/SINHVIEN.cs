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
}
