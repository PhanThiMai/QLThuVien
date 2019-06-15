using QLThuVien.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
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

        private bool _SachGrid;
        private bool _TTDocGiaGrid;
        private bool _LogOutGrid;
       
        private bool _DangMuonGrid;
        private bool _DaTraGrid;
        private bool _SettingGrid;
        private bool _SachThanhLyGrid;
        private bool _SachDaHuyGrid;
        private bool _NhapSachGrid;
        private bool _DocGiaGrid;
        private bool _ViPhamGrid;

        private bool _NhapThanhLyGrid;
        private bool _NhapHuyGrid;

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



        private ObservableCollection<SACH> _SACHList;
        public ObservableCollection<SACH> SACHLIST
        {
            get => _SACHList;
            set { _SACHList = value; OnPropertyChanged(); }
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

        //TLNChonMaLoai
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
        public string TLChonThang { get => _TLChonThang;
            set { _TLChonThang = value;
                OnPropertyChanged();
                if (_TLChonThang != null || _TLChonThang != "ALL") {
                    THANHLYLIST = new ObservableCollection<THANHLYHUY>
                         (DataProvider.Ins.DB.THANHLYHUYs.Where(x => x.NGAY.Value.Month.ToString() == _TLChonThang));

                }
                if (_TLChonThang == "ALL")
                {
                    THANHLYLIST = new ObservableCollection<THANHLYHUY>(DataProvider.Ins.DB.THANHLYHUYs);

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


        public NhanVienViewModel()
        {
            SettingGrid = SachGrid = DangMuonGrid = DaTraGrid
                = TTDocGiaGrid = NhapSachGrid = LogOutGrid =SachDaHuyGrid=
                NhapHuyGrid=NhapThanhLyGrid
                =SachThanhLyGrid=ViPhamGrid=DocGiaGrid= false;

            TLNNgay = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);

            SettingCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                SettingGrid = true;
                SachGrid =ViPhamGrid=DocGiaGrid=SachDaHuyGrid=SachThanhLyGrid=
                TTDocGiaGrid = LogOutGrid =
                NhapHuyGrid = NhapThanhLyGrid=
                NhapSachGrid = DangMuonGrid = DaTraGrid = false;

            });
            SachCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                _SachGrid = true;
                SachGrid = true;
                SettingGrid = TTDocGiaGrid =
                  NhapHuyGrid = NhapThanhLyGrid = 
                  SachThanhLyGrid =SachDaHuyGrid=DocGiaGrid=ViPhamGrid= LogOutGrid = NhapSachGrid = DangMuonGrid = DaTraGrid = false;

            });
            DangXuatCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                LogOutGrid = true;
                SachGrid = TTDocGiaGrid =
                  NhapHuyGrid = NhapThanhLyGrid = 
                  SachThanhLyGrid =SachDaHuyGrid=DocGiaGrid=ViPhamGrid= SettingGrid = NhapSachGrid = DangMuonGrid = DaTraGrid = false;

            });
            ThongTinDocGiaCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                TTDocGiaGrid = true;
                SachGrid = SettingGrid = NhapHuyGrid = NhapThanhLyGrid =
                SachThanhLyGrid = SachDaHuyGrid = DocGiaGrid = ViPhamGrid = LogOutGrid = NhapSachGrid = DangMuonGrid = DaTraGrid = false;

            });

            SachThanhLyCommand = new RelayCommand<object>((p) => { return true; }, (p) => {

                SachThanhLyGrid = true;
                SachGrid = TTDocGiaGrid = NhapHuyGrid = NhapThanhLyGrid = 
                SachDaHuyGrid = DocGiaGrid = ViPhamGrid= LogOutGrid= NhapSachGrid
                = SettingGrid = DangMuonGrid = DaTraGrid = false;

            });
            DangMuonCommand = new RelayCommand<object>((p) => { return true; }, (p) => {

                DangMuonGrid = true;
                SachGrid = TTDocGiaGrid = NhapHuyGrid = NhapThanhLyGrid =
                SachThanhLyGrid = SachDaHuyGrid = DocGiaGrid = ViPhamGrid = LogOutGrid = NhapSachGrid = SettingGrid = DaTraGrid = false;

            });
            DaTraCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                DaTraGrid = true;
                SachGrid = TTDocGiaGrid = SachThanhLyGrid = SachDaHuyGrid
                = DocGiaGrid = ViPhamGrid = NhapHuyGrid = NhapThanhLyGrid =
                LogOutGrid = NhapSachGrid = DangMuonGrid = SettingGrid = false;

            });
           
            SachDaHuyCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                SachDaHuyGrid = true;
                SachGrid = TTDocGiaGrid = NhapHuyGrid = NhapThanhLyGrid =
                SachThanhLyGrid = DaTraGrid = DocGiaGrid = ViPhamGrid = LogOutGrid = NhapSachGrid = DangMuonGrid = SettingGrid = false;

            });

            DanhSachDocGiaCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                DocGiaGrid = true;
                SachGrid = TTDocGiaGrid = NhapHuyGrid = NhapThanhLyGrid =
                SachThanhLyGrid = SachDaHuyGrid = DaTraGrid = ViPhamGrid = LogOutGrid = NhapSachGrid = DangMuonGrid = SettingGrid = false;

            });

            DocGiaViPhamCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                ViPhamGrid = true;
                SachGrid = TTDocGiaGrid = NhapHuyGrid = NhapThanhLyGrid =
                SachThanhLyGrid = SachDaHuyGrid = DocGiaGrid = DaTraGrid = LogOutGrid = NhapSachGrid = DangMuonGrid = SettingGrid = false;

            });

            NhapSachCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                NhapSachGrid = true;
                SachGrid = TTDocGiaGrid = NhapHuyGrid = NhapThanhLyGrid =
                SachThanhLyGrid = SachDaHuyGrid = DocGiaGrid = DaTraGrid = LogOutGrid = DaTraGrid = DangMuonGrid = SettingGrid = false;

            });



            SACHLIST = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes);
            LOAISACHLIST = new ObservableCollection<LOAISACH>(DataProvider.Ins.DB.LOAISACHes);
            NHANVIENList = new ObservableCollection<NHANVIEN>(DataProvider.Ins.DB.NHANVIENs);
            TAIKHOANNVList = new ObservableCollection<TAIKHOANNV>(DataProvider.Ins.DB.TAIKHOANNVs);
            PHIEUDDLIST = new ObservableCollection<PHIEUGIAODICH>(DataProvider.Ins.DB.PHIEUGIAODICHes);
            PHIEUSACHLIST = new ObservableCollection<PHIEUSACH>(DataProvider.Ins.DB.PHIEUSACHes);
            THANHLYLIST = new ObservableCollection<THANHLYHUY>(DataProvider.Ins.DB.THANHLYHUYs);

            DANGMUONLIST = new ObservableCollection<NV_DANGMUON>();
            DATRALIST = new ObservableCollection<NV_DANGMUON>();


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

            TLNLOAICBX = new ObservableCollection<string>();
            TLNMASACHCBX = new ObservableCollection<string>();


            TLNAMCBX.Add("ALL");
            TLTHANGCBX.Add("ALL");
           
            
            DMLOAICBX.Add("ALL");
            DMNGAYTRACBX.Add("ALL");
            DMNGAYMUONCBX.Add("ALL");

            LSLOAICBX.Add("ALL");
            LSNGAYTRACBX.Add("ALL");
            LSNGAYMUONCBX.Add("ALL");

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

            LOAICBX.Add("ALL");
            foreach (var item in LOAISACHLIST)
            {
                LOAICBX.Add(item.TENLOAISACH);
                TLNLOAICBX.Add(item.MALOAISACH);
            }

            string temp_nam = "";
            string temp_tg = "";

            TACGIACBX.Add("ALL");
            NAMSXCBX.Add("ALL");

            foreach (var item in SACHLIST)
            {
                if (item.TACGIA != temp_tg)
                    TACGIACBX.Add(item.TACGIA);
                if (item.NAMSX.ToString() != temp_nam)
                    NAMSXCBX.Add(item.NAMSX.ToString());

                temp_nam = item.NAMSX.ToString();
                temp_tg = item.TACGIA;

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
            foreach (var c in TTSoDT.Trim())
            {
                if (c < 48 || c > 57)
                    return false;
            }

            foreach (var c in TTCMND.Trim())
            {
                if (c < 48 || c > 57)
                    return false;
            }

            if (TTGioiTinh.Trim() != "Nam" && TTGioiTinh.Trim() != "Nữ" && TTGioiTinh.Trim() != "Khác")
                return false;

            if ((DateTime.Today.Year - TTNgaySinh.Year) < 3 || (DateTime.Today.Year - TTNgaySinh.Year) > 130)
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

    }
}
