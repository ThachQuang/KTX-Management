using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTX_Management.Entities
{
    class DICHVU
    {
        // Fields
        public double GiaDV1;
        public double GiaDV2;
        public double GiaDV3;
        public static DICHVU DVChung = new DICHVU(320000, 30000);
        public static DICHVU DVCaNhan = new DICHVU(20000, 60000, 50000);
        // Methods
        public DICHVU()
        {

        }
        public DICHVU(double GiaDV1, double GiaDV2)
        {
            this.GiaDV1 = GiaDV1;
            this.GiaDV2 = GiaDV2;
        }
        public DICHVU(double GiaDV1, double GiaDV2, double GiaDV3)
        {
            this.GiaDV1 = GiaDV1;
            this.GiaDV2 = GiaDV2;
            this.GiaDV3 = GiaDV3;
        }
        // Methods
        public DICHVU GetInfoGiaDV(bool LoaiDV)
        {
            double DV1, DV2, DV3;
            DICHVU temp = new DICHVU();
            if (LoaiDV)
            {
                Console.WriteLine("Nhap gia dich vu 1:");
                DV1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap gia dich vu 2:");
                DV2 = double.Parse(Console.ReadLine());
                temp = new DICHVU(DV1, DV2);
            }
            else
            {
                Console.WriteLine("Nhap gia dich vu 1:");
                DV1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap gia dich vu 2:");
                DV2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap gia dich vu 3:");
                DV3 = double.Parse(Console.ReadLine());
                temp = new DICHVU(DV1, DV2, DV3);
            }
            return temp;
        }

    }
}
