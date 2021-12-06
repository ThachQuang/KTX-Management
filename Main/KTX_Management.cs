using KTX_Management.Dao;
using KTX_Management.DAO;
using KTX_Management.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTX_Management.Main
{
    class KTX_Management
    {
        static void Main()
        {
            // Định dạng input, output cho phép nhập có đấu
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            // Các hàm cho Phòng
            //AddPhong();
            // Các hàm cho Sinh Viên
            //AddSinhVien();
            DeleteSinhVien();
            //UpdateSinhVien();
            //UpdateHopDong();
<<<<<<< HEAD
            // 
=======
            //DeleteByIdPhong();
>>>>>>> 1f177e3d3c0e8b70a24949ff19de8c95ce6cc639
        }

        // Hàm check date có đúng hay không
        public static bool IsDate(string tempDate) 
        {
            DateTime fromDateValue;
            var formats = new[] { "dd/MM/yyyy", "yyyy-MM-dd" };
            if (DateTime.TryParseExact(tempDate, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fromDateValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Hàm check xem ID sinh viên này có tồn tại hay không
        static bool IsExistSinhVienID(int id_sinhvien)
        {
            try
            {
                const string CheckSinhVienID = @"SELECT count (*) FROM SINHVIEN WHERE id_sinhvien = @id_sinhvien ";
                object[] para = new object[] { id_sinhvien };
                object count = DataProvider.Instance.ExecuteScalar(CheckSinhVienID, para);
                return (int)count != 0;
            }
            catch
            {
                return false;
            }
        }
        // Hàm check xem ID phòng này có tồn tại hay không
        static bool IsExistPhongID(int id_phong)
        {
            try
            {
                const string CheckPhongID = @"SELECT count (*) FROM PHONG WHERE id_phong = @id_phong ";
                object[] para = new object[] { id_phong };
                object count = DataProvider.Instance.ExecuteScalar(CheckPhongID, para);
                return (int)count != 0;
            }
            catch
            {
                return false;
            }
        }
        // Các hàm dùng trong main
        // Hàm Add sinh viên vào database
        static void AddSinhVien()
        {
            CAUTRUC.NGUOI temp = new CAUTRUC.NGUOI();
            SINHVIEN sinhvien = new SINHVIEN();
            while (true)
            {
                Console.Write("Nhập ID phòng: ");
                sinhvien.IDPhong = int.Parse(Console.ReadLine());

                if (IsExistPhongID(sinhvien.IDPhong))
                    break;
                Console.WriteLine("Không tồn tại ID phòng này!");
            }
            Console.Write("Tên sinh viên: ");
            temp.HoTen = Console.ReadLine();
            while (true)
            {
                Console.Write("Ngày sinh (dd/mm/yyyy): ");
                temp.NgaySinh = Console.ReadLine();
                if (IsDate(temp.NgaySinh))
                break;
                Console.WriteLine("Ngày tháng không hợp lệ!");
            }
            
            Console.Write("Giới tính (1 = Nam, 0 = Nữ): ");
            temp.GioiTinh = int.Parse(Console.ReadLine());
            Console.Write("Quê quán: ");
            temp.QueQuan = Console.ReadLine();
            Console.Write("Nghề nghiệp: ");
            temp.NgheNghiep = Console.ReadLine();
            Console.Write("SĐT: ");
            temp.SDT = Console.ReadLine();
            sinhvien.SinhVien = temp;
            Console.Write("CMND: ");
            sinhvien.CMND = Console.ReadLine();
            Console.Write("BHYT: ");
            sinhvien.BHYT = Console.ReadLine();
            Console.Write("Nơi làm việc: ");
            sinhvien.NoiLamViec = Console.ReadLine();
            Console.Write("Đia chỉ hộ khẩu: ");
            sinhvien.DiaChiHK = Console.ReadLine();
            Console.Write("Sinh viên năm thứ: ");
            sinhvien.SVNam = short.Parse(Console.ReadLine());
            while (true)
            {
                Console.Write("Ngày kí hợp đồng thuê: ");
                sinhvien.HopDongStart = Console.ReadLine();
                if (IsDate(sinhvien.HopDongStart))
                    break;
            }
            while (true)
            {
                Console.Write("Ngày hết hạn hợp đồng: ");
                sinhvien.HopDongEnd = Console.ReadLine();
                if (IsDate(sinhvien.HopDongEnd))
                    break;
            }
            bool status = SinhVienDAO.Instance.AddSinhVien(sinhvien);
            if (status)
                Console.WriteLine("Add successful!");
            else Console.WriteLine("Add failed!");
        }
        // Hàm Delete sinh viên khỏi database
        static void DeleteSinhVien()
        {
            int id_sinhvien;
            Console.Write("Nhập ID sinh viên bạn muốn xoá: ");
            id_sinhvien = int.Parse(Console.ReadLine());
            bool status = SinhVienDAO.Instance.DeleteSinhVien(id_sinhvien);
            if (status)
                Console.WriteLine("Delete successful!");
            else Console.WriteLine("Delete failed!");
        }

        // Xoa sinhvien trong phong
        static void DeleteByIdPhong()
        {
            int id_phong;
            Console.Write("Nhập ID phòng bạn muốn xoá: ");
            id_phong = int.Parse(Console.ReadLine());
            bool status = SinhVienDAO.Instance.DeleteByIdPhong(id_phong);
            if (status)
                Console.WriteLine("Delete successful!");
            else Console.WriteLine("Delete failed!");
        }
        // Hàm Update sinh viên trong database
        static void UpdateSinhVien()
        {
            CAUTRUC.NGUOI temp = new CAUTRUC.NGUOI();
            SINHVIEN sinhvien = new SINHVIEN();
            while (true)
            {
                Console.Write("Nhập ID sinh viên: ");
                sinhvien.IDSinhVien = int.Parse(Console.ReadLine());

                if (IsExistSinhVienID(sinhvien.IDSinhVien))
                    break;
                Console.WriteLine("Không tồn tại ID sinh viên này!");
            }
            Console.Write("Nhập ID phòng: ");
            sinhvien.IDPhong = int.Parse(Console.ReadLine());
            Console.Write("Tên sinh viên: ");
            temp.HoTen = Console.ReadLine();
            while (true)
            {
                Console.Write("Ngày sinh (dd/mm/yyyy): ");
                temp.NgaySinh = Console.ReadLine();
                if (IsDate(temp.NgaySinh))
                    break;
                Console.WriteLine("Ngày tháng không hợp lệ!");
            }
            Console.Write("Giới tính (1 = Nam, 0 = Nữ): ");
            temp.GioiTinh = int.Parse(Console.ReadLine());
            Console.Write("Quê quán: ");
            temp.QueQuan = Console.ReadLine();
            Console.Write("Nghề nghiệp: ");
            temp.NgheNghiep = Console.ReadLine();
            Console.Write("SĐT: ");
            temp.SDT = Console.ReadLine();
            sinhvien.SinhVien = temp;
            Console.Write("CMND: ");
            sinhvien.CMND = Console.ReadLine();
            Console.Write("BHYT: ");
            sinhvien.BHYT = Console.ReadLine();
            Console.Write("Nơi làm việc: ");
            sinhvien.NoiLamViec = Console.ReadLine();
            Console.Write("Đia chỉ hộ khẩu: ");
            sinhvien.DiaChiHK = Console.ReadLine();
            Console.Write("Sinh viên năm thứ: ");
            sinhvien.SVNam = short.Parse(Console.ReadLine());
            
            bool status = SinhVienDAO.Instance.UpdateSinhVien(sinhvien);
            if (status)
                Console.WriteLine("Update successful!");
            else Console.WriteLine("Update failed!");
        }
        // Hàm Update hợp đồng SV trong database
        static void UpdateHopDong()
        {
            SINHVIEN sinhvien = new SINHVIEN();
            while (true)
            {
                Console.Write("Nhập ID sinh viên: ");
                sinhvien.IDSinhVien = int.Parse(Console.ReadLine());

                if (IsExistSinhVienID(sinhvien.IDSinhVien))
                    break;
                Console.WriteLine("Không tồn tại ID sinh viên này!");
            }
            while (true)
            {
                Console.Write("Ngày kí hợp đồng thuê: ");
                sinhvien.HopDongStart = Console.ReadLine();
                if (IsDate(sinhvien.HopDongStart))
                    break;
            }
            while (true)
            {
                Console.Write("Ngày hết hạn hợp đồng: ");
                sinhvien.HopDongEnd = Console.ReadLine();
                if (IsDate(sinhvien.HopDongEnd))
                    break;
            }
            bool status = SinhVienDAO.Instance.UpdateHopDong(sinhvien);
            if (status)
                Console.WriteLine("Update successful!");
            else Console.WriteLine("Update failed!");
        }
        // Hàm Add phòng vào database
        static void AddPhong()
        {
            PHONG phong = new PHONG();
            Console.Write("Tên phòng: ");
            phong.TenPhong = Console.ReadLine();
            Console.Write("Khu: ");
            phong.Khu = Console.ReadLine();
            Console.Write("Tầng: ");
            phong.Tang = short.Parse(Console.ReadLine());
            Console.Write("Sức chứa: ");
            phong.SucChua = short.Parse(Console.ReadLine());
            Console.Write("Số người ở hiện tại: ");
            phong.SoNguoi = short.Parse(Console.ReadLine());
            Console.Write("Diện tích: ");
            phong.DienTich = double.Parse(Console.ReadLine());
            Console.Write("Giá thuê: ");
            phong.GiaThue = double.Parse(Console.ReadLine());
            phong.TongThu = 0;
            bool status = PhongDAO.Instance.AddPhong(phong);
            if (status)
                Console.WriteLine("Add successful!");
            else Console.WriteLine("Add failed!");
        }
        // Hàm xoá phòng khỏi database
        static void DeletePhong()
        {
            int id_phong;
            Console.WriteLine("Lưu ý: Nếu xoá phòng, mọi sinh viên liên quan đến ID phòng đều sẽ bị xoá");
            Console.Write("Nhập ID phòng bạn muốn xoá: ");
            id_phong = int.Parse(Console.ReadLine());
            bool status = PhongDAO.Instance.DeletePhong(id_phong);
            if (status)
                Console.WriteLine("Delete successful!");
            else Console.WriteLine("Delete failed!");
        }
    }
}
