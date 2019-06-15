using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Model
{
    public class DATRA
    {

        public DATRA()
        {

        }
        

        public DATRA(GIOHANG sach, string maphieu)
        {
            MASACH = sach.MASACH;
            TENSACH = sach.TENSACH;
            MALOAISACH = sach.MALOAISACH;
            TACGIA = sach.TACGIA;
            NAMSX = sach.NAMSX;
            GIASACH = sach.GIASACH;
            SOLUONG = sach.SOLUONG;
            MAPHIEU = maphieu;
        }


        public string MAPHIEU { get; set; }
        public string MASACH { get; set; }
        public string TENSACH { get; set; }
        public string MALOAISACH { get; set; }
        public string TACGIA { get; set; }
        public  int NAMSX { get; set; }
        public decimal GIASACH { get; set; }
        public int SOLUONG { get; set; }
    }
}

