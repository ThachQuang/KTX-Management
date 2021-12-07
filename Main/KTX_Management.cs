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
            //UpdatePhong();
            //DeletePhong();
            //AddNoiThat();
            //DeleteNoiThat();
            //CheckNoiThat();
            //FixNoiThat();
            //CountSinhVien(id_phong);
            //AddThongSoDien();
            //DeleteThongSoDien();
            //AddThongSoNuoc();
            //DeleteThongSoNuoc();
            // Các hàm cho Sinh Viên
            AddSinhVien();
            //DeleteSinhVien();
            //UpdateSinhVien();
            //UpdateHopDong();
            //DeleteByIdPhong();
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

        // SINHVIEN
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
            Console.Write("Nhập ID phòng bạn muốn xoá tất cả sinh viên: ");
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
        static void AddPhuHuynh()
        {
            int id;
            Console.Write("Nhap id sinh vien: ");
            id=int.Parse(Console.ReadLine());
            CAUTRUC.NGUOI temp = new CAUTRUC.NGUOI();
            Console.Write("Tên sinh phu huynh: ");
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
            
            bool status = SinhVienDAO.Instance.AddPhuHuynh(temp,id);
            if (status)
                Console.WriteLine("Add successful!");
            else Console.WriteLine("Add failed!");
        }
        // Hàm Delete sinh viên khỏi database
        static void DeletePhuHuynh()
        {
            int id_sinhvien;
            Console.Write("Nhập ID sinh viên bạn muốn xoá phu huynh: ");
            id_sinhvien = int.Parse(Console.ReadLine());
            bool status = SinhVienDAO.Instance.DeletePhuHuynh(id_sinhvien);
            if (status)
                Console.WriteLine("Delete successful!");
            else Console.WriteLine("Delete failed!");
        }

        // Hàm Update sinh viên trong database
        static void UpdatePhuHuynh()
        {
            int id;
            Console.Write("Nhap id sinh vien: ");
            id = int.Parse(Console.ReadLine());
            CAUTRUC.NGUOI temp = new CAUTRUC.NGUOI();
            Console.Write("Tên sinh phu huynh: ");
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

            bool status = SinhVienDAO.Instance.UpdatePhuHuynh(temp,id);
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

        // PHONG
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
            phong.SoNguoi = 0;
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
        // Hàm Update phòng trong database
        static void UpdatePhong()
        {
            PHONG phong = new PHONG();
            while (true)
            {
                Console.Write("Nhập ID phòng muốn cập nhật thông tin: ");
                phong.IDPhong = int.Parse(Console.ReadLine());
               
                if (IsExistPhongID(phong.IDPhong))
                    break;
                Console.WriteLine("Không tồn tại ID phòng này!");
            }
            Console.Write("Tên phòng: ");
            phong.TenPhong = Console.ReadLine();
            Console.Write("Khu: ");
            phong.Khu = Console.ReadLine();
            Console.Write("Tầng: ");
            phong.Tang = short.Parse(Console.ReadLine());
            Console.Write("Sức chứa: ");
            phong.SucChua = short.Parse(Console.ReadLine());
            phong.SoNguoi = Convert.ToInt16(CountSinhVien(phong.IDPhong));
            Console.Write("Số người ở hiện tại: " + phong.SoNguoi);
            Console.Write("Diện tích: ");
            phong.DienTich = double.Parse(Console.ReadLine());
            Console.Write("Giá thuê: ");
            phong.GiaThue = double.Parse(Console.ReadLine());
            phong.TongThu = 0;
            bool status = PhongDAO.Instance.UpdatePhong(phong);
            if (status)
                Console.WriteLine("Update successful!");
            else Console.WriteLine("Update failed!");
        }
        // Hàm xoá phòng khỏi database
        static void DeletePhong()
        {
            int id_phong;
            Console.WriteLine("Lưu ý: Nếu xoá phòng, mọi sinh viên liên quan đến ID phòng đều sẽ bị xoá");
            while (true)
            {
                Console.Write("Nhập ID phòng bạn muốn xoá: ");
                id_phong = int.Parse(Console.ReadLine());

                if (IsExistPhongID(id_phong))
                    break;
                Console.WriteLine("Không tồn tại ID phòng này!");
            }
            Console.WriteLine("Đang xoá tất cả sinh viên có ID phòng được nhập!");
            bool status1 = SinhVienDAO.Instance.DeleteByIdPhong(id_phong);
            if (status1)
                Console.WriteLine("Delete successful!");
            else Console.WriteLine("Delete failed!");
            Console.WriteLine("Đang xoá thông tin của ID phòng được nhập!");
            bool status2 = PhongDAO.Instance.DeletePhong(id_phong);
            if (status2)
                Console.WriteLine("Delete successful!");
            else Console.WriteLine("Delete failed!");
        }
        // Hàm thêm nội thất mói vào phòng
        static void AddNoiThat()
        {
            int id_phong;
            CAUTRUC.NT temp = new CAUTRUC.NT();
            while (true)
            {
                Console.Write("Nhập ID phòng muốn thêm nội thất: ");
                id_phong = int.Parse(Console.ReadLine());

                if (IsExistPhongID(id_phong))
                    break;
                Console.WriteLine("Không tồn tại ID phòng này!");
            }
            temp = CAUTRUC.GetNoiThat();
            bool status = PhongDAO.Instance.AddNoiThat(id_phong, temp);
            if (status)
                Console.WriteLine("Add successful!");
            else Console.WriteLine("Add failed!");
        }
        // Hàm xoá hết nội thất một phòng
        static void DeleteNoiThat()
        {
            int id_phong;
            while (true)
            {
                Console.Write("Nhập ID phòng muốn xoá nội thất: ");
                id_phong = int.Parse(Console.ReadLine());

                if (IsExistPhongID(id_phong))
                    break;
                Console.WriteLine("Không tồn tại ID phòng này!");
            }
            bool status = PhongDAO.Instance.DeleteNoiThat(id_phong);
            if (status)
                Console.WriteLine("Delete successful!");
            else Console.WriteLine("Delete failed!");
        }
        // Hàm đếm số sinh viên có theo ID phòng
        static int CountSinhVien(int id_phong)
        {
            int temp;
            temp = SinhVienDAO.Instance.CountSinhVien(id_phong);
            return temp;
        }
        // Hàm kiểm tra số lượng và tình trạng nội thất
        static void CheckNoiThat()
        {
            int id_phong;
            while(true)
            {
                Console.Write("Nhập ID phòng muốn kiểm tra nội thất: ");
                id_phong = int.Parse(Console.ReadLine());

                if (IsExistPhongID(id_phong))
                    break;
                Console.WriteLine("Không tồn tại ID phòng này!");
            }
            PhongDAO.Instance.CheckNoiThat(id_phong);
        }
        // Hàm Update tình trạng thông qua ID phòng và tên nội thất
        static void FixNoiThat()
        {
            int id_phong;
            while (true)
            {
                Console.Write("Nhập ID phòng muốn cập nhật tình trạng nội thất: ");
                id_phong = int.Parse(Console.ReadLine());

                if (IsExistPhongID(id_phong))
                    break;
                Console.WriteLine("Không tồn tại ID phòng này!");
            }
            int tinh_trang;
            string name;
            Console.Write("Nhập tên nội thất muốn thay đổi tình trạng: ");
            name = Console.ReadLine();
            Console.Write("Tình trạng hiện tại (H = hư hỏng/B = bình thường): ");
            string key = Console.ReadLine();
            if (key == "H" || key == "h")
                tinh_trang = 1;
            else
                tinh_trang = 0;
            bool status = PhongDAO.Instance.FixNoiThat(id_phong, name, tinh_trang);
            if (status)
                Console.WriteLine("Update successful!");
            else Console.WriteLine("Update failed! Kiểm tra lại tên nội thất");
        }
        // Hàm thêm thông số điện
        static void AddThongSoDien()
        {
            int id_phong;
            CAUTRUC.DIENNUOC temp = new CAUTRUC.DIENNUOC();
            while (true)
            {
                Console.Write("Nhập ID phòng muốn thêm ghi chú điện: ");
                id_phong = int.Parse(Console.ReadLine());

                if (IsExistPhongID(id_phong))
                    break;
                Console.WriteLine("Không tồn tại ID phòng này!");
            }
            Console.Write("Nhập tháng muốn thêm: ");
            int thang = int.Parse(Console.ReadLine());
            Console.Write("Nhập số điện tháng trước: ");
            temp.SoDau = int.Parse(Console.ReadLine());
            Console.Write("Nhập số điện tháng này: ");
            temp.SoCuoi = int.Parse(Console.ReadLine());
            temp.ThanhTien = CAUTRUC.ThanhTienDien(temp);
            bool status = PhongDAO.Instance.AddDien(id_phong, thang, temp);
            if (status)
                Console.WriteLine("Add successful!");
            else Console.WriteLine("Add failed!");

        }
        // Hàm thêm thông số nước
        static void AddThongSoNuoc()
        {
            int id_phong;
            CAUTRUC.DIENNUOC temp = new CAUTRUC.DIENNUOC();
            while (true)
            {
                Console.Write("Nhập ID phòng muốn thêm ghi chú nước: ");
                id_phong = int.Parse(Console.ReadLine());

                if (IsExistPhongID(id_phong))
                    break;
                Console.WriteLine("Không tồn tại ID phòng này!");
            }
            Console.Write("Nhập tháng muốn thêm: ");
            int thang = int.Parse(Console.ReadLine());
            Console.Write("Nhập số nước tháng trước: ");
            temp.SoDau = int.Parse(Console.ReadLine());
            Console.Write("Nhập số nước tháng này: ");
            temp.SoCuoi = int.Parse(Console.ReadLine());
            temp.ThanhTien = CAUTRUC.ThanhTienNuoc(temp);
            bool status = PhongDAO.Instance.AddNuoc(id_phong, thang, temp);
            if (status)
                Console.WriteLine("Add successful!");
            else Console.WriteLine("Add failed!");

        }
        // Hàm xoá thông số điện
        static void DeleteThongSoDien()
        {
            int id_phong;
            while (true)
            {
                Console.Write("Nhập ID phòng muốn xoá ghi chú điện: ");
                id_phong = int.Parse(Console.ReadLine());

                if (IsExistPhongID(id_phong))
                    break;
                Console.WriteLine("Không tồn tại ID phòng này!");
            }
            Console.Write("Nhập tháng muốn xoá: ");
            int thang = int.Parse(Console.ReadLine());
            bool status = PhongDAO.Instance.DeleteDien(id_phong, thang);
            if (status)
                Console.WriteLine("Delete successful!");
            else Console.WriteLine("Delete failed!");
        }
        // Hàm xoá thông số nước
        static void DeleteThongSoNuoc()
        {
            int id_phong;
            while (true)
            {
                Console.Write("Nhập ID phòng muốn xoá ghi chú nước: ");
                id_phong = int.Parse(Console.ReadLine());

                if (IsExistPhongID(id_phong))
                    break;
                Console.WriteLine("Không tồn tại ID phòng này!");
            }
            Console.Write("Nhập tháng muốn xoá: ");
            int thang = int.Parse(Console.ReadLine());
            bool status = PhongDAO.Instance.DeleteNuoc(id_phong, thang);
            if (status)
                Console.WriteLine("Delete successful!");
            else Console.WriteLine("Delete failed!");
        }
    }
}
