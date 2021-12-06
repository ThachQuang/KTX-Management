﻿using KTX_Management.Dao;
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
        const string ADD_NOITHAT = @"SP_Add_NoiThat @id_phong , @ten_noi_that , @so_luong , @tinh_trang";
        const string DELETE_NOITHAT = @"SP_Delete_NoiThat  @id_phong";
        const string COUNT_NOITHAT = "SELECT COUNT(id_phong) FROM NOITHAT WHERE id_phong = @id_phong";
        const string COUNT_HUHONG = "SELECT COUNT(id_phong) FROM NOITHAT WHERE NOITHAT.id_phong = @id_phong AND NOITHAT.tinh_trang = 1";
        const string FIX_NOITHAT = "UPDATE NOITHAT SET tinh_trang = @tinh_trang WHERE NOITHAT.id_phong = @id_phong AND NOITHAT.ten_noi_that = @ten_noi_that";
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
                                               phong.TongThu };

                return DataProvider.Instance.ExecuteNonQuery(UPDATE_PHONG, Para) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AddNoiThat(int id_phong, CAUTRUC.NT noithat)
        {
            try
            {

                object[] Para = new object[] { id_phong,
                                               noithat.Ten,
                                               noithat.SoLuong,
                                               noithat.TinhTrang };

                return DataProvider.Instance.ExecuteNonQuery(ADD_NOITHAT, Para) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }    
        public bool DeleteNoiThat(int id_phong)
        {
            try
            {
                object[] Para = new object[] { id_phong };

                return DataProvider.Instance.ExecuteNonQuery(DELETE_NOITHAT, Para) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void CheckNoiThat(int id_phong)
        {
            object[] Para1 = new object[] { id_phong };
            var TotalNoiThat = DataProvider.Instance.ExecuteScalar(COUNT_NOITHAT, Para1);
            if (TotalNoiThat is DBNull)
                TotalNoiThat = 0;
            Convert.ToInt16(TotalNoiThat);
            object[] Para2 = new object[] { id_phong };
            var TotalHuHong = DataProvider.Instance.ExecuteScalar(COUNT_HUHONG, Para2);
            if (TotalHuHong is DBNull)
                TotalHuHong = 0;
            Convert.ToInt16(TotalHuHong);
            Console.WriteLine("Tổng số loại nội thất có trong phòng: " + TotalNoiThat);
            Console.WriteLine("Tổng số loại nội thất bị hư hỏng: " + TotalHuHong);
        }
        public bool FixNoiThat(int id_phong, string ten_noi_that, int tinh_trang)
        {
            //try
            {
                object[] Para = new object[] { tinh_trang, id_phong, ten_noi_that, };

                return DataProvider.Instance.ExecuteNonQuery(FIX_NOITHAT, Para) > 0;
            }
            /*catch (Exception)
            {
                return false;
            }*/
        }
        /*bool UpdateNoiThat(int id_phong, CAUTRUC.NT noithat);
        bool AddDien(int id_phong, int thang, CAUTRUC.DIENNUOC dien);
        bool DeleteDien(int id_phong, int thang);
        bool UpdateDien(int id_phong, int thang, CAUTRUC.DIENNUOC dien);
        bool AddNuoc(int id_phong, int thang, CAUTRUC.DIENNUOC nuoc);
        bool DeleteNuoc(int id_phong, int thang);
        bool UpdateNuoc(int id_phong, int thang, CAUTRUC.DIENNUOC nuoc);
        */
    }
}
