using KTX_Management.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTX_Management.DAO
{
    internal interface ISinhVienDAO
    {
        // Khai báo sơ lược các hàm tương tác với database
        int CountSinhVien(int id_phong);
        int IDPhong(int id_sinhvien);
        bool AddSinhVien(SINHVIEN sinhvien);
        bool DeleteSinhVien(int id_sinhvien);
        bool DeleteByIdPhong(int id_phong);
        bool UpdateSinhVien(SINHVIEN sinhvien);
        bool UpdateHopDong(SINHVIEN sinhvien);
        bool AddPhuHuynh(CAUTRUC.NGUOI phuhuynh, int id_sinhvien);
        bool DeletePhuHuynh(int id_phuhuynh);
        bool UpdatePhuHuynh(CAUTRUC.NGUOI phuhuynh, int id_sinhvien, int id_phuhuynh);
        List<CAUTRUC.NGUOI> HienThiPhuHuynh(int id_sinhvien);
        List<SINHVIEN> HienThiSinhVien(int id_sinhvien);
        List<SINHVIEN> HienThiSVPhong(int id_phong);
    }
}
