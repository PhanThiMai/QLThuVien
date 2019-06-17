using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Model
{
    public class KHOSACH
    {
        public KHOSACH()
        {

        }

        public KHOSACH(SACH sach, int soluong)
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
        public int NAMSX { get; set; }
        public decimal GIASACH { get; set; }
        public int SOLUONG { get; set; }

    }
}
