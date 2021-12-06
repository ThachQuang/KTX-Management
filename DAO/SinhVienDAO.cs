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
    internal class SinhVienDAO : ISinhVienDAO
    {
        // Make class SinhVienDao instance
        // Đây là code bắt buộc phải có để có thể gọi hàm tương tác database từ Main
        private static SinhVienDAO instance;
        public static SinhVienDAO Instance
        {
            get { if (instance == null) instance = new SinhVienDAO(); return SinhVienDAO.instance; }
            private set { SinhVienDAO.instance = value; }
        }
        private SinhVienDAO() { }
        // Các chuỗi chứa câu lệnh thực thi procedure sql
        const string ADD_SINHVIEN = @"SP_Add_SinhVien @id_phong , @ten , @ngay_sinh , @gioi_tinh , @que_quan , @nghe_nghiep , @sdt , @cmnd , @bhyt , @noi_lam_viec , @ho_khau , @sv_nam , @hop_dong_start , @hop_dong_end";
        const string DELETE_SINHVIEN = @"SP_Delete_SinhVien @id_sinhvien";
        const string UPDATE_SINHVIEN = @"SP_Update_SinhVien @id_sinhvien , @id_phong , @ten , @ngay_sinh , @gioi_tinh , @que_quan , @nghe_nghiep , @sdt , @cmnd , @bhyt , @noi_lam_viec , @ho_khau , @sv_nam";
        const string UPDATE_HOPDONG = @"SP_Update_HopDong @id_sinhvien , @hop_dong_start , @hop_dong_end";
        const string GET_ID = "SELECT* FROM SINHVIEN WHERE id_phong=@id_phong";
        // Hàm tương tác với database
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

        public bool DeleteSinhVien(int id_sinhvien)
        {
            try
            {
                object[] Para = new object[] { id_sinhvien };

                return DataProvider.Instance.ExecuteNonQuery(DELETE_SINHVIEN, Para) > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool DeleteByIdPhong(int id_phong)
        {
            try
            {
                // Khoi tao SqlConnection conn
                SqlConnection conn = Connect.GetSqlConnection();

                //Mo ket noi
                conn.Open();

                //Tao Sqlcommand 
                SqlCommand cmd = Connect.GetSqlCommand(GET_ID, conn);

                //Truyen tham so
                cmd.Parameters.Add(new SqlParameter("@id_phong", id_phong));

                //Dung phuong thuc ExecuteReader
                // tra ve SqlDataReader
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    try
                    {                       
                        if(DeleteSinhVien((int)dataReader["id_sinhvien"])==false)
                            return false;      
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        public bool UpdateSinhVien(SINHVIEN sinhvien)
        {
            try
            {
                object[] Para = new object[] { sinhvien.IDSinhVien,
                                               sinhvien.IDPhong,
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
                                               sinhvien.SVNam};

                return DataProvider.Instance.ExecuteNonQuery(UPDATE_SINHVIEN, Para) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateHopDong(SINHVIEN sinhvien)
        {
            try
            {
                object[] Para = new object[] { sinhvien.IDSinhVien,                                              
                                               sinhvien.HopDongStart,
                                               sinhvien.HopDongEnd };

                return DataProvider.Instance.ExecuteNonQuery(UPDATE_HOPDONG, Para) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
