﻿using KTX_Management.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTX_Management.DAO
{
    internal interface IPhongDAO
    {
        // Khai báo sơ lược các hàm tương tác với database
        bool AddPhong(PHONG phong);
        bool DeletePhong(int id_phong);
        bool UpdatePhong(PHONG phong);
        bool AddNoiThat(int id_phong, CAUTRUC.NT noithat);
        bool DeleteNoiThat(int id_phong);
        bool CheckNoiThat(int id_phong);
        bool FixNoiThat(int id_phong);
        bool AddDien(int id_phong, int thang, CAUTRUC.DIENNUOC dien);
        bool AddNuoc(int id_phong, int thang, CAUTRUC.DIENNUOC nuoc);
        bool DeleteDien(int id_phong, int thang);
        bool DeleteNuoc(int id_phong, int thang);
        /*bool DeleteDien(int id_phong, int thang);
        bool UpdateDien(int id_phong, int thang, CAUTRUC.DIENNUOC dien);
        bool AddNuoc(int id_phong, int thang, CAUTRUC.DIENNUOC nuoc);
        bool DeleteNuoc(int id_phong, int thang);
        bool UpdateNuoc(int id_phong, int thang, CAUTRUC.DIENNUOC nuoc);*/
    }
}
