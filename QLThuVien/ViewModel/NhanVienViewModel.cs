using QLThuVien.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QLThuVien.ViewModel
{
    public class NhanVienViewModel: BaseViewModel
    {
        public ICommand SettingCommand { get; set; }
        public ICommand SachCommand { get; set; }
        public ICommand DangXuatCommand { get; set; }
        public ICommand ThongTinDocGiaCommand { get; set; }
        public ICommand SachThanhLyCommand { get; set; }
        public ICommand DangMuonCommand { get; set; }
        public ICommand DaTraCommand { get; set; }

        public ICommand SachDaHuyCommand { get; set; }
       
        public ICommand NhapSachCommand { get; set; }
        public ICommand DanhSachDocGiaCommand { get; set; }
        public ICommand DocGiaViPhamCommand { get; set; }

        public ICommand STSetting { get; set; }
        public ICommand STHuy { get; set; }

        public ICommand LODangXuat { get; set; }
        public ICommand LOHuy { get; set; }
        public ICommand TLNhap { get; set; }
        public ICommand TLThem { get; set; }
        public ICommand TLHuy { get; set; }

        public ICommand NSNhap { get; set; }
        public ICommand NSThem { get; set; }
        public ICommand NSHuy { get; set; }

        public ICommand VPXoa { get; set; }
        public ICommand VPHuy { get; set; }
        public ICommand VPThem { get; set; }

        public ICommand KSTimKiem { get; set; }
        public ICommand DMTimKiem { get; set; }
        public ICommand LSTimKiem { get; set; }
        public ICommand NSTimKiem { get; set; }
        public ICommand DGTimKiem { get; set; }
        public ICommand NSThemVaoGio { get; set; }

        private bool _SachGrid;
        private bool _TTDocGiaGrid;
        private bool _LogOutGrid;
       
        private bool _DangMuonGrid;
        private bool _DaTraGrid;
        private bool _SettingGrid;
        private bool _SachThanhLyGrid;
        private bool _SachDaHuyGrid;
        private bool _NhapSachGrid;
        //ThemNhapSachGrid
        //NhapSachMoi DGXemTT
        private bool _NhapSachMoi;
        private bool _ThemNhapSachGrid;
        private bool _DocGiaGrid;
        private bool _ViPhamGrid;

        private bool _NhapThanhLyGrid;
        private bool _NhapHuyGrid;

        private bool _DGXemTT;

        public bool DGXemTT
        {
            get { return _DGXemTT; }
            set
            {
                _DGXemTT = value;
                OnPropertyChanged("DGXemTT");
            }

        }

        public bool SachGrid
        {
            get { return _SachGrid; }
            set
            {
                _SachGrid = value;
                OnPropertyChanged("SachGrid");
            }

        }

        public bool SettingGrid
        {
            get { return _SettingGrid; }
            set
            {
                _SettingGrid = value;
                OnPropertyChanged("SettingGrid");
            }
        }

        public bool TTDocGiaGrid
        {
            get { return _TTDocGiaGrid; }
            set
            {
                _TTDocGiaGrid = value;
                OnPropertyChanged("TTDocGiaGrid");
            }
        }

        public bool LogOutGrid
        {
            get { return _LogOutGrid; }
            set
            {
                _LogOutGrid = value;
                OnPropertyChanged("LogOutGrid");
            }
        }

        public bool NhapSachGrid
        {
            get { return _NhapSachGrid; }
            set
            {
                _NhapSachGrid = value;
                OnPropertyChanged("NhapSachGrid");
            }
        }

        public bool ThemNhapSachGrid
        {
            get { return _ThemNhapSachGrid; }
            set
            {
                _ThemNhapSachGrid = value;
                OnPropertyChanged("ThemNhapSachGrid");
            }
        }

        public bool DangMuonGrid
        {
            get { return _DangMuonGrid; }
            set
            {
                _DangMuonGrid = value;
                OnPropertyChanged("DangMuonGrid");
            }
        }

        public bool DaTraGrid
        {
            get { return _DaTraGrid; }
            set
            {
                _DaTraGrid = value;
                OnPropertyChanged("DaTraGrid");
            }
        }

        public bool ViPhamGrid
        {
            get { return _ViPhamGrid; }
            set
            {
                _ViPhamGrid = value;
                OnPropertyChanged("ViPhamGrid");
            }
        }

        public bool DocGiaGrid
        {
            get { return _DocGiaGrid; }
            set
            {
                _DocGiaGrid = value;
                OnPropertyChanged("DocGiaGrid");
            }
        }

        public bool SachThanhLyGrid
        {
            get { return _SachThanhLyGrid; }
            set
            {
                _SachThanhLyGrid = value;
                OnPropertyChanged("SachThanhLyGrid");
            }
        }

        public bool SachDaHuyGrid
        {
            get { return _SachDaHuyGrid; }
            set
            {
                _SachDaHuyGrid = value;
                OnPropertyChanged("SachDaHuyGrid");
            }
        }

        public bool NhapThanhLyGrid
        {
            get { return _NhapThanhLyGrid; }
            set
            {
                _NhapThanhLyGrid = value;
                OnPropertyChanged("NhapThanhLyGrid");
            }
        }


        public bool NhapHuyGrid
        {
            get { return _NhapHuyGrid; }
            set
            {
                _NhapHuyGrid = value;
                OnPropertyChanged("NhapHuyGrid");
            }
        }

        public bool NhapSachMoi
        {
            get { return _NhapSachMoi; }
            set
            {
                _NhapSachMoi = value;
                OnPropertyChanged("NhapSachMoi");
            }
        }


        private ObservableCollection<SACH> _SACHList;
        public ObservableCollection<SACH> SACHLIST
        {
            get => _SACHList;
            set { _SACHList = value; OnPropertyChanged(); }
        }

        private ObservableCollection<KHOSACH> _KHOSACHList;
        public ObservableCollection<KHOSACH> KHOSACHLIST
        {
            get => _KHOSACHList;
            set { _KHOSACHList = value; OnPropertyChanged(); }
        }

        private ObservableCollection<LOAISACH> _LOAISACHList;
        public ObservableCollection<LOAISACH> LOAISACHLIST
        {
            get => _LOAISACHList;
            set { _LOAISACHList = value; OnPropertyChanged(); }
        }

        private ObservableCollection<PHIEUGIAODICH> _PHIEUDDList;
        public ObservableCollection<PHIEUGIAODICH> PHIEUDDLIST
        {
            get => _PHIEUDDList;
            set { _PHIEUDDList = value; OnPropertyChanged(); }
        }

        private ObservableCollection<PHIEUSACH> _PHIEUSACHList;
        public ObservableCollection<PHIEUSACH> PHIEUSACHLIST
        {
            get => _PHIEUSACHList;
            set { _PHIEUSACHList = value; OnPropertyChanged(); }
        }
        //TLTHANGCBX

        private ObservableCollection<string> _TLTHANGCBX;
        public ObservableCollection<string> TLTHANGCBX
        {
            get => _TLTHANGCBX;
            set
            {
                _TLTHANGCBX = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<string> _TLNAMCBX;
        public ObservableCollection<string> TLNAMCBX
        {
            get => _TLNAMCBX;
            set
            {
                _TLNAMCBX = value;
                OnPropertyChanged();
            }
        }


        private ObservableCollection<string> _NSTHANGCBX;
        public ObservableCollection<string> NSTHANGCBX
        {
            get => _NSTHANGCBX;
            set
            {
                _NSTHANGCBX = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<string> _NSNAMCBX;
        public ObservableCollection<string> NSNAMCBX
        {
            get => _NSNAMCBX;
            set
            {
                _NSNAMCBX = value;
                OnPropertyChanged();
            }
        }


        private ObservableCollection<string> _LOAICBX;
        public ObservableCollection<string> LOAICBX
        {
            get => _LOAICBX;
            set
            {
                _LOAICBX = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<string> _NAMSXCBX;
        public ObservableCollection<string> NAMSXCBX
        {
            get => _NAMSXCBX;
            set
            {
                _NAMSXCBX = value;
                OnPropertyChanged();
               
            }
        }

        private ObservableCollection<string> _TACGIACBX;
        public ObservableCollection<string> TACGIACBX
        {
            get => _TACGIACBX;
            set
            {
                _TACGIACBX = value;
                OnPropertyChanged();
              
            }
        }

        private ObservableCollection<string> _TENNHANVIEN;
        public ObservableCollection<string> TENNHANVIEN
        {
            get => _TENNHANVIEN;
            set
            {
                _TENNHANVIEN = value;
                OnPropertyChanged();
              
            }
        }


        private ObservableCollection<string> _DMLOAICBX;
        public ObservableCollection<string> DMLOAICBX
        {
            get => _DMLOAICBX;
            set
            {
                _DMLOAICBX = value;
                OnPropertyChanged();

            }
        }

        private ObservableCollection<string> _DMNGAYMUONCBX;
        public ObservableCollection<string> DMNGAYMUONCBX
        {
            get => _DMNGAYMUONCBX;
            set
            {
                _DMNGAYMUONCBX = value;
                OnPropertyChanged();

            }
        }


        private ObservableCollection<string> _DMNGAYTRACBX;
        public ObservableCollection<string> DMNGAYTRACBX
        {
            get => _DMNGAYTRACBX;
            set
            {
                _DMNGAYTRACBX = value;
                OnPropertyChanged();

            }
        }


        private ObservableCollection<string> _LSLOAICBX;
        public ObservableCollection<string> LSLOAICBX
        {
            get => _LSLOAICBX;
            set
            {
                _LSLOAICBX = value;
                OnPropertyChanged();

            }
        }

        private ObservableCollection<string> _LSNGAYMUONCBX;
        public ObservableCollection<string> LSNGAYMUONCBX
        {
            get => _LSNGAYMUONCBX;
            set
            {
                _LSNGAYMUONCBX = value;
                OnPropertyChanged();

            }
        }


        private ObservableCollection<string> _LSNGAYTRACBX;
        public ObservableCollection<string> LSNGAYTRACBX
        {
            get => _LSNGAYTRACBX;
            set
            {
                _LSNGAYTRACBX = value;
                OnPropertyChanged();

            }
        }



        private ObservableCollection<string> _TLNMASACHCBX;
        public ObservableCollection<string> TLNMASACHCBX
        {
            get => _TLNMASACHCBX;
            set
            {
                _TLNMASACHCBX = value;
                OnPropertyChanged();

            }
        }


        private ObservableCollection<string> _TLNLOAICBX;
        public ObservableCollection<string> TLNLOAICBX
        {
            get => _TLNLOAICBX;
            set
            {
                _TLNLOAICBX = value;
                OnPropertyChanged();

            }
        }


        private ObservableCollection<string> _NSMASACHCBX;
        public ObservableCollection<string> NSMASACHCBX
        {
            get => _NSMASACHCBX;
            set
            {
                _NSMASACHCBX = value;
                OnPropertyChanged();

            }
        }


        private ObservableCollection<string> _NSMALOAICBX;
        public ObservableCollection<string> NSMALOAICBX
        {
            get => _NSMALOAICBX;
            set
            {
                _NSMALOAICBX = value;
                OnPropertyChanged();

            }
        }


        private ObservableCollection<NHANVIEN> _NHANVIENList;
        public ObservableCollection<NHANVIEN> NHANVIENList
        {
            get => _NHANVIENList;
            set { _NHANVIENList = value; OnPropertyChanged(); }
        }


        private ObservableCollection<TAIKHOANNV> _TAIKHOANNVList;
        public ObservableCollection<TAIKHOANNV> TAIKHOANNVList
        {
            get => _TAIKHOANNVList;
            set { _TAIKHOANNVList = value; OnPropertyChanged(); }
        }
        //DANGMUONLIST

        private ObservableCollection<NV_DANGMUON> _DANGMUONLIST;
        public ObservableCollection<NV_DANGMUON> DANGMUONLIST
        {
            get => _DANGMUONLIST;
            set { _DANGMUONLIST = value; OnPropertyChanged(); }
        }


        private ObservableCollection<NV_DANGMUON> _DATRALIST;
        public ObservableCollection<NV_DANGMUON> DATRALIST
        {
            get => _DATRALIST;
            set { _DATRALIST = value; OnPropertyChanged(); }
        }

        //THANHLYLIST

        private ObservableCollection<THANHLYHUY> _THANHLYLIST;
        public ObservableCollection<THANHLYHUY> THANHLYLIST
        {
            get => _THANHLYLIST;
            set { _THANHLYLIST = value; OnPropertyChanged(); }
        }

        //NSLIST  NV_NHAP
        private ObservableCollection<NV_NHAP> _NSLIST;
        public ObservableCollection<NV_NHAP> NSLIST
        {
            get => _NSLIST;
            set { _NSLIST = value; OnPropertyChanged(); }
        }
        //NSTHEMLIST

        private ObservableCollection<NV_NHAP> _NSTHEMLIST;
        public ObservableCollection<NV_NHAP> NSTHEMLIST
        {
            get => _NSTHEMLIST;
            set { _NSTHEMLIST = value; OnPropertyChanged(); }
        }

        private ObservableCollection<NHAPSACH> _NHAPSACHLIST;
        public ObservableCollection<NHAPSACH> NHAPSACHLIST
        {
            get => _NHAPSACHLIST;
            set { _NHAPSACHLIST = value; OnPropertyChanged(); }
        }

        private ObservableCollection<CHITIETNHAP> _CHITIETNHAPLIST;
        public ObservableCollection<CHITIETNHAP> CHITIETNHAPLIST
        {
            get => _CHITIETNHAPLIST;
            set { _CHITIETNHAPLIST = value; OnPropertyChanged(); }
        }

        private ObservableCollection<KHO> _KHOLIST;
        public ObservableCollection<KHO> KHOLIST
        {
            get => _KHOLIST;
            set { _KHOLIST = value; OnPropertyChanged(); }
        }
        //DGLIST VPLIST
        private ObservableCollection<DOCGIA> _DGLIST;
        public ObservableCollection<DOCGIA> DGLIST
        {
            get => _DGLIST;
            set { _DGLIST = value; OnPropertyChanged(); }
        }


        private ObservableCollection<PHAT> _VPLIST;
        public ObservableCollection<PHAT> VPLIST
        {
            get => _VPLIST;
            set { _VPLIST = value; OnPropertyChanged(); }
        }

        private ObservableCollection<string> _MaDGCBX;
        public ObservableCollection<string> MaDGCBX
        {
            get => _MaDGCBX;
            set { _MaDGCBX = value; OnPropertyChanged(); }
        }

        private string passUserName;
        //KSChonLoaiSach
        private string _KSChonLoaiSach;
        public string KSChonLoaiSach
        {
            get => _KSChonLoaiSach;
            set
            {
                _KSChonLoaiSach = value;
                OnPropertyChanged();
                if (_KSChonLoaiSach != null || _KSChonLoaiSach != "ALL")
                {
                    string maloai = "";
                    foreach (var item in LOAISACHLIST)
                    {
                        if (item.TENLOAISACH == _KSChonLoaiSach)
                            maloai = item.MALOAISACH;
                    }
                    SACHLIST = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes.Where(x => x.MALOAISACH == maloai));

                }
                if (_KSChonLoaiSach == "ALL")
                {
                    SACHLIST = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes);

                }
            }
        }

        private string _KSChonNamSX;
        public string KSChonNamSX
        {
            get => _KSChonNamSX;
            set
            {
                _KSChonNamSX = value;
                OnPropertyChanged();

                if (_KSChonNamSX != null || _KSChonNamSX != "ALL")
                {
                    SACHLIST = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes.Where(x => x.NAMSX.ToString() == _KSChonNamSX));

                }
                if (_KSChonNamSX == "ALL")
                {
                    SACHLIST = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes);

                }
            }
        }

        private string _KSChonTacGia;
        public string KSChonTacGia
        {
            get => _KSChonTacGia;
            set
            {
                _KSChonTacGia = value;
                OnPropertyChanged();

                if (_KSChonTacGia != null || _KSChonTacGia != "ALL")
                {
                    SACHLIST = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes.Where(x => x.TACGIA == _KSChonTacGia));

                }
                if (_KSChonTacGia == "ALL")
                {
                    SACHLIST = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes);

                }
            }
        }

        private string _KSThongTinTimKiem;
        public string KSThongTinTimKiem { get => _KSThongTinTimKiem; set { _KSThongTinTimKiem = value; OnPropertyChanged(); } }
        //DMThongTinTimKiem

        private string _DMThongTinTimKiem;
        public string DMThongTinTimKiem { get => _DMThongTinTimKiem; set { _DMThongTinTimKiem = value; OnPropertyChanged(); } }

        private string _LSThongTinTimKiem;
        public string LSThongTinTimKiem { get => _LSThongTinTimKiem; set { _LSThongTinTimKiem = value; OnPropertyChanged(); } }


        private string _NSThongTinTimKiem;
        public string NSThongTinTimKiem { get => _NSThongTinTimKiem; set { _NSThongTinTimKiem = value; OnPropertyChanged(); } }

        private string _DGThongTinTimKiem;
        public string DGThongTinTimKiem { get => _DGThongTinTimKiem; set { _DGThongTinTimKiem = value; OnPropertyChanged(); } }


        private string _TTMaNHANVIEN;
        public string TTMaNHANVIEN { get => _TTMaNHANVIEN; set { _TTMaNHANVIEN = value; OnPropertyChanged(); } }

        private string _TTHoTen;
        public string TTHoTen { get => _TTHoTen; set { _TTHoTen = value; OnPropertyChanged(); } }

        private string _TTGioiTinh;
        public string TTGioiTinh { get => _TTGioiTinh; set { _TTGioiTinh = value; OnPropertyChanged(); } }

        private string _TTCMND;
        public string TTCMND { get => _TTCMND; set { _TTCMND = value; OnPropertyChanged(); } }

        private DateTime _TTNgaySinh;
        public DateTime TTNgaySinh { get => _TTNgaySinh; set { _TTNgaySinh = value; OnPropertyChanged(); } }

        private string _TTSoDT;
        public string TTSoDT { get => _TTSoDT; set { _TTSoDT = value; OnPropertyChanged(); } }

        private string _TTDiaChi;
        public string TTDiaChi { get => _TTDiaChi; set { _TTDiaChi = value; OnPropertyChanged(); } }

        private string _NSNhapTenSach;
        public string NSNhapTenSach { get => _NSNhapTenSach; set { _NSNhapTenSach = value; OnPropertyChanged(); } }

        private string _NSNhapTacGia;
        public string NSNhapTacGia { get => _NSNhapTacGia; set { _NSNhapTacGia = value; OnPropertyChanged(); } }

        private string _NSNhapNamSX;
        public string NSNhapNamSX { get => _NSNhapNamSX; set { _NSNhapNamSX = value; OnPropertyChanged(); } }

        private string _NSNhapGia;
        public string NSNhapGia { get => _NSNhapGia; set { _NSNhapGia = value; OnPropertyChanged(); } }

        private string _NSNhapTenLoai;
        public string NSNhapTenLoai { get => _NSNhapTenLoai; set { _NSNhapTenLoai = value; OnPropertyChanged(); } }


        //TLNChonMaLoai NSNhapTenLoai
        private string _TLNChonMaLoai;
        public string TLNChonMaLoai { get => _TLNChonMaLoai;
            set {
                _TLNChonMaLoai = value;
                OnPropertyChanged();
                foreach(var item in SACHLIST)
                {
                    if (item.MALOAISACH == _TLNChonMaLoai)
                        TLNMASACHCBX.Add(item.MASACH);
                }

            } }

        //TNLChonMaSach TLNNgay TLNSoLuong TLNGhiChu

        private string _TNLChonMaSach;
        public string TNLChonMaSach { get => _TNLChonMaSach; set { _TNLChonMaSach = value; OnPropertyChanged(); } }

        private string _TLNSoLuong;
        public string TLNSoLuong { get => _TLNSoLuong; set { _TLNSoLuong = value; OnPropertyChanged(); } }

        private string _TLNGhiChu;
        public string TLNGhiChu { get => _TLNGhiChu; set { _TLNGhiChu = value; OnPropertyChanged(); } }

        private DateTime _TLNNgay;
        public DateTime TLNNgay { get => _TLNNgay; set { _TLNNgay = value; OnPropertyChanged(); } }

        //NSNhapMaSach  NSNgayNhap NSSoLuong NSTongTien
        private string _NSNhapMaSach;
        public string NSNhapMaSach { get => _NSNhapMaSach; set { _NSNhapMaSach = value; OnPropertyChanged(); } }

        private string _NSNhapMaLoai;
        public string NSNhapMaLoai { get => _NSNhapMaLoai; set { _NSNhapMaLoai = value; OnPropertyChanged(); } }

        private DateTime _NSNgayNhap;
        public DateTime NSNgayNhap { get => _NSNgayNhap; set { _NSNgayNhap = value; OnPropertyChanged(); } }

        private string _NSSoLuong;
        public string NSSoLuong { get => _NSSoLuong; set { _NSSoLuong = value; OnPropertyChanged(); } }

         private string _NSTongTien;
        public string NSTongTien { get => _NSTongTien; set { _NSTongTien = value; OnPropertyChanged(); } }


        private string _DGMaDG;
        public string DGMaDG { get => _DGMaDG; set { _DGMaDG = value; OnPropertyChanged(); } }

        private string _DGHoTen;
        public string DGHoTen { get => _DGHoTen; set { _DGHoTen = value; OnPropertyChanged(); } }

        private string _DGGioiTinh;
        public string DGGioiTinh { get => _DGGioiTinh; set { _DGGioiTinh = value; OnPropertyChanged(); } }

        private string _DGCMND;
        public string DGCMND { get => _DGCMND; set { _DGCMND = value; OnPropertyChanged(); } }

        private DateTime _DGNgaySinh;
        public DateTime DGNgaySinh { get => _DGNgaySinh; set { _DGNgaySinh = value; OnPropertyChanged(); } }

        private string _DGSoDT;
        public string DGSoDT { get => _DGSoDT; set { _DGSoDT = value; OnPropertyChanged(); } }

        private string _DGDiaChi;
        public string DGDiaChi { get => _DGDiaChi; set { _DGDiaChi = value; OnPropertyChanged(); } }


        //TLNTongTien

        private string _TLNTongTien;
        public string TLNTongTien { get => _TLNTongTien; set { _TLNTongTien = value; OnPropertyChanged(); } }


        //TLChonNam

        private string _TLChonNam;
        public string TLChonNam { get => _TLChonNam;
            set { _TLChonNam = value;
                OnPropertyChanged();
                if (_TLChonNam != null || _TLChonNam != "ALL") {
                    THANHLYLIST = new ObservableCollection<THANHLYHUY>
                        (DataProvider.Ins.DB.THANHLYHUYs.Where(x=> x.NGAY.Value.Year.ToString() == _TLChonNam));
                    
                }
                if (_TLChonNam == "ALL")
                {
                    THANHLYLIST = new ObservableCollection<THANHLYHUY>(DataProvider.Ins.DB.THANHLYHUYs);

                }
            }

        }


        //TLChonThang

        private string _TLChonThang;
        public string TLChonThang
        {
            get => _TLChonThang;
            set
            {
                _TLChonThang = value;
                OnPropertyChanged();
                if (_TLChonThang != null || _TLChonThang != "ALL")
                {
                    THANHLYLIST = new ObservableCollection<THANHLYHUY>
                        (DataProvider.Ins.DB.THANHLYHUYs.Where(x => x.NGAY.Value.Month.ToString() == _TLChonThang));

                }
                if (_TLChonThang == "ALL")
                {
                    THANHLYLIST = new ObservableCollection<THANHLYHUY>(DataProvider.Ins.DB.THANHLYHUYs);

                }
            }

        }


        private string _NSChonThang;
        public string NSChonThang { get => _NSChonThang;
            set {
                _NSChonThang = value;
                OnPropertyChanged();
                if (_NSChonThang != null || _NSChonThang != "ALL") {

                    NSLIST = new ObservableCollection<NV_NHAP>();
                    foreach (var nhap in NHAPSACHLIST)
                    {
                        if(nhap.NGAYNHAP.Value.Month.ToString() == _NSChonThang)
                        {
                            foreach (var item in CHITIETNHAPLIST) {
                                if (item.MAPHIEU == nhap.MAPHIEU) {
                                    NV_NHAP nhapSach = new NV_NHAP(item.MASACH, item.MAPHIEU, item.MASACH, (int)item.SOLUONG,
                                       (DateTime)nhap.NGAYNHAP, (decimal)item.TONGTIEN);

                                    NSLIST.Add(nhapSach);
                                }
                            }
                        }
                      
                    }

                }
                if (_NSChonThang == "ALL") {
                    LoadNhapSach();
                }
            }

        }


        private string _NSChonNam;
        public string NSChonNam
        { get => _NSChonNam;
            set {
                _NSChonNam = value;
                OnPropertyChanged();
                if (_NSChonNam != null || _NSChonNam != "ALL") {

                    NSLIST = new ObservableCollection<NV_NHAP>();
                    foreach (var nhap in NHAPSACHLIST)
                    {
                        if (nhap.NGAYNHAP.Value.Year.ToString() == _NSChonNam)
                        {
                            foreach (var item in CHITIETNHAPLIST)
                            {
                                if (item.MAPHIEU == nhap.MAPHIEU)
                                {
                                    NV_NHAP nhapSach = new NV_NHAP(item.MASACH, item.MAPHIEU, item.MASACH, (int)item.SOLUONG,
                                       (DateTime)nhap.NGAYNHAP, (decimal)item.TONGTIEN);

                                    NSLIST.Add(nhapSach);
                                }
                            }
                        }

                    }

                }
                if (_NSChonNam == "ALL")
                {
                    LoadNhapSach();
                }
            }

        }

       
        private string _NSChonMaLoai;
        public string NSChonMaLoai
        {
            get => _NSChonMaLoai;
            set
            {
                _NSChonMaLoai = value;
                OnPropertyChanged();
                if (_NSChonMaLoai != null || _NSChonMaLoai != "Nhập mã mới"){// ma loai da ton tai

                    NSMASACHCBX = new ObservableCollection<string>();
                    NSMASACHCBX.Add("Nhập mã mới");
                    foreach (var item in SACHLIST)
                    {
                        if (item.MALOAISACH == _NSChonMaLoai)
                            NSMASACHCBX.Add(item.MASACH);
                    }
                    NhapSachMoi = false;
                }
                if (_NSChonMaLoai == "Nhập mã mới") {
                    NSMASACHCBX = new ObservableCollection<string>();
                    NSMASACHCBX.Add("Nhập mã mới");

                    NhapSachMoi = true;
                    NSNhapMaLoai = KhoiTaoMa(DataProvider.Ins.DB.LOAISACHes.Count() + 1, true);
                    NSNhapMaSach = KhoiTaoMa(DataProvider.Ins.DB.SACHes.Count() + 1, false);
                }
            }

        }

        private string _NSChonMaSach;
        public string NSChonMaSach
        {
            get => _NSChonMaSach;
            set
            {
                _NSChonMaSach = value;
                OnPropertyChanged();
                if (_NSChonMaSach == "Nhập mã mới")
                {
                    NhapSachMoi = true;
                    if (NSChonMaLoai != "Nhập mã mới")
                    {

                        NSNhapMaLoai = NSChonMaLoai;
                        NSNhapTenLoai = DataProvider.Ins.DB.LOAISACHes.Where(x => x.MALOAISACH == NSChonMaLoai).SingleOrDefault().TENLOAISACH;
                    }

                    else
                        NSNhapMaLoai = KhoiTaoMa(DataProvider.Ins.DB.LOAISACHes.Count() + 1, true);

                    NSNhapMaSach = KhoiTaoMa(DataProvider.Ins.DB.SACHes.Count() + 1, false);

                }
               

                else
                {
                    NhapSachMoi = false;
                }
            }

        }



        private string _DMChonLoaiSach;
        public string DMChonLoaiSach
        {
            get => _DMChonLoaiSach;
            set {
                _DMChonLoaiSach = value;
                OnPropertyChanged();
                if (_DMChonLoaiSach != null || _DMChonLoaiSach != "ALL") {
                    ObservableCollection<NV_DANGMUON> temp = new ObservableCollection<NV_DANGMUON>();
                    LoadDangMuon();
                    foreach(var item in DANGMUONLIST) {
                        if(item.MALOAISACH == _DMChonLoaiSach) {
                            temp.Add(item);
                        }
                    }
                    DANGMUONLIST = new ObservableCollection<NV_DANGMUON>();
                    DANGMUONLIST = temp;
                   
                }
                if (_DMChonLoaiSach == "ALL") {
                    DANGMUONLIST = new ObservableCollection<NV_DANGMUON>();
                    LoadDangMuon();
                }
            }
        }


        private string _DMChonNgayMuon;
        public string DMChonNgayMuon
        {
            get => _DMChonNgayMuon;
            set
            {
                _DMChonNgayMuon = value;
                OnPropertyChanged();
                if (_DMChonNgayMuon != null || _DMChonNgayMuon.ToString() != "ALL") {
                    ObservableCollection<NV_DANGMUON> temp = new ObservableCollection<NV_DANGMUON>();
                    LoadDangMuon();
                    foreach (var item in DANGMUONLIST)
                    {
                        if (item.NGAYMUON.ToShortDateString() == _DMChonNgayMuon)
                        {
                            temp.Add(item);
                        }
                    }
                    DANGMUONLIST = new ObservableCollection<NV_DANGMUON>();
                    DANGMUONLIST = temp;
                }
                if (_DMChonNgayMuon.ToString() == "ALL")
                {
                    DANGMUONLIST = new ObservableCollection<NV_DANGMUON>();
                    LoadDangMuon();
                }
            }
        }


        private string _DMChonNgayTra;
        public string DMChonNgayTra
        {
            get => _DMChonNgayTra;
            set
            {
                _DMChonNgayTra = value;
                OnPropertyChanged();
                if (_DMChonNgayTra != null || _DMChonNgayTra.ToString() != "ALL")
                {
                    LoadDangMuon();
                    ObservableCollection<NV_DANGMUON> temp = new ObservableCollection<NV_DANGMUON>();
                    foreach (var item in DANGMUONLIST)
                    {
                        if (item.NGAYTRA.ToShortDateString() == DMChonNgayTra)
                        {
                            temp.Add(item);
                        }
                    }
                    DANGMUONLIST = new ObservableCollection<NV_DANGMUON>();
                    DANGMUONLIST = temp;
                }
                if (_DMChonNgayTra.ToString() == "ALL")
                {
                    DANGMUONLIST = new ObservableCollection<NV_DANGMUON>();
                    LoadDangMuon();
                }
            }
        }


        private string _LSChonLoaiSach;
        public string LSChonLoaiSach
        {
            get => _LSChonLoaiSach;
            set
            {
                _LSChonLoaiSach = value;
                OnPropertyChanged();
                if (_LSChonLoaiSach != null || _LSChonLoaiSach != "ALL")
                {
                    ObservableCollection<NV_DANGMUON> temp = new ObservableCollection<NV_DANGMUON>();
                    LoadDaTra();
                    foreach (var item in DATRALIST)
                    {
                        if (item.MALOAISACH == _LSChonLoaiSach)
                        {
                            temp.Add(item);
                        }
                    }
                    DATRALIST = new ObservableCollection<NV_DANGMUON>();
                    DATRALIST = temp;

                }
                if (_LSChonLoaiSach == "ALL")
                {
                    DATRALIST = new ObservableCollection<NV_DANGMUON>();
                    LoadDaTra();
                }
            }
        }


        private string _LSChonNgayMuon;
        public string LSChonNgayMuon
        {
            get => _LSChonNgayMuon;
            set
            {
                _LSChonNgayMuon = value;
                OnPropertyChanged();
                if (_LSChonNgayMuon != null || _LSChonNgayMuon.ToString() != "ALL")
                {
                    ObservableCollection<NV_DANGMUON> temp = new ObservableCollection<NV_DANGMUON>();
                    LoadDaTra();
                    foreach (var item in DATRALIST)
                    {
                        if (item.NGAYMUON.ToShortDateString() == _LSChonNgayMuon)
                        {
                            temp.Add(item);
                        }
                    }
                    DATRALIST = new ObservableCollection<NV_DANGMUON>();
                    DATRALIST = temp;
                }
                if (_LSChonNgayMuon.ToString() == "ALL")
                {
                    DATRALIST = new ObservableCollection<NV_DANGMUON>();
                    LoadDaTra();
                }
            }
        }


        private string _LSChonNgayTra;
        public string LSChonNgayTra
        {
            get => _LSChonNgayTra;
            set
            {
                _LSChonNgayTra = value;
                OnPropertyChanged();
                if (_LSChonNgayTra != null || _LSChonNgayTra.ToString() != "ALL")
                {
                    LoadDaTra();
                    ObservableCollection<NV_DANGMUON> temp = new ObservableCollection<NV_DANGMUON>();
                    foreach (var item in DATRALIST)
                    {
                        if (item.NGAYTRA.ToShortDateString() == _LSChonNgayTra)
                        {
                            temp.Add(item);
                        }
                    }
                    DATRALIST = new ObservableCollection<NV_DANGMUON>();
                    DATRALIST = temp;
                }
                if (_LSChonNgayTra.ToString() == "ALL")
                {
                    DATRALIST = new ObservableCollection<NV_DANGMUON>();
                    LoadDaTra();
                }
            }
        }

        public bool SelectedVP = false;
        private PHAT _VPSelectedIndex;
        public PHAT VPSelectedIndex
        {
            get => _VPSelectedIndex;
            set {
                _VPSelectedIndex = value;
                OnPropertyChanged();
                if (_VPSelectedIndex != null) {
                    SelectedVP = true;
                }
            }
        }

        
        private DOCGIA _DGSelectedItem;
        public DOCGIA DGSelectedItem
        {
            get => _DGSelectedItem;
            set
            {
                _DGSelectedItem = value;
                OnPropertyChanged();
                if (_DGSelectedItem != null)
                {
                    DGXemTT = true;
                    DGMaDG = _DGSelectedItem.MADG;
                    DGHoTen = _DGSelectedItem.TEN;
                    DGGioiTinh = _DGSelectedItem.GIOITINH;
                    DGDiaChi = _DGSelectedItem.DIACHI;
                    DGCMND = _DGSelectedItem.CMND;
                    DGSoDT = _DGSelectedItem.SODT;
                    DGNgaySinh =(DateTime) _DGSelectedItem.NGAYSINH;
                }
            }
        }


        //VPChonMaDG VPGhiChu DGSelectedItem
        private string _VPChonMaDG;
        public string VPChonMaDG {
            get => _VPChonMaDG;
            set{
                _VPChonMaDG = value;
                OnPropertyChanged();
               
            }
        }

        private string _VPGhiChu;
        public string VPGhiChu
        {
            get => _VPGhiChu;
            set
            {
                _VPGhiChu = value;
                OnPropertyChanged();

            }
        }

        public NhanVienViewModel()
        {
            SettingGrid = SachGrid = DangMuonGrid = DaTraGrid= DGXemTT
                = TTDocGiaGrid = NhapSachGrid = LogOutGrid =SachDaHuyGrid=
                NhapHuyGrid=NhapThanhLyGrid= ThemNhapSachGrid
                =SachThanhLyGrid=ViPhamGrid=DocGiaGrid= NhapSachMoi=false;

            TLNNgay = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            NSNgayNhap = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);



            SettingCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                SettingGrid = true;
                SachGrid =ViPhamGrid=DocGiaGrid=SachDaHuyGrid=SachThanhLyGrid=
                TTDocGiaGrid = LogOutGrid = ThemNhapSachGrid=
                NhapHuyGrid = NhapThanhLyGrid= DGXemTT=
                NhapSachGrid = DangMuonGrid = DaTraGrid = false;

            });
            SachCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
            
                SachGrid = true;
                SettingGrid = TTDocGiaGrid = ThemNhapSachGrid = DGXemTT=
                  NhapHuyGrid = NhapThanhLyGrid = 
                  SachThanhLyGrid =SachDaHuyGrid=DocGiaGrid=ViPhamGrid= 
                  LogOutGrid = NhapSachGrid = DangMuonGrid = DaTraGrid = false;

            });
            DangXuatCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                LogOutGrid = true;
                SachGrid = TTDocGiaGrid = ThemNhapSachGrid = DGXemTT=
                  NhapHuyGrid = NhapThanhLyGrid = 
                  SachThanhLyGrid =SachDaHuyGrid=DocGiaGrid=ViPhamGrid= SettingGrid = NhapSachGrid = DangMuonGrid = DaTraGrid = false;

            });
            ThongTinDocGiaCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                TTDocGiaGrid = true;
                SachGrid = SettingGrid = NhapHuyGrid = NhapThanhLyGrid = ThemNhapSachGrid = DGXemTT=
                SachThanhLyGrid = SachDaHuyGrid = DocGiaGrid = ViPhamGrid = LogOutGrid = NhapSachGrid = DangMuonGrid = DaTraGrid = false;

            });

            SachThanhLyCommand = new RelayCommand<object>((p) => { return true; }, (p) => {

                SachThanhLyGrid = true;
                SachGrid = TTDocGiaGrid = NhapHuyGrid = NhapThanhLyGrid = ThemNhapSachGrid = DGXemTT=
                SachDaHuyGrid = DocGiaGrid = ViPhamGrid= LogOutGrid= NhapSachGrid
                = SettingGrid = DangMuonGrid = DaTraGrid = false;

            });
            DangMuonCommand = new RelayCommand<object>((p) => { return true; }, (p) => {

                DangMuonGrid = true;
                SachGrid = TTDocGiaGrid = NhapHuyGrid = NhapThanhLyGrid = ThemNhapSachGrid = DGXemTT=
                SachThanhLyGrid = SachDaHuyGrid = DocGiaGrid = ViPhamGrid = LogOutGrid = NhapSachGrid = SettingGrid = DaTraGrid = false;

            });
            DaTraCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                DaTraGrid = true;
                SachGrid = TTDocGiaGrid = SachThanhLyGrid = SachDaHuyGrid
                = DocGiaGrid = ViPhamGrid = NhapHuyGrid = NhapThanhLyGrid = ThemNhapSachGrid = DGXemTT=
                LogOutGrid = NhapSachGrid = DangMuonGrid = SettingGrid = false;

            });
           
            SachDaHuyCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                SachDaHuyGrid = true;
                SachGrid = TTDocGiaGrid = NhapHuyGrid = NhapThanhLyGrid = ThemNhapSachGrid = DGXemTT=
                SachThanhLyGrid = DaTraGrid = DocGiaGrid = ViPhamGrid = LogOutGrid = NhapSachGrid = DangMuonGrid = SettingGrid = false;

            });

            DanhSachDocGiaCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                DocGiaGrid = true;
                SachGrid = TTDocGiaGrid = NhapHuyGrid = NhapThanhLyGrid = ThemNhapSachGrid = DGXemTT=
                SachThanhLyGrid = SachDaHuyGrid = DaTraGrid = ViPhamGrid = LogOutGrid = NhapSachGrid = DangMuonGrid = SettingGrid = false;

            });

            DocGiaViPhamCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                ViPhamGrid = true;
                SachGrid = TTDocGiaGrid = NhapHuyGrid = NhapThanhLyGrid = ThemNhapSachGrid = DGXemTT=
                SachThanhLyGrid = SachDaHuyGrid = DocGiaGrid = DaTraGrid = LogOutGrid = NhapSachGrid = DangMuonGrid = SettingGrid = false;

            });

            NhapSachCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                NhapSachGrid = true;
                SachGrid = TTDocGiaGrid = NhapHuyGrid = NhapThanhLyGrid = ThemNhapSachGrid = DGXemTT=
                SachThanhLyGrid = SachDaHuyGrid = DocGiaGrid = DaTraGrid = LogOutGrid = DaTraGrid = DangMuonGrid = SettingGrid = false;

            });



            SACHLIST = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes);
            LOAISACHLIST = new ObservableCollection<LOAISACH>(DataProvider.Ins.DB.LOAISACHes);

            NHANVIENList = new ObservableCollection<NHANVIEN>(DataProvider.Ins.DB.NHANVIENs);
            TAIKHOANNVList = new ObservableCollection<TAIKHOANNV>(DataProvider.Ins.DB.TAIKHOANNVs);

            PHIEUDDLIST = new ObservableCollection<PHIEUGIAODICH>(DataProvider.Ins.DB.PHIEUGIAODICHes);
            PHIEUSACHLIST = new ObservableCollection<PHIEUSACH>(DataProvider.Ins.DB.PHIEUSACHes);

            THANHLYLIST = new ObservableCollection<THANHLYHUY>(DataProvider.Ins.DB.THANHLYHUYs);

            NHAPSACHLIST = new ObservableCollection<NHAPSACH>(DataProvider.Ins.DB.NHAPSACHes);
            CHITIETNHAPLIST = new ObservableCollection<CHITIETNHAP>(DataProvider.Ins.DB.CHITIETNHAPs);

            KHOLIST = new ObservableCollection<KHO>(DataProvider.Ins.DB.KHOes);

            DGLIST = new ObservableCollection<DOCGIA>(DataProvider.Ins.DB.DOCGIAs);
            VPLIST = new ObservableCollection<PHAT>(DataProvider.Ins.DB.PHATs);

            DANGMUONLIST = new ObservableCollection<NV_DANGMUON>();
            DATRALIST = new ObservableCollection<NV_DANGMUON>();
            NSLIST = new ObservableCollection<NV_NHAP>();
            NSTHEMLIST = new ObservableCollection<NV_NHAP>();
            KHOSACHLIST = new ObservableCollection<KHOSACH>();

            LOAICBX = new ObservableCollection<string>();
            NAMSXCBX = new ObservableCollection<string>();
            TACGIACBX = new ObservableCollection<string>();

            DMLOAICBX = new ObservableCollection<string>();
            DMNGAYMUONCBX = new ObservableCollection<string>();
            DMNGAYTRACBX = new ObservableCollection<string>();

            LSLOAICBX = new ObservableCollection<string>();
            LSNGAYMUONCBX = new ObservableCollection<string>();
            LSNGAYTRACBX = new ObservableCollection<string>();

            TLNAMCBX = new ObservableCollection<string>();
            TLTHANGCBX = new ObservableCollection<string>();


            NSNAMCBX = new ObservableCollection<string>();
            NSTHANGCBX = new ObservableCollection<string>();

            TLNLOAICBX = new ObservableCollection<string>();
            TLNMASACHCBX = new ObservableCollection<string>();

            NSMALOAICBX = new ObservableCollection<string>();
            NSMASACHCBX = new ObservableCollection<string>();

            MaDGCBX = new ObservableCollection<string>();

            NSMALOAICBX.Add("Nhập mã mới");
            NSMASACHCBX.Add("Nhập mã mới");

            TLNAMCBX.Add("ALL");
            TLTHANGCBX.Add("ALL");
           
            
            DMLOAICBX.Add("ALL");
            DMNGAYTRACBX.Add("ALL");
            DMNGAYMUONCBX.Add("ALL");

            LSLOAICBX.Add("ALL");
            LSNGAYTRACBX.Add("ALL");
            LSNGAYMUONCBX.Add("ALL");

            // dang muon - da tra
            foreach (var item in PHIEUDDLIST) {
                if (item.NGAYTRA > DateTime.Today){

                    if(CkeckCombobox(item.NGAYTRA.Value.ToShortDateString(), DMNGAYTRACBX)) {
                        DMNGAYTRACBX.Add(item.NGAYTRA.Value.ToShortDateString());
                    }
                        
                    if(CkeckCombobox(item.NGAYMUON.Value.ToShortDateString(), DMNGAYMUONCBX)) {
                        DMNGAYMUONCBX.Add(item.NGAYMUON.Value.ToShortDateString());
                    }
                       

                    foreach (var item1 in PHIEUSACHLIST) {
                        if (item1.MAPHIEU == item.MAPHIEU){
                            var sach = DataProvider.Ins.DB.SACHes.Where(x => x.MASACH == item1.MASACH).SingleOrDefault();
                            if (sach != null) {
                                DANGMUONLIST.Add(new NV_DANGMUON(item, sach, item1));
                                if(CkeckCombobox(sach.MALOAISACH, DMLOAICBX)) {
                                    DMLOAICBX.Add(sach.MALOAISACH);
                                }
                            }
                        }

                    }

                }
                else{
                    if (CkeckCombobox(item.NGAYTRA.Value.ToShortDateString(), LSNGAYTRACBX)){
                        LSNGAYTRACBX.Add(item.NGAYTRA.Value.ToShortDateString());
                    }

                    if (CkeckCombobox(item.NGAYMUON.Value.ToShortDateString(), LSNGAYMUONCBX)) {
                        LSNGAYMUONCBX.Add(item.NGAYMUON.Value.ToShortDateString());
                    }


                    foreach (var item1 in PHIEUSACHLIST) {
                        if (item1.MAPHIEU == item.MAPHIEU) {
                            var sach = DataProvider.Ins.DB.SACHes.Where(x => x.MASACH == item1.MASACH).SingleOrDefault();
                            if (sach != null) {
                                DATRALIST.Add(new NV_DANGMUON(item, sach, item1));
                                if (CkeckCombobox(sach.MALOAISACH, LSLOAICBX)) {
                                    LSLOAICBX.Add(sach.MALOAISACH);
                                }
                            }
                        }

                    }

                }
            }

           foreach(var item in THANHLYLIST)
            {
                if (CkeckCombobox(item.NGAY.Value.Month.ToString(), TLTHANGCBX))
                    TLTHANGCBX.Add(item.NGAY.Value.Month.ToString());
                if (CkeckCombobox(item.NGAY.Value.Year.ToString(), TLNAMCBX))
                    TLNAMCBX.Add(item.NGAY.Value.Year.ToString());
               
            }

            // nhap sach
            NSNAMCBX.Add("ALL");
            NSTHANGCBX.Add("ALL");

            // load NHAPSACHLIST
           foreach(var item in NHAPSACHLIST){
                if (CkeckCombobox(item.NGAYNHAP.Value.Month.ToString(), NSTHANGCBX))
                    NSTHANGCBX.Add(item.NGAYNHAP.Value.Month.ToString());

                if (CkeckCombobox(item.NGAYNHAP.Value.Year.ToString(), NSNAMCBX))
                    NSNAMCBX.Add(item.NGAYNHAP.Value.Year.ToString());
                foreach(var item1 in CHITIETNHAPLIST)
                {
                    if(item1.MAPHIEU == item.MAPHIEU)
                    {
                        var NSSach = DataProvider.Ins.DB.SACHes.Where(x => x.MASACH == item1.MASACH).SingleOrDefault();
                        var NSNhap = new NV_NHAP(item1.MASACH, item1.MAPHIEU, NSSach.TENSACH,
                            (int)item1.SOLUONG, (DateTime)item.NGAYNHAP, (decimal)item1.TONGTIEN);
                        NSLIST.Add(NSNhap);
                    }
                }
               
            }

            LOAICBX.Add("ALL");
            foreach (var item in LOAISACHLIST)
            {
                LOAICBX.Add(item.TENLOAISACH);
                TLNLOAICBX.Add(item.MALOAISACH);
            }
            

            TACGIACBX.Add("ALL");
            NAMSXCBX.Add("ALL");

            foreach (var item in SACHLIST)
            {
                if (CkeckCombobox(item.TACGIA, TACGIACBX))
                    TACGIACBX.Add(item.TACGIA);
                if (CkeckCombobox(item.NAMSX.ToString(), NAMSXCBX))
                    NAMSXCBX.Add(item.NAMSX.ToString());
                if (CkeckCombobox(item.MALOAISACH, NSMALOAICBX))
                    NSMALOAICBX.Add(item.MALOAISACH);

                var item1 = DataProvider.Ins.DB.KHOes.Where(x => x.MASACH == item.MASACH).SingleOrDefault();
                if (item1 != null)
                    KHOSACHLIST.Add(new KHOSACH(item, (int)item1.SOLUONG));

            }

            foreach(var item in DGLIST) {
                MaDGCBX.Add(item.MADG);
            }

            STSetting = new RelayCommand<object>((p) => {
                return true;
            },
         (p) => {

             Setting();
         });

            STHuy = new RelayCommand<object>((p) => { return true; }, (p) => {
                LoadTTNhanVien();
            });


            LODangXuat = new RelayCommand<Window>((p) => {
                return true;
            },
        (p) => {

            MainWindow main = new MainWindow();
            main.Show();
            p.Close();
        });


            LOHuy = new RelayCommand<object>((p) => { return true; }, (p) => {
                LogOutGrid = false;
            });


            TLNhap = new RelayCommand<object>(
                (p)=> { return true; },
                (p) =>
                {
                    NhapThanhLyGrid = true;
                    SachThanhLyGrid = false;
                  
                }
                );

            TLThem = new RelayCommand<object>(
                (p) => { return true; },

                (p) =>
                {
                    int count = DataProvider.Ins.DB.THANHLYHUYs.Count();
                    string maPhieuThanhLy = KhoiTaoMaPhieu(count + 1);
                 
                    
                    var thanhLy = new THANHLYHUY() {
                        MAPHIEU = maPhieuThanhLy,
                        MASACH = TNLChonMaSach,
                        SOLUONG = int.Parse(TLNSoLuong.Trim()),
                        TIEN = decimal.Parse(TLNTongTien.Trim()),
                        GHICHU = TLNGhiChu,
                        NGAY = TLNNgay
                    };

                    THANHLYLIST.Add(thanhLy);
                    DataProvider.Ins.DB.THANHLYHUYs.Add(thanhLy);
                    DataProvider.Ins.DB.SaveChanges();

                    
                    var sachKho = DataProvider.Ins.DB.KHOes.Where(x => x.MASACH == thanhLy.MASACH).SingleOrDefault();
                    sachKho.SOLUONG -= thanhLy.SOLUONG;


                    if (CkeckCombobox(TLNNgay.Month.ToString(), TLTHANGCBX))
                        TLTHANGCBX.Add(TLNNgay.Month.ToString());

                    if (CkeckCombobox(TLNNgay.Year.ToString(), TLTHANGCBX))
                        TLTHANGCBX.Add(TLNNgay.Year.ToString());

                    NhapThanhLyGrid = false;
                    SachThanhLyGrid = true;
                }
                );

            TLHuy= new RelayCommand<object>(
               (p) => { return true; },

               (p) =>
               {
                   NhapThanhLyGrid = false;
                   SachThanhLyGrid = true;
               }
               ); 

            NSNhap = new RelayCommand<object>(
                (p) => { return true; },
                (p) => {
                    NhapSachGrid = false;
                    ThemNhapSachGrid = true;
                }
                );

            NSThemVaoGio = new  RelayCommand<object>(
                (p) => { return true; },
                (p) => {
                    if (NSChonMaLoai != "Nhập mã mới" && NSChonMaSach != "Nhập mã mới")// nhap sach da co san
                    {
                        if (checkThongTinNhapSach1())  {
                            var nhap = new NV_NHAP(NSChonMaSach, int.Parse(NSSoLuong), decimal.Parse(NSTongTien));
                            NSTHEMLIST.Add(nhap);
                            NSSoLuong = NSTongTien = "";
                        }
                        else
                        {
                            MessageBox.Show("Thong tin nhap vao khong hop le ");
                        }
                      
                    }
                    else  {
                        if (NSChonMaLoai == "Nhập mã mới") // nhap sach moi 
                        {
                            var loai = new LOAISACH()
                            {
                                MALOAISACH = NSNhapMaLoai,
                                TENLOAISACH = NSNhapTenLoai,
                            };
                            DataProvider.Ins.DB.LOAISACHes.Add(loai);
                            DataProvider.Ins.DB.SaveChanges();
                            LOAICBX.Add(NSNhapTenLoai);
                            if(CkeckCombobox(loai.MALOAISACH,NSMALOAICBX))
                            NSMALOAICBX.Add(loai.MALOAISACH);
                        }

                        if (checkThongTinNhapSach2())  {
                            var sach = new SACH()
                            {
                                MASACH = NSNhapMaSach,
                                MALOAISACH = NSNhapMaLoai,
                                TENSACH = NSNhapTenSach,
                                TACGIA = NSNhapTacGia,
                                NAMSX = int.Parse(NSNhapNamSX),
                                GIASACH = decimal.Parse(NSNhapGia)
                            };
                            DataProvider.Ins.DB.SACHes.Add(sach);
                            DataProvider.Ins.DB.SaveChanges();

                            NSMASACHCBX.Add(sach.MASACH);

                            if (CkeckCombobox(NSNhapNamSX, NAMSXCBX))
                                NAMSXCBX.Add(NSNhapNamSX);
                            if (CkeckCombobox(NSNhapTacGia, TACGIACBX))
                                TACGIACBX.Add(NSNhapTacGia);
                            
                            var nhap = new NV_NHAP(sach.MASACH, int.Parse(NSSoLuong),decimal.Parse(NSTongTien));

                            NSTHEMLIST.Add(nhap);
                            NSTongTien = NSNhapTacGia=NSNhapMaLoai=NSNhapMaSach = NSNhapNamSX = NSNhapTenLoai = NSNhapTenSach=NSNhapGia = "";

                        }

                        else
                        {
                            MessageBox.Show("Thong tin nhap vao khong hop le ");
                        }


                    }
                }
                );

            NSThem = new RelayCommand<object>(
               (p) => { return true; },
               (p) => {

                   NSTHEMLIST = new ObservableCollection<NV_NHAP>();
                   string ma = "";
                   ma = KhoiTaoMaPhieu(DataProvider.Ins.DB.NHAPSACHes.Count() + 1);
                   // THEM NHAP
                   decimal tongtien = 0;
                   foreach (var item in NSTHEMLIST) {
                       tongtien += item.TONGTIEN;
                   }
                   var nhapsach = new NHAPSACH()
                   {
                       MAPHIEU = ma,
                       NGAYNHAP = DateTime.Today,
                       TONGTIEN = tongtien
                   };

                   DataProvider.Ins.DB.NHAPSACHes.Add(nhapsach);
                   DataProvider.Ins.DB.SaveChanges();


                   foreach (var item in NSTHEMLIST)  {
                       var sach = DataProvider.Ins.DB.SACHes.Where(x => x.MASACH == item.MASACH).SingleOrDefault();
                       // add chi tiet nhap
                       var chitiet = new CHITIETNHAP()
                       {
                           MAPHIEU = ma,
                           MASACH = item.MASACH,
                           SOLUONG = item.SOLUONG,
                           TONGTIEN = item.TONGTIEN,
                       };

                       DataProvider.Ins.DB.CHITIETNHAPs.Add(chitiet);
                       DataProvider.Ins.DB.SaveChanges();

                       // add/ cap nhat kho
                       var sachkho = DataProvider.Ins.DB.KHOes.Where(x => x.MASACH == sach.MASACH).SingleOrDefault();
                       if(sachkho != null)
                       {
                           sachkho.SOLUONG += item.SOLUONG;
                           DataProvider.Ins.DB.SaveChanges();
                       }
                       else
                       {
                           var kho = new KHO()
                           {
                               MASACH = item.MASACH,
                               SOLUONG = item.SOLUONG
                           };
                           DataProvider.Ins.DB.KHOes.Add(kho);
                           DataProvider.Ins.DB.SaveChanges();

                       }

                       var nhapSach = new NV_NHAP(sach.MASACH, chitiet.MAPHIEU, sach.TENSACH,
                           (int)chitiet.SOLUONG, DateTime.Today, (decimal)nhapsach.TONGTIEN);

                       NSLIST.Add(nhapSach);


                   }

                  


                   NhapSachGrid = true;
                   ThemNhapSachGrid = false;
               }
               );

            NSHuy = new RelayCommand<object>(
               (p) => { return true; },
               (p) => {
                   NhapSachGrid = true;
                   ThemNhapSachGrid = false;
               }
               );

            VPXoa = new RelayCommand<object>(
                (p) =>
                {
                    if (SelectedVP) return true;
                    return false;
                },
                (p) =>
                {
                    var phat = DataProvider.Ins.DB.PHATs.Where(x => x.MADG == VPSelectedIndex.MADG).SingleOrDefault();
                    VPLIST.Remove(phat);
                    DataProvider.Ins.DB.PHATs.Remove(phat);
                    DataProvider.Ins.DB.SaveChanges();

                });

            VPThem = new RelayCommand<object>(
                (p) => {
                    if (VPChonMaDG != "")
                        return true;
                    return false;
                },
                (p) => {
                    if(VPChonMaDG != "") {
                        var phat = new PHAT(){
                            MADG = VPChonMaDG,
                            NGAY = DateTime.Today,
                            GHICHU = VPGhiChu
                        };

                        VPLIST.Add(phat);
                        DataProvider.Ins.DB.PHATs.Add(phat);
                        DataProvider.Ins.DB.SaveChanges();
                        VPChonMaDG = VPGhiChu = "";

                    }
               
                }
                );
            VPHuy = new RelayCommand<object>(
                (p) => {
                    return true;
                },
                (p)=> {
                    VPChonMaDG = VPGhiChu = "";
                } 
                );


            KSTimKiem = new RelayCommand<object>(
              (p) => {
                  return true;
              },
              (p) => {
                  if (KSThongTinTimKiem != "")
                  {
                      var KSTemp = new ObservableCollection<KHOSACH>();
                      KSTemp = KHOSACHLIST;

                      KHOSACHLIST = new ObservableCollection<KHOSACH>();
                      KSThongTinTimKiem = KSThongTinTimKiem.ToLower();
                      KSThongTinTimKiem = ConvertToUnSign(KSThongTinTimKiem);
                      foreach (var item in KSTemp)
                      {
                          string temp = item.TENSACH.ToLower();
                          temp = ConvertToUnSign(temp);
                          if (temp.Contains(KSThongTinTimKiem))
                              KHOSACHLIST.Add(item);
                      }
                  }
                  else
                  {
                      KHOSACHLIST = new ObservableCollection<KHOSACH>();
                      foreach(var item in SACHLIST)
                      {
                          var kho = DataProvider.Ins.DB.KHOes.Where(x => x.MASACH == item.MASACH).SingleOrDefault();
                          KHOSACHLIST.Add(new KHOSACH(item, (int)kho.SOLUONG));
                      }

                  }

              }
              );

            DMTimKiem = new RelayCommand<object>(
              (p) => {
                  return true;
              },
              (p) => {
                  if (DMThongTinTimKiem != "")
                  {
                      var DMTemp = new ObservableCollection<NV_DANGMUON>();
                      DMTemp = DANGMUONLIST;
                      DANGMUONLIST = new ObservableCollection<NV_DANGMUON>();

                      DMThongTinTimKiem = DMThongTinTimKiem.ToLower();
                      DMThongTinTimKiem = ConvertToUnSign(DMThongTinTimKiem);
                      foreach (var item in DMTemp)
                      {
                          string temp = item.TENSACH.ToLower();
                          temp = ConvertToUnSign(temp);
                          if (temp.Contains(DMThongTinTimKiem))
                              DANGMUONLIST.Add(item);
                      }
                  }
                  else
                  {
                      LoadDangMuon();
                  }

              }
              );

            LSTimKiem = new RelayCommand<object>(
             (p) => {
                 return true;
             },
             (p) => {
                 if (LSThongTinTimKiem != "")
                 {
                     var DMTemp = new ObservableCollection<NV_DANGMUON>();
                     DMTemp = DATRALIST;
                     DATRALIST = new ObservableCollection<NV_DANGMUON>();

                     LSThongTinTimKiem = LSThongTinTimKiem.ToLower();
                     LSThongTinTimKiem = ConvertToUnSign(LSThongTinTimKiem);
                     foreach (var item in DMTemp)
                     {
                         string temp = item.TENSACH.ToLower();
                         temp = ConvertToUnSign(temp);
                         if (temp.Contains(LSThongTinTimKiem))
                             DATRALIST.Add(item);
                     }
                 }
                 else
                 {
                     LoadDaTra();
                 }

             }
             );


            NSTimKiem = new RelayCommand<object>(
             (p) => {
                 return true;
             },
             (p) => {
                 if (NSThongTinTimKiem != "")
                 {
                     var DMTemp = new ObservableCollection<NV_NHAP>();
                     DMTemp = NSLIST;
                     NSLIST = new ObservableCollection<NV_NHAP>();

                     NSThongTinTimKiem = NSThongTinTimKiem.ToLower();
                     NSThongTinTimKiem = ConvertToUnSign(NSThongTinTimKiem);
                     foreach (var item in DMTemp)
                     {
                         string temp = item.TENSACH.ToLower();
                         temp = ConvertToUnSign(temp);
                         if (temp.Contains(NSThongTinTimKiem))
                             NSLIST.Add(item);
                     }
                 }
                 else
                 {
                     LoadNhapSach();
                 }

             }
             );

        
            DGTimKiem = new RelayCommand<object>(

              (p) => {
                  return true;
              },
              (p) => {
                  if (DGThongTinTimKiem != "")
                  {
                      DGLIST = new ObservableCollection<DOCGIA>();
                      DGThongTinTimKiem = DGThongTinTimKiem.ToLower();
                      DGThongTinTimKiem = ConvertToUnSign(DGThongTinTimKiem);
                      foreach (var item in DataProvider.Ins.DB.DOCGIAs)
                      {
                          string temp = item.TEN.ToLower();
                          temp = ConvertToUnSign(temp);
                          if (temp.Contains(DGThongTinTimKiem))
                              DGLIST.Add(item);
                      }
                  }
                  else
                  {
                      DGLIST = new ObservableCollection<DOCGIA>(DataProvider.Ins.DB.DOCGIAs);
                  }

              }
              );
            
        }
        
        public NhanVienViewModel(string passUserName) : this()
        {

            this.passUserName = passUserName;
            LoadTTNhanVien();
        }

        void LoadTTNhanVien()
        {
            string temp = "";
            foreach (var temp1 in TAIKHOANNVList)
            {
                if (temp1.TENTK == passUserName)
                {
                    temp = temp1.MANV;
                    break;
                }
            }

            if (temp != "")
            {
                foreach (var temp1 in NHANVIENList)
                {
                    if (temp1.MANV == temp)
                    {
                       TTMaNHANVIEN = temp1.MANV;
                        TTHoTen = temp1.TEN;
                        TTGioiTinh = temp1.GIOITINH;
                        TTNgaySinh = (DateTime)temp1.NGAYSINH;
                        TTDiaChi = temp1.DIACHI;
                        TTCMND = temp1.CMND;
                        TTSoDT = temp1.SODT;

                    }
                }
            }


        }
        bool checkDataSetting()
        {
            // check sdt
            foreach (var c in TTSoDT.Trim())
            {
                if (c < 48 || c > 57)
                    return false;
            }
            //check cmnd
            foreach (var c in TTCMND.Trim())
            {
                if (c < 48 || c > 57)
                    return false;
            }

            if (TTGioiTinh.Trim() != "Nam"
                && TTGioiTinh.Trim() != "Nữ" &&
                TTGioiTinh.Trim() != "Khác" && TTGioiTinh.ToLower() != "nam"
                && TTGioiTinh.ToLower() != "nu" && TTGioiTinh.ToLower() != "khac")
                return false;

            if ((DateTime.Today.Year - TTNgaySinh.Year) < 3 ||
                (DateTime.Today.Year - TTNgaySinh.Year) > 130)
                return false;

            if (TTHoTen.Trim() == "" || TTCMND.Trim() == "" || TTDiaChi.Trim() == "" ||
                TTSoDT.Trim() == "")
                return false;

            return true;
        }

        void Setting()
        {
            if (checkDataSetting())
            {
                var temp = DataProvider.Ins.DB.NHANVIENs.Where(x => x.MANV == TTMaNHANVIEN).SingleOrDefault();

                temp.TEN = TTHoTen;
                temp.SODT = TTSoDT;
                temp.GIOITINH = TTGioiTinh;
                temp.DIACHI = TTDiaChi;
                temp.NGAYSINH = TTNgaySinh;
                DataProvider.Ins.DB.SaveChanges();

                MessageBox.Show("Lưu thành công");
            }
            else
            {
                MessageBox.Show("Thông tin nhập vào không hợp lệ");
            }

        }

        bool CkeckCombobox(string value,  ObservableCollection<string> List ) {
            if (List.Count == 0)
                return true;
            foreach(var item in List)
                if(item == value) {
                    return false;
                }
           
            return true;
        }

        void LoadDangMuon() {
            DANGMUONLIST = new ObservableCollection<NV_DANGMUON>();

            foreach (var item in PHIEUDDLIST) {
                if (item.NGAYTRA > DateTime.Today) {
                    foreach (var item1 in PHIEUSACHLIST) {
                        if (item1.MAPHIEU == item.MAPHIEU) {
                            var sach = DataProvider.Ins.DB.SACHes.Where(x => x.MASACH == item1.MASACH).SingleOrDefault();
                            if (sach != null){
                                DANGMUONLIST.Add(new NV_DANGMUON(item, sach, item1));
                            }
                        }

                    }

                }
            }


        }

        void LoadDaTra()
        {
            DATRALIST = new ObservableCollection<NV_DANGMUON>();

            foreach (var item in PHIEUDDLIST)
            {
                if (item.NGAYTRA <= DateTime.Today)
                {
                    foreach (var item1 in PHIEUSACHLIST)
                    {
                        if (item1.MAPHIEU == item.MAPHIEU)
                        {
                            var sach = DataProvider.Ins.DB.SACHes.Where(x => x.MASACH == item1.MASACH).SingleOrDefault();
                            if (sach != null)
                            {
                                DATRALIST.Add(new NV_DANGMUON(item, sach, item1));
                            }
                        }

                    }

                }
            }

        }

        void LoadNhapSach()
        {
            NSLIST = new ObservableCollection<NV_NHAP>();
          
            foreach (var item in NHAPSACHLIST){
                foreach (var item1 in CHITIETNHAPLIST) {
                    if (item1.MAPHIEU == item.MAPHIEU) {
                        var NSSach = DataProvider.Ins.DB.SACHes.Where(x => x.MASACH == item1.MASACH).SingleOrDefault();
                        var NSNhap = new NV_NHAP(item1.MASACH, item1.MAPHIEU, NSSach.MASACH,
                            (int)item1.SOLUONG, (DateTime)item.NGAYNHAP, (decimal)item1.TONGTIEN);
                        NSLIST.Add(NSNhap);
                    }
                }

            }

        }

        string KhoiTaoMaPhieu(int num)
        {
            string ma = "";

          
            if (num < 10)
            {
                ma = "MAPHIEU00" + num.ToString();
            }
            else if (num < 100)
            {
                ma = "MAPHIEU0" + num.ToString();
            }
            else ma = "MAPHIEU " + num.ToString();


            return ma;
        }


        // ma sach + ma loai sach
        string KhoiTaoMa(int num, bool type)
        {
            string ma = "";
            if (type)
            {
                if (num < 10)
                {
                    ma = "MALOAI00" + num.ToString();
                }
                else if (num < 100)
                {
                    ma = "MALOAI0" + num.ToString();
                }
                else ma = "MALOAI" + num.ToString();


            }
            else
            {
                if (num < 10)
                {
                    ma = "MASACH000" + num.ToString();
                }
                else if (num < 100)
                {
                    ma = "MASACH00" + num.ToString();
                }
                else if (num < 1000)
                {
                    ma = "MASACH0" + num.ToString();
                }
                else ma = "MASACH" + num.ToString();

            }

            return ma;
        }

        bool checkThongTinNhapSach1()
        {
            return true;
        }

        bool checkThongTinNhapSach2()
        {
            return true;
        }

        private string ConvertToUnSign(string input)
        {
            input = input.Trim();
            for (int i = 0x20; i < 0x30; i++)
            {
                input = input.Replace(((char)i).ToString(), " ");
            }
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string str = input.Normalize(NormalizationForm.FormD);
            string str2 = regex.Replace(str, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
            while (str2.IndexOf("?") >= 0)
            {
                str2 = str2.Remove(str2.IndexOf("?"), 1);
            }
            return str2;
        }


    }
}
