using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Model
{
    public class NV_DANGMUON
    {

        public NV_DANGMUON()
        {

        }

        public NV_DANGMUON(PHIEUGIAODICH phieu, SACH sach, PHIEUSACH phieus)
        {
            MAPHIEU = phieu.MAPHIEU;
           MADG = phieu.MADG;
            MALOAISACH = sach.MALOAISACH;
            MASACH = sach.MASACH;
            TENSACH = sach.TENSACH;
            SOLUONG =(int) phieus.SOLUONG;
            NGAYMUON = (DateTime)phieu.NGAYMUON;
            NGAYTRA = (DateTime)phieu.NGAYTRA;
          
        }

        public string MAPHIEU { get; set; }
        public string MADG { get; set; }
        public string MASACH { get; set; }
        public string TENSACH { get; set; }
        public string MALOAISACH { get; set; }
        public int SOLUONG { get; set; }
        public DateTime NGAYMUON { get; set; }
        public DateTime NGAYTRA { get; set; }


    }
}
