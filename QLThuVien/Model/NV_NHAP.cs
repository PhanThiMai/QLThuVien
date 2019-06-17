using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Model
{
    public class NV_NHAP
    {
        public NV_NHAP(string masach,
            int soluong, decimal tongtien)
        {
            MASACH = masach;
            SOLUONG = soluong;
            TONGTIEN = tongtien;
        }

        public NV_NHAP(string masach, string maphieu, string tensach,
            int soluong, DateTime ngaynhap, decimal tongtien) {
            MASACH = masach;
            MAPHIEU = maphieu;
            TENSACH = tensach;
            SOLUONG = soluong;
            NGAYNHAP = ngaynhap;
            TONGTIEN = tongtien;
            
        }

        public string MASACH { get; set; }
        public string MAPHIEU { get; set; }
        public string TENSACH { get; set; }
        public int SOLUONG { get; set; }
        public DateTime NGAYNHAP { get; set; }
        public Decimal TONGTIEN { get; set; }
    }
}


/*
 
        string ma = "";
                   ma = KhoiTaoMaPhieu(DataProvider.Ins.DB.NHAPSACHes.Count() + 1);
                   if (NSChonMaLoai != "Nhập mã mới" && NSChonMaSach != "Nhập mã mới")// nhap sach da co san
                   {
                       var nhapsach = new NHAPSACH()
                       {
                           MAPHIEU = ma,
                           MASACH = NSChonMaSach,
                           NGAYNHAP = NSNgayNhap,
                           SOLUONG = int.Parse(NSSoLuong),
                           TONGTIEN = Decimal.Parse(NSTongTien),
                       };
                       var sach = DataProvider.Ins.DB.SACHes.Where(x => x.MASACH == nhapsach.MASACH).SingleOrDefault();

                       NSLIST.Add(new NV_NHAP(nhapsach, NSChonMaLoai, sach.TENSACH));
                       DataProvider.Ins.DB.NHAPSACHes.Add(nhapsach);
                       DataProvider.Ins.DB.SaveChanges();

                       var sachKho = DataProvider.Ins.DB.KHOes.Where(x => x.MASACH == sach.MASACH).SingleOrDefault();
                       sachKho.SOLUONG += nhapsach.SOLUONG;

                   }
                   else
                   {
                           if (NSChonMaLoai == "Nhập mã mới")  {
                               var loai = new LOAISACH() {
                                   MALOAISACH = NSNhapMaLoai,
                                   TENLOAISACH = NSNhapTenLoai,
                               };
                               DataProvider.Ins.DB.LOAISACHes.Add(loai);
                               DataProvider.Ins.DB.SaveChanges();
                              LOAICBX.Add(NSNhapTenLoai);
                           
                           }

                           var sach = new SACH() {
                               MASACH = NSNhapMaSach,
                               MALOAISACH = NSNhapMaLoai,
                               TENSACH = NSNhapTenSach,
                               TACGIA = NSNhapTacGia,
                               NAMSX = int.Parse(NSNhapNamSX),
                               GIASACH = decimal.Parse(NSNhapGia)
                           };
                           DataProvider.Ins.DB.SACHes.Add(sach);
                           DataProvider.Ins.DB.SaveChanges();

                       if (CkeckCombobox(NSNhapNamSX, NAMSXCBX))
                           NAMSXCBX.Add(NSNhapNamSX);
                       if (CkeckCombobox(NSNhapTacGia, TACGIACBX))
                           TACGIACBX.Add(NSNhapTacGia);
                        
                           var nhapsach = new NHAPSACH()
                           {
                               MAPHIEU = ma,
                               MASACH = sach.MASACH,
                               NGAYNHAP = NSNgayNhap,
                               SOLUONG = int.Parse(NSSoLuong),
                               TONGTIEN = Decimal.Parse(NSTongTien),
                           };

                           NSLIST.Add(new NV_NHAP(nhapsach, NSNhapMaLoai, sach.TENSACH));

                           DataProvider.Ins.DB.NHAPSACHes.Add(nhapsach);
                           DataProvider.Ins.DB.SaveChanges();

                       var sachKhoMoi = new KHO()
                       {
                           MASACH = sach.MASACH,
                           SOLUONG = nhapsach.SOLUONG
                       };
                       DataProvider.Ins.DB.KHOes.Add(sachKhoMoi);
                       DataProvider.Ins.DB.SaveChanges();
                       
                   }


     
     
     */
