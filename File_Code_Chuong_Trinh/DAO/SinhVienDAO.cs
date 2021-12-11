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
        const string GET_PH_SINHVIEN = @"SELECT DISTINCT id_phuhuynh, ten, ngay_sinh , gioi_tinh , que_quan , nghe_nghiep , sdt FROM PHUHUYNH WHERE PHUHUYNH.id_sinhvien = @id_sinhvien";
        const string GET_SV_PHONG = @"SELECT DISTINCT id_sinhvien, ten, sdt FROM SINHVIEN WHERE SINHVIEN.id_phong = @id_phong";
        const string GET_INFO_SV = @"SELECT DISTINCT id_phong, ten, ngay_sinh, gioi_tinh, que_quan, nghe_nghiep, sdt, cmnd, bhyt, noi_lam_viec, ho_khau, sv_nam, hop_dong_start, hop_dong_end FROM SINHVIEN WHERE SINHVIEN.id_sinhvien = @id_sinhvien";
        const string ADD_SINHVIEN = @"SP_Add_SinhVien @id_phong , @ten , @ngay_sinh , @gioi_tinh , @que_quan , @nghe_nghiep , @sdt , @cmnd , @bhyt , @noi_lam_viec , @ho_khau , @sv_nam , @hop_dong_start , @hop_dong_end";
        const string ADD_PHUHUYNH = @"SP_Add_PhuHuynh @id_phong , @ten , @ngay_sinh , @gioi_tinh , @que_quan , @nghe_nghiep , @sdt";
        const string DELETE_SINHVIEN = @"SP_Delete_SinhVien @id_sinhvien";
        const string DELETE_PHUHUYNH = @"SP_Delete_PhuHuynh @id_phuhuynh";
        const string UPDATE_SINHVIEN = @"SP_Update_SinhVien @id_sinhvien , @id_phong , @ten , @ngay_sinh , @gioi_tinh , @que_quan , @nghe_nghiep , @sdt , @cmnd , @bhyt , @noi_lam_viec , @ho_khau , @sv_nam";
        const string UPDATE_PHUHUYNH = @"SP_Update_PhuHuynh @id_sinhvien , @id_phuhuynh , @ten , @ngay_sinh , @gioi_tinh , @que_quan , @nghe_nghiep , @sdt";
        const string UPDATE_HOPDONG = @"SP_Update_HopDong @id_sinhvien , @hop_dong_start , @hop_dong_end";
        const string GET_ID = @"SELECT* FROM SINHVIEN WHERE id_phong=@id_phong";
        const string COUNT_SINHVIEN = @"SELECT COUNT(id_sinhvien) FROM SINHVIEN WHERE id_phong = @id_phong";
        const string TAKE_ID_PHONG = @"SELECT id_phong FROM SINHVIEN WHERE id_sinhvien = @id_sinhvien";
        const string SELECT_ALL = "SELECT * FROM SINHVIEN";
        // Hàm tương tác với database
        const int MAX = 20000;
        public int IDPhong(int id_sinhvien)
        {
            object[] Para = new object[] { id_sinhvien };
            var TotalSinhVien = DataProvider.Instance.ExecuteScalar(TAKE_ID_PHONG, Para);
            if (TotalSinhVien is DBNull)
                return 0;
            return Convert.ToInt32(TotalSinhVien);
        }
        public int CountSinhVien(int id_phong)
        {
            object[] Para = new object[] { id_phong };
            var TotalSinhVien = DataProvider.Instance.ExecuteScalar(COUNT_SINHVIEN, Para);
            if (TotalSinhVien is DBNull)
                return 0;
            return Convert.ToInt16(TotalSinhVien);
        }
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
        public bool AddPhuHuynh(CAUTRUC.NGUOI phuhuynh,int id_sinhvien)
        {
            try
            {
                object[] Para = new object[] { id_sinhvien,
                                               phuhuynh.HoTen,
                                               phuhuynh.NgaySinh,
                                               phuhuynh.GioiTinh,
                                               phuhuynh.QueQuan,
                                               phuhuynh.NgheNghiep,
                                               phuhuynh.SDT};

                return DataProvider.Instance.ExecuteNonQuery(ADD_PHUHUYNH, Para) > 0;
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
        public bool DeletePhuHuynh(int id_phuhuynh)
        {
            try
            {
                object[] Para = new object[] { id_phuhuynh };

                return DataProvider.Instance.ExecuteNonQuery(DELETE_PHUHUYNH, Para) > 0;
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
                SqlConnection conn = DataProvider.GetSqlConnection();

                //Mo ket noi
                conn.Open();

                //Tao Sqlcommand 
                SqlCommand cmd = DataProvider.GetSqlCommand(GET_ID, conn);

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
        public bool UpdatePhuHuynh(CAUTRUC.NGUOI phuhuynh, int id_sinhvien, int id_phuhuynh)
        {
            try
            {
                object[] Para = new object[] { id_sinhvien,
                                               id_phuhuynh,
                                               phuhuynh.HoTen,
                                               phuhuynh.NgaySinh,
                                               phuhuynh.GioiTinh,
                                               phuhuynh.QueQuan,
                                               phuhuynh.NgheNghiep,
                                               phuhuynh.SDT};

                return DataProvider.Instance.ExecuteNonQuery(UPDATE_PHUHUYNH, Para) > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
        public List<SINHVIEN> HienThiSinhVien(int id_sinhvien)
        {
            List<SINHVIEN> sinhvien = new List<SINHVIEN>();
            object[] Para = new object[] { id_sinhvien };
            DataTable Table = DataProvider.Instance.ExecuteQuery(GET_INFO_SV, Para);

            foreach (DataRow row in Table.Rows)
            {
                SINHVIEN temp = new SINHVIEN
                {
                    IDPhong = Convert.ToInt32(row["id_phong"]),
                    HoTen = Convert.ToString(row["ten"]),
                    NgaySinh = Convert.ToString(row["ngay_sinh"]),
                    GioiTinh = Convert.ToString(row["gioi_tinh"]),
                    QueQuan = Convert.ToString(row["que_quan"]),
                    NgheNghiep = Convert.ToString(row["nghe_nghiep"]),
                    SDT = Convert.ToString(row["sdt"]),
                    CMND = Convert.ToString(row["cmnd"]),
                    BHYT = Convert.ToString(row["bhyt"]),
                    NoiLamViec = Convert.ToString(row["noi_lam_viec"]),
                    DiaChiHK = Convert.ToString(row["ho_khau"]),
                    SVNam = Convert.ToInt16(row["sv_nam"]),
                    HopDongStart = Convert.ToString(row["hop_dong_start"]),
                    HopDongEnd = Convert.ToString(row["hop_dong_end"])
                };
                sinhvien.Add(temp);
            }
            return sinhvien;
        }

        public SINHVIEN[] XuatThuTu()
        {
            SINHVIEN[] sinhvien = new SINHVIEN[MAX];
            object[] Para = new object[] {};
            DataTable Table = DataProvider.Instance.ExecuteQuery(SELECT_ALL, Para);
            int i = 0;
            foreach (DataRow row in Table.Rows)
            {
                SINHVIEN temp = new SINHVIEN
                {
                    IDPhong = Convert.ToInt32(row["id_phong"]),
                    HoTen = Convert.ToString(row["ten"]),
                    NgaySinh = Convert.ToString(row["ngay_sinh"]),
                    GioiTinh = Convert.ToString(row["gioi_tinh"]),
                    QueQuan = Convert.ToString(row["que_quan"]),
                    NgheNghiep = Convert.ToString(row["nghe_nghiep"]),
                    SDT = Convert.ToString(row["sdt"]),
                    CMND = Convert.ToString(row["cmnd"]),
                    BHYT = Convert.ToString(row["bhyt"]),
                    NoiLamViec = Convert.ToString(row["noi_lam_viec"]),
                    DiaChiHK = Convert.ToString(row["ho_khau"]),
                    SVNam = Convert.ToInt16(row["sv_nam"]),
                    HopDongStart = Convert.ToString(row["hop_dong_start"]),
                    HopDongEnd = Convert.ToString(row["hop_dong_end"])
                };
                if (temp == null)
                    break;
                sinhvien[i]=temp;
                i++;
            }
            return sinhvien;
        }
        public List<SINHVIEN> HienThiSVPhong(int id_phong)
        {
            List<SINHVIEN> sinhvien = new List<SINHVIEN>();
            object[] Para = new object[] { id_phong };
            DataTable Table = DataProvider.Instance.ExecuteQuery(GET_SV_PHONG, Para);

            foreach (DataRow row in Table.Rows)
            {
                SINHVIEN temp = new SINHVIEN
                {
                    IDSinhVien = Convert.ToInt32(row["id_sinhvien"]),
                    HoTen = Convert.ToString(row["ten"]),
                    SDT = Convert.ToString(row["sdt"])
                };
                sinhvien.Add(temp);
            }
            return sinhvien;
        }
        public List<CAUTRUC.NGUOI> HienThiPhuHuynh(int id_sinhvien)
        {
            List<CAUTRUC.NGUOI> phuhuynh = new List<CAUTRUC.NGUOI>();
            object[] Para = new object[] { id_sinhvien };
            DataTable Table = DataProvider.Instance.ExecuteQuery(GET_PH_SINHVIEN, Para);

            foreach (DataRow row in Table.Rows)
            {
                CAUTRUC.NGUOI temp = new CAUTRUC.NGUOI
                {
                    ID = Convert.ToInt32(row["id_phuhuynh"]),
                    HoTen = Convert.ToString(row["ten"]),
                    NgaySinh = Convert.ToString(row["ngay_sinh"]),
                    GioiTinh = Convert.ToString(row["gioi_tinh"]),
                    QueQuan = Convert.ToString(row["que_quan"]),
                    NgheNghiep = Convert.ToString(row["nghe_nghiep"]),
                    SDT = Convert.ToString(row["sdt"])
                };
                phuhuynh.Add(temp);
            }
            return phuhuynh;
        }
    }
}
