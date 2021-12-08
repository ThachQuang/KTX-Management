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
            char key;
            string option;
            bool end_signal = true;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("                     ======= Chương trình quản lý KTX nhóm 25 =======");
                Console.WriteLine("                     ==         [1] Quản lý phòng ở KTX            ==");
                Console.WriteLine("                     ==         [2] Quản lý sinh viên KTX          ==");
                Console.WriteLine("                     ==         [3] Quản lý dịch vụ KTX            ==");
                Console.WriteLine("                     ==         [0] Thoát chương trình             ==");
                Console.WriteLine("                     ================================================");
                Console.Write("                         Mời bạn chọn chức năng chương trình: ");
                option = Console.ReadLine();
                Console.WriteLine();
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        while (end_signal)
                        {
                            Console.Clear();
                            Console.WriteLine("                     ============ Chức năng quản lý phòng ===========");
                            Console.WriteLine("                     ==      [1] Thêm 1 phòng mới                  ==");
                            Console.WriteLine("                     ==      [2] Sửa thông tin phòng               ==");
                            Console.WriteLine("                     ==      [3] Xoá 1 phòng có sẵn                ==");
                            Console.WriteLine("                     ==      [4] Thêm nội thất vào 1 phòng         ==");
                            Console.WriteLine("                     ==      [5] Xoá nội thất trong 1 phòng        ==");
                            Console.WriteLine("                     ==      [6] Kiểm tra tình trạng nội thất      ==");
                            Console.WriteLine("                     ==      [7] Cập nhật tình trạng nội thất      ==");
                            Console.WriteLine("                     ==      [8] Thêm ghi chú điện cho phòng       ==");
                            Console.WriteLine("                     ==      [9] Xoá ghi chú điện cho phòng        ==");
                            Console.WriteLine("                     ==      [10] Thêm ghi chú nước cho phòng      ==");
                            Console.WriteLine("                     ==      [11] Xoá ghi chú nước cho phòng       ==");
                            Console.WriteLine("                     ==      [12] Cập nhật phí thu theo tháng      ==");
                            Console.WriteLine("                     ==      [13] Hiển thị tất cả phòng KTX        ==");
                            Console.WriteLine("                     ==      [14] Hiển thị nội thất của phòng      ==");
                            Console.WriteLine("                     ==      [15] Hiển thị phí thu tất cả phòng    ==");
                            Console.WriteLine("                     ==      [0] Quay lại                          ==");
                            Console.WriteLine("                     ================================================");
                            Console.Write("                         Mời bạn chọn chức năng chương trình: ");
                            option = Console.ReadLine();
                            //Console.WriteLine(option);
                            Console.WriteLine();
                            switch (option)
                            {
                                case "1":
                                    Console.WriteLine("Bạn chọn chức năng thêm 1 phòng mới");
                                    AddPhong();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "2":
                                    Console.WriteLine("Bạn chọn chức năng sửa thông tin phòng");
                                    UpdatePhong();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "3":
                                    Console.WriteLine("Bạn chọn chức năng xoá 1 phòng có sẵn");
                                    DeletePhong();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "4":
                                    Console.WriteLine("Bạn chọn chức năng thêm nội thất vào 1 phòng");
                                    AddNoiThat();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "5":
                                    Console.WriteLine("Bạn chọn chức năng xoá nội thất trong 1 phòng");
                                    DeleteNoiThat();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "6":
                                    Console.WriteLine("Bạn chọn chức năng iểm tra nội thất trong 1 phòng");
                                    CheckNoiThat();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "7":
                                    Console.WriteLine("Bạn chọn chức năng cập nhật tình trạng nội thất trong 1 phòng");
                                    FixNoiThat();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "8":
                                    Console.WriteLine("Bạn chọn chức năng thêm ghi chú điện vào 1 phòng");
                                    AddThongSoDien();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "9":
                                    Console.WriteLine("Bạn chọn chức năng xoá ghi chú điện vào 1 phòng");
                                    DeleteThongSoDien();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "10":
                                    Console.WriteLine("Bạn chọn chức năng thêm ghi chú nước vào 1 phòng");
                                    AddThongSoNuoc();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "11":
                                    Console.WriteLine("Bạn chọn chức năng xoá ghi chú nước vào 1 phòng");
                                    DeleteThongSoNuoc();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "12":
                                    Console.WriteLine("Bạn chọn chức năng cập nhật phí thu theo tháng của phòng");
                                    UpdatePhi();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "13":
                                    Console.WriteLine("Bạn chọn chức năng hiển thị tất cả phòng của KTX");
                                    HienThiPhong();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "14":
                                    Console.WriteLine("Bạn chọn chức năng hiển thị nội thất của 1 phòng");
                                    HienThiNoiThat();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "15":
                                    Console.WriteLine("Bạn chọn chức năng hiển thị phí thu tất cả phòng");
                                    HienThiPhi();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "0":
                                    end_signal = false;
                                    Console.WriteLine("Đang trở lại menu chính! Nhấn phím bất kỳ để tiếp tục!");
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                default:
                                    Console.WriteLine("Không có chức năng này!");
                                    Console.WriteLine("Nhấn phím bất kỳ để tiếp tục");
                                    key = Console.ReadKey().KeyChar;
                                    break;
                            }
                        }
                        end_signal = true;
                        break;
                    case "2":
                        Console.Clear();
                        while (end_signal)
                        {
                            Console.Clear();
                            Console.WriteLine("                     ========= Chức năng quản lý sinh viên ==========");
                            Console.WriteLine("                     ==      [1] Thêm 1 sinh viên mới              ==");
                            Console.WriteLine("                     ==      [2] Sửa thông tin 1 sinh siên         ==");
                            Console.WriteLine("                     ==      [3] Xoá 1 sinh viên có sẵn            ==");
                            Console.WriteLine("                     ==      [4] Thêm thông tin phụ huynh SV       ==");
                            Console.WriteLine("                     ==      [5] Sửa thông tin phụ huynh SV        ==");
                            Console.WriteLine("                     ==      [6] Xoá thông tin phụ huynh SV        ==");
                            Console.WriteLine("                     ==      [7] Cập nhật hợp đồng 1 sinh viên     ==");
                            Console.WriteLine("                     ==      [8] Hiển thị thông tin 1 sinh viên    ==");
                            Console.WriteLine("                     ==      [9] Hiển thị thông tin SV theo phòng  ==");
                            Console.WriteLine("                     ==      [10] Xuất theo thứ tự                 ==");
                            Console.WriteLine("                     ==      [0] Quay lại                          ==");
                            Console.WriteLine("                     ================================================");
                            Console.Write("                         Mời bạn chọn chức năng chương trình: ");
                            option = Console.ReadLine();
                            //Console.WriteLine(option);
                            Console.WriteLine();
                            switch (option)
                            {
                                case "1":
                                    Console.WriteLine("Bạn chọn chức năng thêm 1 sinh viên mới");
                                    AddSinhVien();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "2":
                                    Console.WriteLine("Bạn chọn chức năng sửa thông tin 1 sinh viên");
                                    UpdateSinhVien();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "3":
                                    Console.WriteLine("Bạn chọn chức năng xoá 1 sinh viên có sẵn");
                                    DeleteSinhVien();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "4":
                                    Console.WriteLine("Bạn chọn chức năng thêm thông tin phụ huynh 1 SV");
                                    AddPhuHuynh();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "5":
                                    Console.WriteLine("Bạn chọn chức năng cập nhật thông tin phụ huynh 1 SV");
                                    UpdatePhuHuynh();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "6":
                                    Console.WriteLine("Bạn chọn chức năng xoá thông tin phụ huynh 1 SV");
                                    DeletePhuHuynh();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "7":
                                    Console.WriteLine("Bạn chọn chức năng cập hợp đồng thuê của sinh viên");
                                    UpdateHopDong();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "8":
                                    Console.WriteLine("Bạn chọn chức năng hiển thị thông tin 1 SV");
                                    HienThiSinhVien();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "9":
                                    Console.WriteLine("Bạn chọn chức năng hiển thị thông tin sinh viên trong 1 phòng");
                                    HienThiSVPhong();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "10":
                                    Console.WriteLine("Bạn chọn chức năng xuất theo thứ tự ");
                                    XuatThuTu();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "0":
                                    end_signal = false;
                                    Console.WriteLine("Đang trở lại menu chính! Nhấn phím bất kỳ để tiếp tục!");
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                default:
                                    Console.WriteLine("Không có chức năng này!");
                                    Console.WriteLine("Nhấn phím bất kỳ để tiếp tục");
                                    key = Console.ReadKey().KeyChar;
                                    break;
                            }
                        }
                        end_signal = true;
                        break;
                    case "3":
                        Console.Clear();
                        while (end_signal)
                        {
                            Console.Clear();
                            Console.WriteLine("                     ========== Chức năng quản lý dịch vụ  ==========");
                            Console.WriteLine("                     ==      [1] Thêm ghi chú dịch vụ 1 SV         ==");
                            Console.WriteLine("                     ==      [2] Sửa ghi chú dịch vụ 1 SV          ==");
                            Console.WriteLine("                     ==      [3] Xoá ghi chú dịch vụ 1 SV          ==");
                            Console.WriteLine("                     ==      [4] Thêm ghi chú dịch vụ 1 phòng      ==");
                            Console.WriteLine("                     ==      [5] Sửa ghi chú dịch vụ 1 phòng       ==");
                            Console.WriteLine("                     ==      [6] Xoá ghi chú dịch vụ 1 phòng       ==");
                            Console.WriteLine("                     ==      [0] Quay lại                          ==");
                            Console.WriteLine("                     ================================================");
                            Console.Write("                         Mời bạn chọn chức năng chương trình: ");
                            option = Console.ReadLine();
                            //Console.WriteLine(option);
                            Console.WriteLine();
                            switch (option)
                            {
                                case "1":
                                    Console.WriteLine("Bạn chọn chức năng thêm ghi chú dịch vụ 1 SV");
                                    AddDichVuRieng();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "2":
                                    Console.WriteLine("Bạn chọn chức năng sửa ghi chú dịch vụ 1 SV");
                                    UpdateDichVuRieng();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "3":
                                    Console.WriteLine("Bạn chọn chức năng xoá ghi chú dịch vụ 1 SV");
                                    DeleteDichVuRieng();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "4":
                                    Console.WriteLine("Bạn chọn chức năng thêm chú dịch vụ 1 phòng");
                                    AddDichVuChung();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "5":
                                    Console.WriteLine("Bạn chọn chức năng sửa chú dịch vụ 1 phòng");
                                    UpdateDichVuChung();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "6":
                                    Console.WriteLine("Bạn chọn chức năng xoá chú dịch vụ 1 phòng");
                                    DeleteDichVuChung();
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                case "0":
                                    end_signal = false;
                                    Console.WriteLine("Đang trở lại menu chính! Nhấn phím bất kỳ để tiếp tục!");
                                    key = Console.ReadKey().KeyChar;
                                    break;
                                default:
                                    Console.WriteLine("Không có chức năng này!");
                                    Console.WriteLine("Nhấn phím bất kỳ để tiếp tục");
                                    key = Console.ReadKey().KeyChar;
                                    break;
                            }
                        }
                        end_signal = true;
                        break;
                    case "0":
                        Console.WriteLine("Đã thoát chương trình!");
                        return;
                    default:
                        Console.WriteLine("Không có chức năng này!");
                        Console.WriteLine("Nhấn phím bất kỳ để tiếp tục");
                        key = Console.ReadKey().KeyChar;
                        Console.Clear();
                        break;
                }
            }
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
            //HienThiPhong();
            //HienThiNoiThat();
            //HienThiPhi();
            //TinhTienDien(id_phong, thang);
            //TinhTienNuoc(id_phong, thang);
            //TinhTienPhi(id_phong);
            //UpdatePhi();

            // Các hàm cho Sinh Viên
            //AddSinhVien();
            //DeleteSinhVien();
            //UpdateSinhVien();
            //UpdateHopDong();
            //DeleteByIdPhong();
            //DeletePhuHuynh();
            //AddPhuHuynh();
            //UpdatePhuHuynh();
            //HienThiSinhVien();
            //HienThiSVPhong();

            // Các hàm cho Dịch Vụ
            //AddDichVuRieng();
            //UpdateDichVuRieng();
            //DeleteDichVuRieng();
            //AddDichVuChung();
            //UpdateDichVuChung();
            //DeleteDichVuChung();
            //TinhTienDVC(id_phong, thang);
            //TinhTienDVR(id_sinhvien, thang);

        }

        // Hàm check date có đúng hay không
        public static bool IsDate(string tempDate)
        {
            DateTime fromDateValue;
            var formats = new[] { "yyyy/MM/dd", "yyyy-MM-dd" };
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
                Console.Write("Ngày sinh (yyyy/mm/dd): ");
                temp.NgaySinh = Console.ReadLine();
                if (IsDate(temp.NgaySinh))
                    break;
                Console.WriteLine("Ngày tháng không hợp lệ!");
            }

            Console.Write("Giới tính (1 = Nam, 0 = Nữ): ");
            temp.GioiTinh = Console.ReadLine();
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
                Console.Write("Ngày sinh (yyyy/mm/dd): ");
                temp.NgaySinh = Console.ReadLine();
                if (IsDate(temp.NgaySinh))
                    break;
                Console.WriteLine("Ngày tháng không hợp lệ!");
            }
            Console.Write("Giới tính (1 = Nam, 0 = Nữ): ");
            temp.GioiTinh = Console.ReadLine();
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
            Console.Write("Nhập ID sinh viên muốn thêm thông tin phụ huynh: ");
            id = int.Parse(Console.ReadLine());
            CAUTRUC.NGUOI temp = new CAUTRUC.NGUOI();
            Console.Write("Tên phụ huynh: ");
            temp.HoTen = Console.ReadLine();
            while (true)
            {
                Console.Write("Ngày sinh (yyyy/mm/dd): ");
                temp.NgaySinh = Console.ReadLine();
                if (IsDate(temp.NgaySinh))
                    break;
                Console.WriteLine("Ngày tháng không hợp lệ!");
            }

            Console.Write("Giới tính (1 = Nam, 0 = Nữ): ");
            temp.GioiTinh = Console.ReadLine();
            Console.Write("Quê quán: ");
            temp.QueQuan = Console.ReadLine();
            Console.Write("Nghề nghiệp: ");
            temp.NgheNghiep = Console.ReadLine();
            Console.Write("SĐT: ");
            temp.SDT = Console.ReadLine();

            bool status = SinhVienDAO.Instance.AddPhuHuynh(temp, id);
            if (status)
                Console.WriteLine("Add successful!");
            else Console.WriteLine("Add failed!");
        }
        // Hàm Delete sinh viên khỏi database
        static void DeletePhuHuynh()
        {
            int id_sinhvien;
            Console.Write("Nhập ID sinh viên bạn muốn xoá phụ huynh: ");
            id_sinhvien = int.Parse(Console.ReadLine());
            bool status = SinhVienDAO.Instance.DeletePhuHuynh(id_sinhvien);
            if (status)
                Console.WriteLine("Delete successful!");
            else Console.WriteLine("Delete failed!");
        }
        // Hàm Update phụ huynh sinh viên trong database
        static void UpdatePhuHuynh()
        {
            int id;
            Console.Write("Nhập ID sinh viên: ");
            id = int.Parse(Console.ReadLine());
            CAUTRUC.NGUOI temp = new CAUTRUC.NGUOI();
            Console.Write("Tên phụ huynh: ");
            temp.HoTen = Console.ReadLine();
            while (true)
            {
                Console.Write("Ngày sinh (yyyy/mm/dd): ");
                temp.NgaySinh = Console.ReadLine();
                if (IsDate(temp.NgaySinh))
                    break;
                Console.WriteLine("Ngày tháng không hợp lệ!");
            }
            Console.Write("Giới tính (1 = Nam, 0 = Nữ): ");
            temp.GioiTinh = Console.ReadLine();
            Console.Write("Quê quán: ");
            temp.QueQuan = Console.ReadLine();
            Console.Write("Nghề nghiệp: ");
            temp.NgheNghiep = Console.ReadLine();
            Console.Write("SĐT: ");
            temp.SDT = Console.ReadLine();
            bool status = SinhVienDAO.Instance.UpdatePhuHuynh(temp, id);
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
            Console.WriteLine("Dữ liệu đầu vào là yyyy/mm/dd!");
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
        // Hàm hiển thị sinh viên theo id
        static void HienThiSinhVien()
        {
            int id_sinhvien;
            while (true)
            {
                Console.Write("Nhập ID sinh viên: ");
                id_sinhvien = int.Parse(Console.ReadLine());

                if (IsExistSinhVienID(id_sinhvien))
                    break;
                Console.WriteLine("Không tồn tại ID sinh viên này!");
            }
            List<SINHVIEN> sinhvien = SinhVienDAO.Instance.HienThiSinhVien(id_sinhvien);

            if (sinhvien.Count == 0)
                Console.WriteLine("Không tìm thấy bất cứ sinh viên nào!");
            else
            {
                Console.WriteLine("Giới tính True là nam, False là nữ");
                foreach (SINHVIEN temp in sinhvien)
                {
                    Console.WriteLine("ID phòng: " + Convert.ToString(temp.IDPhong));
                    Console.WriteLine("Họ tên: " + Convert.ToString(temp.HoTen));
                    Console.WriteLine("Ngày sinh : " + Convert.ToString(temp.NgaySinh));
                    Console.WriteLine("Giới tính: " + Convert.ToString(temp.GioiTinh));
                    Console.WriteLine("Quê quán: " + Convert.ToString(temp.QueQuan));
                    Console.WriteLine("Nghề nghiệp: " + Convert.ToString(temp.NgheNghiep));
                    Console.WriteLine("SĐT: " + Convert.ToString(temp.SDT));
                    Console.WriteLine("BHYT: " + Convert.ToString(temp.BHYT));
                    Console.WriteLine("Nơi làm việc: " + Convert.ToString(temp.NoiLamViec));
                    Console.WriteLine("Hộ khẩu: " + Convert.ToString(temp.DiaChiHK));
                    Console.WriteLine("Sinh viên năm thứ: " + Convert.ToString(temp.SVNam));
                    Console.WriteLine("Ngày kí hợp đồng: " + Convert.ToString(temp.HopDongStart));
                    Console.WriteLine("Ngày hết hạn hợp đồng: " + Convert.ToString(temp.HopDongEnd));
                }
            }
        }
        // Hàm hiển thị sinh viên theo id phòng

        static void XuatThuTu()
        {
            int sosinhvien = 0;
            SINHVIEN[] sinhvien = SinhVienDAO.Instance.XuatThuTu();

            if (sinhvien[0] == null)
                Console.WriteLine("Danh sách sinh viên hiện tại rỗng!");
            else
            {
                Console.Clear();
                Console.WriteLine("Danh sách sinh viên hiện tại: ");
                Console.WriteLine("Giới tính True là nam, False là nữ");
                foreach (SINHVIEN temp in sinhvien)
                {
                    if (temp == null)
                        break;
                    sosinhvien++;
                    Console.WriteLine("Hoc sinh thứ " + sosinhvien + ":");
                    Console.WriteLine("     ID phòng: " + Convert.ToString(temp.IDPhong));
                    Console.WriteLine("     Họ tên: " + Convert.ToString(temp.HoTen));
                    Console.WriteLine("     Ngày sinh : " + Convert.ToString(temp.NgaySinh));
                    Console.WriteLine("     Giới tính: " + Convert.ToString(temp.GioiTinh));
                    Console.WriteLine("     Quê quán: " + Convert.ToString(temp.QueQuan));
                    Console.WriteLine("     Nghề nghiệp: " + Convert.ToString(temp.NgheNghiep));
                    Console.WriteLine("     SĐT: " + Convert.ToString(temp.SDT));
                    Console.WriteLine("     BHYT: " + Convert.ToString(temp.BHYT));
                    Console.WriteLine("     Nơi làm việc: " + Convert.ToString(temp.NoiLamViec));
                    Console.WriteLine("     Hộ khẩu: " + Convert.ToString(temp.DiaChiHK));
                    Console.WriteLine("     Sinh viên năm thứ: " + Convert.ToString(temp.SVNam));
                    Console.WriteLine("     Ngày kí hợp đồng: " + Convert.ToString(temp.HopDongStart));
                    Console.WriteLine("     Ngày hết hạn hợp đồng: " + Convert.ToString(temp.HopDongEnd));
                }
            }
            string option = "";
            while (option != "0")
            {
                Console.WriteLine("Chọn thứ tự muốn sắp xếp ");
                Console.WriteLine("     1. Xuất theo thứ tự phòng");
                Console.WriteLine("     2. Xuất theo thứ tự ngày hết hợp đồng");
                Console.WriteLine("     3. Xuất theo thứ tự niên khoá của sinh viên");
                Console.WriteLine("     0. Huỷ lệnh");
                Console.Write("Chọn lệnh: ");
                option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Danh sách không thay đổi!");
                        break;
                    case "1":
                        //bubble sort 
                        bool check = false;
                        for (int i = 0; i < sosinhvien - 1; i++)
                        {
                            check = false;
                            for (int j = 0; j < sosinhvien - i - 1; j++)
                                if (sinhvien[j].IDPhong > sinhvien[j + 1].IDPhong)
                                {
                                    SINHVIEN temp = sinhvien[j];
                                    sinhvien[j] = sinhvien[j+1];
                                    sinhvien[j+1] = temp;
                                    check = true;
                                }
                            if (check == false)
                                break;
                        }
                        option = "0";
                        break;
                    case "2":
                        //Selection sort
                        int min;
                        for (int i = 0; i < sosinhvien - 1; i++)
                        {
                            min = i;
                            for (int j = i + 1; j < sosinhvien; j++)
                                if (DateTime.Compare(Convert.ToDateTime(sinhvien[j].HopDongEnd), Convert.ToDateTime(sinhvien[min].HopDongEnd))<0)
                                    min = j;
                            if (min != i)
                            {
                                SINHVIEN temp = sinhvien[i];
                                sinhvien[i] = sinhvien[min];
                                sinhvien[min] = temp;
                            }
                        }
                        option = "0";
                        break;
                    case "3":
                        //Insertion Sort
                        SINHVIEN  x;
                        int pos;
                        for (int i = 1; i < sosinhvien; i++)
                        { 
                            x = sinhvien[i];
                            pos = i;
                            while (pos > 0 && x.SVNam < sinhvien[pos - 1].SVNam)
                            {
                                sinhvien[pos] = sinhvien[pos - 1];  // dời chỗ
                                pos--;
                            }
                            sinhvien[pos] = x;
                        }
                        option = "0";
                        break;
                    default:
                        Console.WriteLine("Lệnh không tồn tại");
                        break;
                }
                sosinhvien = 0;
                Console.Clear();
                foreach (SINHVIEN temp in sinhvien)
                {
                    if (temp == null)
                        break;
                    sosinhvien++;
                    Console.WriteLine("Học sinh thứ " + sosinhvien + ":");
                    Console.WriteLine("     ID phòng: " + Convert.ToString(temp.IDPhong));
                    Console.WriteLine("     Họ tên: " + Convert.ToString(temp.HoTen));
                    Console.WriteLine("     Ngày sinh : " + Convert.ToString(temp.NgaySinh));
                    Console.WriteLine("     Giới tính: " + Convert.ToString(temp.GioiTinh));
                    Console.WriteLine("     Quê quán: " + Convert.ToString(temp.QueQuan));
                    Console.WriteLine("     Nghề nghiệp: " + Convert.ToString(temp.NgheNghiep));
                    Console.WriteLine("     SĐT: " + Convert.ToString(temp.SDT));
                    Console.WriteLine("     BHYT: " + Convert.ToString(temp.BHYT));
                    Console.WriteLine("     Nơi làm việc: " + Convert.ToString(temp.NoiLamViec));
                    Console.WriteLine("     Hộ khẩu: " + Convert.ToString(temp.DiaChiHK));
                    Console.WriteLine("     Sinh viên năm thứ: " + Convert.ToString(temp.SVNam));
                    Console.WriteLine("     Ngày kí hợp đồng: " + Convert.ToString(temp.HopDongStart));
                    Console.WriteLine("     Ngày hết hạn hợp đồng: " + Convert.ToString(temp.HopDongEnd));
                }
            }
            

        }
        // Hàm hiển thị sinh viên theo id phòng
        static void HienThiSVPhong()
        {
            int id_phong;
            while (true)
            {
                Console.Write("Nhập ID phòng muốn xem danh sách sinh viên: ");
                id_phong = int.Parse(Console.ReadLine());

                if (IsExistPhongID(id_phong))
                    break;
                Console.WriteLine("Không tồn tại ID phòng này!");
            }
            List<SINHVIEN> sinhvien = SinhVienDAO.Instance.HienThiSVPhong(id_phong);

            if (sinhvien.Count == 0)
                Console.WriteLine("Không tìm thấy bất cứ sinh viên nào!");
            else
            {
                Console.WriteLine("| ID sinh viên |          Họ tên          |        SĐT        |");
                foreach (SINHVIEN temp in sinhvien)
                {
                    Console.Write(Convert.ToString(temp.IDSinhVien).PadLeft(8));
                    Console.Write(Convert.ToString(temp.HoTen).PadLeft(28));
                    Console.WriteLine(Convert.ToString(temp.SDT).PadLeft(18));
                }
            }
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
            Console.WriteLine("Số người ở hiện tại: " + phong.SoNguoi);
            Console.Write("Diện tích: ");
            phong.DienTich = double.Parse(Console.ReadLine());
            Console.Write("Giá thuê: ");
            phong.GiaThue = double.Parse(Console.ReadLine());
            phong.TongThu = TinhTienPhi(phong.IDPhong);
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
            while (true)
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
        // Hàm hiển thị tất cả các phòng có trong database
        static void HienThiPhong()
        {
            List<PHONG> phong = PhongDAO.Instance.HienThiPhong();

            if (phong.Count == 0)
                Console.WriteLine("Không tìm thấy bất cứ phòng nào!");
            else
            {
                Console.WriteLine("Tổng số phòng có trong database là: " + phong.Count);
                Console.WriteLine("| ID phòng |  Tên  | Khu | Tầng | Sức chứa | Số người | Diện tích | Giá thuê |");
                foreach (PHONG temp in phong)
                {
                    Console.Write(Convert.ToString(temp.IDPhong).PadLeft(6));
                    Console.Write(Convert.ToString(temp.TenPhong).PadLeft(11));
                    Console.Write(Convert.ToString(temp.Khu).PadLeft(6));
                    Console.Write(Convert.ToString(temp.Tang).PadLeft(6));
                    Console.Write(Convert.ToString(temp.SucChua).PadLeft(8));
                    Console.Write(Convert.ToString(temp.SoNguoi).PadLeft(12));
                    Console.Write(Convert.ToString(temp.DienTich).PadLeft(12));
                    Console.WriteLine(Convert.ToString(temp.GiaThue).PadLeft(14));
                }
            }
        }
        // Hàm hiển thị nội thất của phòng theo id
        static void HienThiNoiThat()
        {
            int id_phong;
            while (true)
            {
                Console.Write("Nhập ID phòng muốn xem nội thất: ");
                id_phong = int.Parse(Console.ReadLine());

                if (IsExistPhongID(id_phong))
                    break;
                Console.WriteLine("Không tồn tại ID phòng này!");
            }
            List<CAUTRUC.NT> noithat = PhongDAO.Instance.HienThiNoiThat(id_phong);
            if (noithat.Count == 0)
                Console.WriteLine("Không tìm thấy bất cứ nội thất nào!");
            else
            {
                Console.WriteLine("Tổng số nội thất có trong phòng là: " + noithat.Count);
                Console.WriteLine("Tình trạng False là bình thường, True là có hư hỏng");
                foreach (CAUTRUC.NT temp in noithat)
                {
                    Console.Write("Tên nội thất: ");
                    Console.Write(Convert.ToString(temp.Ten) + "  ");
                    Console.Write("Số lượng: ");
                    Console.Write(Convert.ToString(temp.SoLuong) + "  ");
                    Console.Write("Tình trạng: ");
                    Console.WriteLine(Convert.ToString(temp.TinhTrang));
                }
            }
        }
        // Hàm hiển thị tất cả phí thu tháng các phòng
        static void HienThiPhi()
        {
            List<PHONG> phong = PhongDAO.Instance.HienThiPhi();

            if (phong.Count == 0)
                Console.WriteLine("Không tìm thấy bất cứ phòng nào!");
            else
            {
                Console.WriteLine("Tổng số phòng có trong database là: " + phong.Count);
                Console.WriteLine("| ID phòng |  Tên  | Khu | Tầng | Phí thu tháng này |");
                foreach (PHONG temp in phong)
                {
                    Console.Write(Convert.ToString(temp.IDPhong).PadLeft(6));
                    Console.Write(Convert.ToString(temp.TenPhong).PadLeft(11));
                    Console.Write(Convert.ToString(temp.Khu).PadLeft(6));
                    Console.Write(Convert.ToString(temp.Tang).PadLeft(6));
                    Console.WriteLine(Convert.ToString(temp.TongThu).PadLeft(14));
                }
            }
        }
        // Hàm tính tiền điện theo id phòng và tháng
        static int TinhTienDien(int id_phong, int thang)
        {
            int tien_dv = PhongDAO.Instance.TinhTienDien(id_phong, thang);
            return tien_dv;
        }
        // Hàm tính tiền nước theo id phòng và tháng
        static int TinhTienNuoc(int id_phong, int thang)
        {
            int tien_dv = PhongDAO.Instance.TinhTienNuoc(id_phong, thang);
            return tien_dv;
        }
        // Hàm tính tiền phí thu theo id phòng và tháng
        static int TinhTienPhi(int id_phong)
        {
            int thang;
            Console.Write("Nhập tháng muốn tính phí thu: ");
            thang = int.Parse(Console.ReadLine());
            int thanh_tien_DV = DichVuDAO.Instance.TinhTienDichVuChung(id_phong, thang);
            int thanh_tien_dien = PhongDAO.Instance.TinhTienDien(id_phong, thang);
            int thanh_tien_nuoc = PhongDAO.Instance.TinhTienNuoc(id_phong, thang);
            int sum = thanh_tien_DV + thanh_tien_dien + thanh_tien_nuoc;
            return sum;
        }
        // Hàm Update thông tin tiền phí
        static void UpdatePhi()
        {
            int id_phong, thang;
            while (true)
            {
                Console.Write("Nhập ID phòng muốn cập nhật thông tin phí thu: ");
                id_phong = int.Parse(Console.ReadLine());

                if (IsExistPhongID(id_phong))
                    break;
                Console.WriteLine("Không tồn tại ID phòng này!");
            }
            Console.Write("Nhập tháng muốn tính phí thu: ");
            thang = int.Parse(Console.ReadLine());
            int thanh_tien_DV = DichVuDAO.Instance.TinhTienDichVuChung(id_phong, thang);
            int thanh_tien_dien = PhongDAO.Instance.TinhTienDien(id_phong, thang);
            int thanh_tien_nuoc = PhongDAO.Instance.TinhTienNuoc(id_phong, thang);
            int sum = thanh_tien_DV + thanh_tien_dien + thanh_tien_nuoc;
            bool status = PhongDAO.Instance.UpdatePhi(id_phong, sum);
            if (status)
                Console.WriteLine("Update successful!");
            else Console.WriteLine("Update failed!");
        }


        // DICHVU
        // Hàm Add dịch vụ của sinh viên
        static void AddDichVuRieng()
        {
            int id_sinhvien;
            while (true)
            {
                Console.Write("Nhập ID sinh viên bạn muốn thêm dịch vụ: ");
                id_sinhvien = int.Parse(Console.ReadLine());

                if (IsExistSinhVienID(id_sinhvien))
                    break;
                Console.WriteLine("Không tồn tại ID sinh viên này!");
            }
            int thang;
            Console.Write("Nhập tháng: ");
            thang = int.Parse(Console.ReadLine());
            int dich_vu_1;
            Console.Write("Nhập số lần dùng dịch vụ 1: ");
            dich_vu_1 = int.Parse(Console.ReadLine());
            int dich_vu_2;
            Console.Write("Nhập số lần dùng dịch vụ 2: ");
            dich_vu_2 = int.Parse(Console.ReadLine());
            int dich_vu_3;
            Console.Write("Nhập số lần dùng dịch vụ 3: ");
            dich_vu_3 = int.Parse(Console.ReadLine());
            int thanhtien;
            thanhtien = dich_vu_1 * DICHVU.DVCaNhan.GiaDV1 + dich_vu_2 * DICHVU.DVCaNhan.GiaDV2 + dich_vu_3 * DICHVU.DVCaNhan.GiaDV3;

            bool status = DichVuDAO.Instance.AddDichVuRieng(id_sinhvien, thang, dich_vu_1, dich_vu_2, dich_vu_3, thanhtien);
            if (status)
                Console.WriteLine("Add successful!");
            else Console.WriteLine("Add failed!");
        }
        // Hàm Update dịch vụ của sinh viên
        static void UpdateDichVuRieng()
        {
            int id_sinhvien;
            while (true)
            {
                Console.Write("Nhập ID sinh viên bạn muốn cập nhật dịch vụ: ");
                id_sinhvien = int.Parse(Console.ReadLine());

                if (IsExistSinhVienID(id_sinhvien))
                    break;
                Console.WriteLine("Không tồn tại ID sinh viên này!");
            }
            int thang;
            Console.Write("Nhập tháng: ");
            thang = int.Parse(Console.ReadLine());
            int dich_vu_1;
            Console.Write("Nhập số lần dùng dịch vụ 1: ");
            dich_vu_1 = int.Parse(Console.ReadLine());
            int dich_vu_2;
            Console.Write("Nhập số lần dùng dịch vụ 2: ");
            dich_vu_2 = int.Parse(Console.ReadLine());
            int dich_vu_3;
            Console.Write("Nhập số lần dùng dịch vụ 3: ");
            dich_vu_3 = int.Parse(Console.ReadLine());
            int thanhtien;
            thanhtien = dich_vu_1 * DICHVU.DVCaNhan.GiaDV1 + dich_vu_2 * DICHVU.DVCaNhan.GiaDV2 + dich_vu_3 * DICHVU.DVCaNhan.GiaDV3;
            bool status = DichVuDAO.Instance.UpdateDichVuRieng(id_sinhvien, thang, dich_vu_1, dich_vu_2, dich_vu_3, thanhtien);
            if (status)
                Console.WriteLine("Update successful!");
            else Console.WriteLine("Update failed!");
        }
        // Hàm Delete dịch vụ sinh viên
        static void DeleteDichVuRieng()
        {
            int id_sinhvien, thang;
            while (true)
            {
                Console.Write("Nhập ID sinh viên bạn muốn xoá dịch vụ: ");
                id_sinhvien = int.Parse(Console.ReadLine());

                if (IsExistSinhVienID(id_sinhvien))
                    break;
                Console.WriteLine("Không tồn tại ID sinh viên này!");
            }
            Console.Write("Nhập tháng dịch vụ muốn xoá: ");
            thang = int.Parse(Console.ReadLine());
            bool status = DichVuDAO.Instance.DeleteDichVuRieng(id_sinhvien, thang);
            if (status)
                Console.WriteLine("Delete successful!");
            else Console.WriteLine("Delete failed!");
        }
        // Hàm Add dịch vụ của phòng
        static void AddDichVuChung()
        {
            int id_phong;
            while (true)
            {
                Console.Write("Nhập ID phòng bạn muốn thêm dịch vụ: ");
                id_phong = int.Parse(Console.ReadLine());

                if (IsExistPhongID(id_phong))
                    break;
                Console.WriteLine("Không tồn tại ID phòng này!");
            }
            int thang;
            Console.Write("Nhập tháng: ");
            thang = int.Parse(Console.ReadLine());
            int dich_vu_1;
            Console.Write("Nhập số lần sử dụng dịch vụ 1: ");
            dich_vu_1 = int.Parse(Console.ReadLine());
            int dich_vu_2;
            Console.Write("Nhập số lần sử dụng dịch vụ 2: ");
            dich_vu_2 = int.Parse(Console.ReadLine());
            int thanhtien;
            thanhtien = dich_vu_1 * DICHVU.DVChung.GiaDV1 + dich_vu_2 * DICHVU.DVChung.GiaDV2;

            bool status = DichVuDAO.Instance.AddDichVuChung(id_phong, thang, dich_vu_1, dich_vu_2, thanhtien);
            if (status)
                Console.WriteLine("Add successful!");
            else Console.WriteLine("Add failed!");
        }
        // Hàm Update dịch vụ của phòng
        static void UpdateDichVuChung()
        {
            int id_phong;
            while (true)
            {
                Console.Write("Nhập ID phòng bạn muốn cập nhật dịch vụ: ");
                id_phong = int.Parse(Console.ReadLine());

                if (IsExistPhongID(id_phong))
                    break;
                Console.WriteLine("Không tồn tại ID phòng này!");
            }
            int thang;
            Console.Write("Nhập tháng: ");
            thang = int.Parse(Console.ReadLine());
            int dich_vu_1;
            Console.Write("Nhập số lần sử dụng dịch vụ 1: ");
            dich_vu_1 = int.Parse(Console.ReadLine());
            int dich_vu_2;
            Console.Write("Nhập số lần sử dụng dịch vụ 2: ");
            dich_vu_2 = int.Parse(Console.ReadLine());
            int thanhtien;
            thanhtien = dich_vu_1 * DICHVU.DVChung.GiaDV1 + dich_vu_2 * DICHVU.DVChung.GiaDV2;

            bool status = DichVuDAO.Instance.UpdateDichVuChung(id_phong, thang, dich_vu_1, dich_vu_2, thanhtien);
            if (status)
                Console.WriteLine("Update successful!");
            else Console.WriteLine("Update failed!");
        }
        // Hàm Delete dịch vụ phòng
        static void DeleteDichVuChung()
        {
            int id_phong, thang;
            while (true)
            {
                Console.Write("Nhập ID phòng bạn muốn xoá dịch vụ: ");
                id_phong = int.Parse(Console.ReadLine());

                if (IsExistPhongID(id_phong))
                    break;
                Console.WriteLine("Không tồn tại ID sinh viên này!");
            }
            Console.Write("Nhập tháng dịch vụ muốn xoá: ");
            thang = int.Parse(Console.ReadLine());
            bool status = DichVuDAO.Instance.DeleteDichVuChung(id_phong, thang);
            if (status)
                Console.WriteLine("Delete successful!");
            else Console.WriteLine("Delete failed!");
        }
        // Hàm tính thành tiền dịch vụ của phòng theo id và tháng
        static int TinhTienDVC(int id_phong, int thang)
        {
            int tien_dv = DichVuDAO.Instance.TinhTienDichVuChung(id_phong, thang);
            return tien_dv;
        }
        // Hàm tính thành tiền dịch vụ của sinh viên theo id và tháng
        static int TinhTienDVR(int id_sinhvien, int thang)
        {
            int tien_dv = DichVuDAO.Instance.TinhTienDichVuRieng(id_sinhvien, thang);
            return tien_dv;
        }
    }
}
