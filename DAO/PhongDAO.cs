using KTX_Management.Dao;
using KTX_Management.Entities;
using System;
using System.Collections.Generic;
using System.Data;
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
        const string GET_ALL_PHI = @"SELECT DISTINCT id_phong, ten_phong, khu, tang, phi_thu_thang FROM PHONG";
        const string GET_ALL_PHONG = @"SELECT DISTINCT id_phong, ten_phong, khu, tang, suc_chua, so_nguoi, dien_tich, gia_thue, phi_thu_thang FROM PHONG";
        const string GET_NOI_THAT = @"SELECT DISTINCT ten_noi_that, so_luong, tinh_trang FROM NOITHAT WHERE NOITHAT.id_phong = @id_phong";
        const string ADD_PHONG = @"SP_Add_Phong @ten , @khu , @tang , @suc_chua , @so_nguoi , @dien_tich , @gia_thue , @phi_thu_thang";
        const string DELETE_PHONG = @"SP_Delete_Phong @id_phong";
        const string UPDATE_PHONG = @"SP_Update_Phong @id_phong , @ten , @khu , @tang , @suc_chua , @so_nguoi , @dien_tich , @gia_thue , @phi_thu_thang";
        const string ADD_NOITHAT = @"SP_Add_NoiThat @id_phong , @ten_noi_that , @so_luong , @tinh_trang";
        const string DELETE_NOITHAT = @"SP_Delete_NoiThat  @id_phong";
        const string COUNT_NOITHAT = "SELECT COUNT(id_phong) FROM NOITHAT WHERE id_phong = @id_phong";
        const string COUNT_HUHONG = "SELECT COUNT(id_phong) FROM NOITHAT WHERE NOITHAT.id_phong = @id_phong AND NOITHAT.tinh_trang = 1";
        const string FIX_NOITHAT = "UPDATE NOITHAT SET tinh_trang = @tinh_trang WHERE NOITHAT.id_phong = @id_phong AND NOITHAT.ten_noi_that = @ten_noi_that";
        const string ADD_DIEN = @"SP_Add_Dien @id_phong , @thang , @so_dau , @so_cuoi , @thanh_tien";
        const string ADD_NUOC = @"SP_Add_Nuoc @id_phong , @thang , @so_dau , @so_cuoi , @thanh_tien";
        const string DELETE_DIEN = @"SP_Delete_Dien @id_phong , @thang";
        const string DELETE_NUOC = @"SP_Delete_Nuoc @id_phong , @thang";
        const string TINH_TIEN_DIEN = @"select SUM(thanh_tien) FROM DIEN WHERE DIEN.thang = @thang AND DIEN.id_phong = @id_phong";
        const string TINH_TIEN_NUOC = @"select SUM(thanh_tien) FROM NUOC WHERE NUOC.thang = @thang AND NUOC.id_phong = @id_phong";
        const string UPDATE_PHI = @"SP_Update_Phi @id_phong , @phi_thu_thang";
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
        public bool AddDien(int id_phong, int thang, CAUTRUC.DIENNUOC phong)
        {
            try
            {
                object[] Para = new object[] { id_phong,
                                               thang,
                                               phong.SoDau,
                                               phong.SoCuoi,
                                               phong.ThanhTien };

                return DataProvider.Instance.ExecuteNonQuery(ADD_DIEN, Para) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AddNuoc(int id_phong, int thang, CAUTRUC.DIENNUOC phong)
        {
            try
            {
                object[] Para = new object[] { id_phong,
                                               thang,
                                               phong.SoDau,
                                               phong.SoCuoi,
                                               phong.ThanhTien };

                return DataProvider.Instance.ExecuteNonQuery(ADD_NUOC, Para) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteDien(int id_phong, int thang)
        {
            try
            {
                object[] Para = new object[] { id_phong,
                                               thang };

                return DataProvider.Instance.ExecuteNonQuery(DELETE_DIEN, Para) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteNuoc(int id_phong, int thang)
        {
            try
            {
                object[] Para = new object[] { id_phong,
                                               thang };

                return DataProvider.Instance.ExecuteNonQuery(DELETE_NUOC, Para) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<PHONG> HienThiPhong()
        {
            List<PHONG> phong = new List<PHONG>();

            DataTable Table = DataProvider.Instance.ExecuteQuery(GET_ALL_PHONG);

            foreach (DataRow row in Table.Rows)
            {
                PHONG temp = new PHONG
                {
                    IDPhong = Convert.ToInt32(row["id_phong"]),
                    TenPhong = Convert.ToString(row["ten_phong"]),
                    Khu = Convert.ToString(row["khu"]),
                    Tang = Convert.ToInt16(row["tang"]),
                    SucChua = Convert.ToInt16(row["suc_chua"]),
                    SoNguoi = Convert.ToInt16(row["so_nguoi"]),
                    DienTich = Convert.ToInt32(row["dien_tich"]),
                    GiaThue = Convert.ToInt32(row["gia_thue"]),
                    TongThu = Convert.ToInt32(row["phi_thu_thang"])
                };
                phong.Add(temp);
            }
            return phong;
        }
        public List<CAUTRUC.NT> HienThiNoiThat(int id_phong)
        {
            List<CAUTRUC.NT> noithat = new List<CAUTRUC.NT>();
            object[] Para = new object[] { id_phong };
            DataTable Table = DataProvider.Instance.ExecuteQuery(GET_NOI_THAT, Para);

            foreach (DataRow row in Table.Rows)
            {
                CAUTRUC.NT temp = new CAUTRUC.NT
                {
                    Ten = Convert.ToString(row["ten_noi_that"]),
                    SoLuong = Convert.ToInt16(row["so_luong"]),
                    TinhTrang = Convert.ToBoolean(row["tinh_trang"])
                };
                noithat.Add(temp);
            }
            return noithat;
        }
        public List<PHONG> HienThiPhi()
        {
            List<PHONG> phong = new List<PHONG>();

            DataTable Table = DataProvider.Instance.ExecuteQuery(GET_ALL_PHI);

            foreach (DataRow row in Table.Rows)
            {
                PHONG temp = new PHONG
                {
                    IDPhong = Convert.ToInt32(row["id_phong"]),
                    TenPhong = Convert.ToString(row["ten_phong"]),
                    Khu = Convert.ToString(row["khu"]),
                    Tang = Convert.ToInt16(row["tang"]),
                    TongThu = Convert.ToInt32(row["phi_thu_thang"])
                };
                phong.Add(temp);
            }
            return phong;
        }
        public int TinhTienDien(int id_phong, int thang)
        {
            object[] Para = new object[] { thang, id_phong };

            var thanh_tien = DataProvider.Instance.ExecuteScalar(TINH_TIEN_DIEN, Para);

            if (thanh_tien is DBNull)
                return 0;
            return Convert.ToInt32(thanh_tien);
        }
        public int TinhTienNuoc(int id_phong, int thang)
        {
            object[] Para = new object[] { thang, id_phong };

            var thanh_tien = DataProvider.Instance.ExecuteScalar(TINH_TIEN_NUOC, Para);

            if (thanh_tien is DBNull)
                return 0;
            return Convert.ToInt32(thanh_tien);
        }
        public bool UpdatePhi(int id_phong, int sum)
        {
            try
            {
                object[] Para = new object[] { id_phong, sum };

                return DataProvider.Instance.ExecuteNonQuery(UPDATE_PHI, Para) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
