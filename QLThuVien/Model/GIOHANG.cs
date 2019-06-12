using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Model
{
   public class GIOHANG
    {
        public GIOHANG()
        {

        }
        public GIOHANG(string masach, string tensach, string maloai, 
            string tacgia, int nam, decimal gia, int soluong)
        {
            MASACH = masach;
            TENSACH = tensach;
            MALOAISACH = maloai;
            TACGIA = tacgia;
            NAMSX = nam;
            GIASACH = gia;
            SOLUONG = soluong;
        }

        public GIOHANG(SACH sach, int soluong)
        {
            MASACH = sach.MASACH;
            TENSACH = sach.TENSACH;
            MALOAISACH = sach.MALOAISACH;
            TACGIA = sach.TACGIA;
            NAMSX = (int)sach.NAMSX;
            GIASACH = (decimal)sach.GIASACH;
            SOLUONG = soluong;
        }



        public string MASACH { get; set; }
        public string TENSACH { get; set; }
        public string MALOAISACH { get; set; }
        public string TACGIA { get; set; }
        int NAMSX { get; set; }
        decimal GIASACH { get; set; }
        public int SOLUONG { get; set; }
    }
}
