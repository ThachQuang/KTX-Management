using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTX_Management.DAO
{
    internal interface IDichVuDAO
    {
        bool AddDichVuRieng(int id, int thang, int dich_vu_1, int dich_vu_2, int dich_vu_3, int thanh_tien);
        bool DeleteDichVuRieng(int id_sinhvien);
        bool UpdateDichVuRieng(int id, int thang, int dich_vu_1, int dich_vu_2, int dich_vu_3, int thanh_tien);
        int TinhTienDichVuRieng(int id_sinhvien, int thang);
        bool AddDichVuChung(int id, int thang, int dich_vu_1, int dich_vu_2, int thanh_tien);
        bool DeleteDichVuChung(int id_sinhvien);
        bool UpdateDichVuChung(int id, int thang, int dich_vu_1, int dich_vu_2, int thanh_tien);
        int TinhTienDichVuChung(int id_phong, int thang);
    }
}
