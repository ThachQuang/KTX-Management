using KTX_Management.Entities;
using KTX_Management.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTX_Management.DAO
{
    internal class SinhVienDAO : ISinhVienDAO
    {
        private static SinhVienDAO instance;
        public static SinhVienDAO Instance
        {
            get { if (instance == null) instance = new SinhVienDAO(); return SinhVienDAO.instance; }
            private set { SinhVienDAO.instance = value; }
        }
        private SinhVienDAO() { }

        const string ADD_SINHVIEN = @"SP_Add_SinhVien @id_phong , @ten , @ngay_sinh , @gioi_tinh , @que_quan , @nghe_nghiep , @sdt , @cmnd , @bhyt , @noi_lam_viec , @ho_khau , @sv_nam , @hop_dong_start , @hop_dong_end";


        public bool AddSinhVien(SINHVIEN sinhvien)
        {
            try
            {
                object[] Para = new object[] { sinhvien.IDPhong,
                                               sinhvien.SinhVien.HoTen,
                                               sinhvien.SinhVien.NgaySinh,
                                               sinhvien.SinhVien.GioiTinh,
                                               sinhvien.SinhVien.QueQuan,
                                               sinhvien.SinhVien.NgheNghiep,
                                               sinhvien.SinhVien.SDT,
                                               sinhvien.CMND,
                                               sinhvien.BHYT,
                                               sinhvien.NoiLamViec,
                                               sinhvien.DiaChiHK,
                                               sinhvien.SVNam,
                                               sinhvien.HopDongStart,
                                               sinhvien.HopDongEnd };

                return DataProvider.Instance.ExecuteNonQuery(ADD_SINHVIEN, Para) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteSinhVien(SINHVIEN sinhvien)
        {
            return ((ISinhVienDAO)instance).DeleteSinhVien(sinhvien);
        }

        public bool UpdateSinhVien(SINHVIEN sinhvien)
        {
            return ((ISinhVienDAO)instance).UpdateSinhVien(sinhvien);
        }
    }
}
