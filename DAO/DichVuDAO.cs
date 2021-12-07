using KTX_Management.Entities;
using KTX_Management.Dao;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace KTX_Management.DAO
{
    class DichVuDAO
    {
        private static DichVuDAO instance;
        public static DichVuDAO Instance
        {
            get { if (instance == null) instance = new DichVuDAO(); return DichVuDAO.instance; }
            private set { DichVuDAO.instance = value; }
        }
        private DichVuDAO() { }
        // Các chuỗi chứa câu lệnh thực thi procedure sql
        const string ADD_DICHVURIENG = @"SP_Add_DichVuRieng @id_sinhvien , @thang , @dich_vu_1 , @dich_vu_2 , @dich_vu_3 , @thanh_tien";
        const string DELETE_DICHVURIENG = @"SP_Delete_DichVuRieng @id_sinhvien , @thang";
        const string UPDATE_DICHVURIENG = @"SP_Update_DichVuRieng @id_sinhvien , @thang , @dich_vu_1 , @dich_vu_2 , @dich_vu_3 , @thanh_tien";
        const string TINH_TIEN_DVR = @"select SUM(thanh_tien) FROM DICHVURIENG WHERE DICHVURIENG.thang = @thang AND DICHVURIENG.id_sinhvien = @id_sinhvien";
        const string ADD_DICHVUCHUNG = @"SP_Add_DichVuChung @id_phong , @thang , @dich_vu_1 , @dich_vu_2 , @thanh_tien";
        const string DELETE_DICHVUCHUNG = @"SP_Delete_DichVuChung @id_phong , @thang";
        const string UPDATE_DICHVUCHUNG = @"SP_Update_DichVuChung @id_phong , @thang , @dich_vu_1 , @dich_vu_2 , @thanh_tien";
        const string TINH_TIEN_DVC = @"select SUM(thanh_tien) FROM DICHVUCHUNG WHERE DICHVUCHUNG.thang = @thang AND DICHVUCHUNG.id_phong = @id_phong";
        // Hàm tương tác với database

        public bool AddDichVuRieng(int id, int thang, int dich_vu_1, int dich_vu_2, int dich_vu_3,int thanh_tien )
        {
            try
            {
                object[] Para = new object[] {  id,
                                                thang,
                                                dich_vu_1,
                                                dich_vu_2,
                                                dich_vu_3,
                                                thanh_tien };

                return DataProvider.Instance.ExecuteNonQuery(ADD_DICHVURIENG, Para) > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool DeleteDichVuRieng(int id_sinhvien, int thang)
        {
            try
            {
                object[] Para = new object[] { id_sinhvien, thang };

                return DataProvider.Instance.ExecuteNonQuery(DELETE_DICHVURIENG, Para) > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool UpdateDichVuRieng(int id, int thang, int dich_vu_1, int dich_vu_2, int dich_vu_3, int thanh_tien)
        {
            try
            {
                object[] Para = new object[] {  id,
                                                thang,
                                                dich_vu_1,
                                                dich_vu_2,
                                                dich_vu_3,
                                                thanh_tien};

                return DataProvider.Instance.ExecuteNonQuery(UPDATE_DICHVURIENG, Para) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int TinhTienDichVuRieng(int id_sinhvien, int thang)
        {
            object[] Para = new object[] { thang, id_sinhvien };

            var thanh_tien = DataProvider.Instance.ExecuteScalar(TINH_TIEN_DVR, Para);

            if (thanh_tien is DBNull)
                return 0;
            return Convert.ToInt32(thanh_tien);
        }

        public bool AddDichVuChung(int id, int thang, int dich_vu_1, int dich_vu_2, int thanh_tien)
        {
            try
            {
                object[] Para = new object[] {  id,
                                                thang,
                                                dich_vu_1,
                                                dich_vu_2,
                                                thanh_tien };

                return DataProvider.Instance.ExecuteNonQuery(ADD_DICHVUCHUNG, Para) > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool DeleteDichVuChung(int id_sinhvien, int thang)
        {
            try
            {
                object[] Para = new object[] { id_sinhvien, thang };

                return DataProvider.Instance.ExecuteNonQuery(DELETE_DICHVUCHUNG, Para) > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool UpdateDichVuChung(int id, int thang, int dich_vu_1, int dich_vu_2, int thanh_tien)
        {
            try
            {
                object[] Para = new object[] {  id,
                                                thang,
                                                dich_vu_1,
                                                dich_vu_2,
                                                thanh_tien};

                return DataProvider.Instance.ExecuteNonQuery(UPDATE_DICHVUCHUNG, Para) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int TinhTienDichVuChung(int id_phong, int thang)
        {
            object[] Para = new object[] { thang, id_phong };

            var thanh_tien = DataProvider.Instance.ExecuteScalar(TINH_TIEN_DVC, Para);

            if (thanh_tien is DBNull)
                return 0;
            return Convert.ToInt32(thanh_tien);
        }
    }
}
