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
        const string DELETE_DICHVURIENG = @"SP_Delete_DichVuRieng @id_sinhvien";
        const string UPDATE_DICHVURIENG = @"SP_Update_DichVuRieng @id_sinhvien , @thang , @dich_vu_1 , @dich_vu_2 , @dich_vu_3 , @thanh_tien";
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
        public bool DeleteDichVuRieng(int id_sinhvien)
        {
            try
            {
                object[] Para = new object[] { id_sinhvien };

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
                object[] Para = new object[] { id,
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
    }
}
