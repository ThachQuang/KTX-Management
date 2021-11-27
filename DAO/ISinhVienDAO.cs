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
        bool AddSinhVien(SINHVIEN sinhvien);
        bool DeleteSinhVien(SINHVIEN sinhvien);
        bool UpdateSinhVien(SINHVIEN sinhvien);
    }
}
