using KTX_Management.Dao;
using KTX_Management.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTX_Management.DAO
{
    class PhongDAO
    {
        // Make class PhongDAO instance
        // Đây là code bắt buộc phải có để có thể gọi hàm tương tác database từ Main
        private static PhongDAO instance;
        public static PhongDAO Instance
        {
            get { if (instance == null) instance = new PhongDAO(); return PhongDAO.instance; }
            private set { PhongDAO.instance = value; }
        }
        private PhongDAO() { }
        // Các chuỗi chứa câu lệnh thực thi procedure sql
        const string ADD_PHONG = @"SP_Add_Phong @ten , @khu , @tang , @suc_chua , @so_nguoi , @dien_tich , @gia_thue , @phi_thu_thang";
        const string DELETE_PHONG = @"SP_Delete_Phong @id_phong";
        const string UPDATE_PHONG = @"SP_Update_Phong @id_phong , @ten , @khu , @tang , @suc_chua , @so_nguoi , @dien_tich , @gia_thue , @phi_thu_thang";
        // Hàm tương tác với database
        public bool AddPhong(PHONG phong)
        {
            try
            {
                object[] Para = new object[] { phong.TenPhong,
                                               phong.Khu,
                                               phong.Tang,
                                               phong.SucChua,
                                               phong.SoNguoi,
                                               phong.DienTich,
                                               phong.GiaThue,
                                               phong.TongThu };

                return DataProvider.Instance.ExecuteNonQuery(ADD_PHONG, Para) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeletePhong(int id_phong)
        {
            try
            {
                object[] Para = new object[] { id_phong };

                return DataProvider.Instance.ExecuteNonQuery(DELETE_PHONG, Para) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdatePhong(PHONG phong)
        {
            try
            {
                object[] Para = new object[] { phong.IDPhong,
                                               phong.TenPhong,
                                               phong.Khu,
                                               phong.Tang,
                                               phong.SucChua,
                                               phong.SoNguoi,
                                               phong.DienTich,
                                               phong.GiaThue,
                                               '0' };

                return DataProvider.Instance.ExecuteNonQuery(UPDATE_PHONG, Para) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /*bool AddNoiThat(int id_phong, CAUTRUC.NT noithat);
        bool DeleteNoiThat(int id_phong);
        bool UpdateNoiThat(int id_phong, CAUTRUC.NT noithat);
        bool AddDien(int id_phong, int thang, CAUTRUC.DIENNUOC dien);
        bool DeleteDien(int id_phong, int thang);
        bool UpdateDien(int id_phong, int thang, CAUTRUC.DIENNUOC dien);
        bool AddNuoc(int id_phong, int thang, CAUTRUC.DIENNUOC nuoc);
        bool DeleteNuoc(int id_phong, int thang);
        bool UpdateNuoc(int id_phong, int thang, CAUTRUC.DIENNUOC nuoc);
        */
    }
}
