using QLThuVien.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            get { return _DaTraGrid; }
            set
            {
                _SachThanhLyGrid = value;
                OnPropertyChanged("SachThanhLyGrid");
            }
        }

        public bool SachDaHuyGrid
        {
            get { return _DaTraGrid; }
            set
            {
                _SachDaHuyGrid = value;
                OnPropertyChanged("SachDaHuyGrid");
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

        private ObservableCollection<string> _LOAICBX;
        public ObservableCollection<string> LOAICBX
        {
            get => _LOAICBX;
            set
            {
                _LOAICBX = value;
                OnPropertyChanged();
                LoadLoaiSach(_LOAICBX.ToString());
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
                LoadNam(_NAMSXCBX.ToString());
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
                LoadTacGia(_TACGIACBX.ToString());
            }
        }

        private ObservableCollection<string> _TENDOCGIA;
        public ObservableCollection<string> TENDOCGIA
        {
            get => _TENDOCGIA;
            set
            {
                _TENDOCGIA = value;
                OnPropertyChanged();
                LoadTacGia(_TENDOCGIA.ToString());
            }
        }


        public ICommand TIMKIEM { get; set; }
        private string _TimKiem;
        public string TimKiem { get => _TimKiem; set { _TimKiem = value; OnPropertyChanged(); } }


        public NhanVienViewModel()
        {
            SettingGrid = SachGrid = DangMuonGrid = DaTraGrid
                = TTDocGiaGrid = NhapSachGrid = LogOutGrid =SachDaHuyGrid=SachThanhLyGrid=ViPhamGrid=DocGiaGrid= false;


            SettingCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                SettingGrid = true;

                SachGrid =ViPhamGrid=DocGiaGrid=SachDaHuyGrid=SachThanhLyGrid= TTDocGiaGrid = LogOutGrid = NhapSachGrid = DangMuonGrid = DaTraGrid = false;

            });
            SachCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                _SachGrid = true;
                SachGrid = true;
                SettingGrid = TTDocGiaGrid =SachThanhLyGrid=SachDaHuyGrid=DocGiaGrid=ViPhamGrid= LogOutGrid = NhapSachGrid = DangMuonGrid = DaTraGrid = false;

            });
            DangXuatCommand = new RelayCommand<object>((p) => { return true; }, (p) => {

                LogOutGrid = true;
                SachGrid = TTDocGiaGrid =SachThanhLyGrid=SachDaHuyGrid=DocGiaGrid=ViPhamGrid= SettingGrid = NhapSachGrid = DangMuonGrid = DaTraGrid = false;

            });
            ThongTinDocGiaCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                TTDocGiaGrid = true;
                SachGrid = SettingGrid = SachThanhLyGrid = SachDaHuyGrid = DocGiaGrid = ViPhamGrid = LogOutGrid = NhapSachGrid = DangMuonGrid = DaTraGrid = false;

            });

            SachThanhLyCommand = new RelayCommand<object>((p) => { return true; }, (p) => {

                NhapSachGrid = true;
                SachGrid = TTDocGiaGrid = SachDaHuyGrid = DocGiaGrid = ViPhamGrid= LogOutGrid = SettingGrid = DangMuonGrid = DaTraGrid = false;

            });
            DangMuonCommand = new RelayCommand<object>((p) => { return true; }, (p) => {

                DangMuonGrid = true;
                SachGrid = TTDocGiaGrid = SachThanhLyGrid = SachDaHuyGrid = DocGiaGrid = ViPhamGrid = LogOutGrid = NhapSachGrid = SettingGrid = DaTraGrid = false;

            });
            DaTraCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                DaTraGrid = true;
                SachGrid = TTDocGiaGrid = SachThanhLyGrid = SachDaHuyGrid = DocGiaGrid = ViPhamGrid = LogOutGrid = NhapSachGrid = DangMuonGrid = SettingGrid = false;

            });

            SachDaHuyCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                SachDaHuyGrid = true;
                SachGrid = TTDocGiaGrid = SachThanhLyGrid = DaTraGrid = DocGiaGrid = ViPhamGrid = LogOutGrid = NhapSachGrid = DangMuonGrid = SettingGrid = false;

            });

            DanhSachDocGiaCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                DocGiaGrid = true;
                SachGrid = TTDocGiaGrid = SachThanhLyGrid = SachDaHuyGrid = DaTraGrid = ViPhamGrid = LogOutGrid = NhapSachGrid = DangMuonGrid = SettingGrid = false;

            });

            DocGiaViPhamCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                ViPhamGrid = true;
                SachGrid = TTDocGiaGrid = SachThanhLyGrid = SachDaHuyGrid = DocGiaGrid = DaTraGrid = LogOutGrid = NhapSachGrid = DangMuonGrid = SettingGrid = false;

            });

            NhapSachCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                NhapSachGrid = true;
                SachGrid = TTDocGiaGrid = SachThanhLyGrid = SachDaHuyGrid = DocGiaGrid = DaTraGrid = LogOutGrid = DaTraGrid = DangMuonGrid = SettingGrid = false;

            });


            SACHLIST = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes);
            LOAISACHLIST = new ObservableCollection<LOAISACH>(DataProvider.Ins.DB.LOAISACHes);

            LOAICBX = new ObservableCollection<string>();
            NAMSXCBX = new ObservableCollection<string>();
            TACGIACBX = new ObservableCollection<string>();


            foreach (var item in LOAISACHLIST)
            {
                LOAICBX.Add(item.TENLOAISACH);
            }

            string temp_nam = "";
            string temp_tg = "";
            foreach (var item in SACHLIST)
            {
                if (item.TACGIA != temp_tg)
                    TACGIACBX.Add(item.TACGIA);
                if (item.NAMSX.ToString() != temp_nam)
                    NAMSXCBX.Add(item.NAMSX.ToString());

                temp_nam = item.NAMSX.ToString();
                temp_tg = item.TACGIA;

            }


            TIMKIEM = new RelayCommand<object>((p) =>
            {
                return true;

            }, (p) =>
            {
                TimKiem = "";
            });

        }


        public void LoadData()
        {

        }
        public void LoadLoaiSach(string loai)
        {

            SACHLIST = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes);
            LOAISACHLIST = new ObservableCollection<LOAISACH>(DataProvider.Ins.DB.LOAISACHes);
            foreach (var item in LOAISACHLIST)
            {
                if (item.TENLOAISACH == loai)
                {
                    SACHLIST = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes.Where(x => x.MALOAISACH == item.MALOAISACH));

                }
            }

        }
        public void LoadTacGia(string tacgia)
        {

        }
        public void LoadNam(string nam)
        {

        }
    }
}
