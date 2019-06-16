using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Model
{
    public class NV_NHAP
    {
        public NV_NHAP()
        {

        }

        public NV_NHAP(NHAPSACH nhap, string maloai, string tensach)
        {
            MASACH = nhap.MASACH;
            MAPHIEU = nhap.MAPHIEU;
            MALOAISACH = maloai;
            TENSACH = tensach;
            SOLUONG = (int)nhap.SOLUONG;
            NGAYNHAP = (DateTime)nhap.NGAYNHAP;
            TONGTIEN = (decimal)nhap.TONGTIEN;
            
        }

        public string MASACH { get; set; }
        public string MAPHIEU { get; set; }
        public string TENSACH { get; set; }
        public string MALOAISACH { get; set; }
        public int SOLUONG { get; set; }
        public DateTime NGAYNHAP { get; set; }
        public Decimal TONGTIEN { get; set; }
    }
}
