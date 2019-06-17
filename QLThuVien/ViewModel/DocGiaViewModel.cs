using QLThuVien.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace QLThuVien.ViewModel
{
    public class DocGiaViewModel : BaseViewModel
    {

        public ICommand SettingCommand { get; set; }
        public ICommand SachCommand { get; set; }
        public ICommand DangXuatCommand { get; set; }
        public ICommand ThongTinDocGiaCommand { get; set; }
        public ICommand GioSachCommand { get; set; }
        public ICommand DangMuonCommand { get; set; }
        public ICommand DaTraCommand { get; set; }
        public ICommand STSetting { get; set; }
        public ICommand STHuy { get; set; }

        public ICommand LODangXuat { get; set; }
        public ICommand LOHuy { get; set; }

        public ICommand GSHuy { get; set; }
        public ICommand GSTienHanhMuon { get; set; }

        public ICommand KSTimKiem { get; set; }
        public ICommand KSThemVaoGio { get; set; }
        public ICommand DMTraSach { get; set; }
        private bool _SachGrid;
        private bool _TTDocGiaGrid;
        private bool _LogOutGrid;
        private bool _GioSachGrid;
        private bool _DangMuonGrid;
        private bool _DaTraGrid;
        private bool _SettingGrid;


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

        public bool GioSachGrid
        {
            get { return _GioSachGrid; }
            set
            {
                _GioSachGrid = value;
                OnPropertyChanged("GioSachGrid");
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



        private ObservableCollection<SACH> _SACHList;
        public ObservableCollection<SACH> SACHLIST
        {
            get => _SACHList;
            set { _SACHList = value; OnPropertyChanged(); }
        }

        //GIOSACHLIST
        private ObservableCollection<GIOHANG> _GIOSACHList;
        public ObservableCollection<GIOHANG> GIOSACHLIST
        {
            get => _GIOSACHList;
            set { _GIOSACHList = value; OnPropertyChanged(); }
        }

        private ObservableCollection<PHIEUSACH> _PHIEUSACHList;
        public ObservableCollection<PHIEUSACH> PHIEUSACHLIST
        {
            get => _PHIEUSACHList;
            set { _PHIEUSACHList = value; OnPropertyChanged(); }
        }

        //DANGMUONLIST
        private ObservableCollection<GIOHANG> _DANGMUONList;
        public ObservableCollection<GIOHANG> DANGMUONLIST
        {
            get => _DANGMUONList;
            set { _DANGMUONList = value; OnPropertyChanged(); }
        }
        //DATRALIST
        private ObservableCollection<DATRA> _DATRAList;
        public ObservableCollection<DATRA> DATRALIST
        {
            get => _DATRAList;
            set { _DATRAList = value; OnPropertyChanged(); }
        }

        //PHIEUGIAODICH
        private ObservableCollection<PHIEUGIAODICH> _PHIEUDDList;
        public ObservableCollection<PHIEUGIAODICH> PHIEUDDLIST
        {
            get => _PHIEUDDList;
            set { _PHIEUDDList = value; OnPropertyChanged(); }
        }

        private ObservableCollection<PHAT> _PHATList;
        public ObservableCollection<PHAT> PHATLIST
        {
            get => _PHATList;
            set { _PHATList = value; OnPropertyChanged(); }
        }

        private ObservableCollection<LOAISACH> _LOAISACHList;
        public ObservableCollection<LOAISACH> LOAISACHLIST
        {
            get => _LOAISACHList;
            set { _LOAISACHList = value; OnPropertyChanged(); }
        }

        private ObservableCollection<DOCGIA> _DOCGIAList;
        public ObservableCollection<DOCGIA> DOCGIAList
        {
            get => _DOCGIAList;
            set { _DOCGIAList = value; OnPropertyChanged(); }
        }

        private ObservableCollection<TAIKHOANDG> _TAIKHOANDGList;
        public ObservableCollection<TAIKHOANDG> TAIKHOANDGList
        {
            get => _TAIKHOANDGList;
            set { _TAIKHOANDGList = value; OnPropertyChanged(); }
        }


        private ObservableCollection<string> _LOAICBX;
        public ObservableCollection<string> LOAICBX { get => _LOAICBX;
            set
            {
                _LOAICBX = value;
                OnPropertyChanged();
              
            }
        }

        private ObservableCollection<string> _NAMSXCBX;
        public ObservableCollection<string> NAMSXCBX { get => _NAMSXCBX;
            set {
                _NAMSXCBX = value;
                OnPropertyChanged();
            } }

        private ObservableCollection<string> _TACGIACBX;
        public ObservableCollection<string> TACGIACBX {
            get => _TACGIACBX;
            set { _TACGIACBX = value;
                OnPropertyChanged();
               
            } }

       
        /*
        public ICommand TIMKIEM { get; set; }
        private string _TimKiem;
        public string TimKiem { get => _TimKiem; set { _TimKiem = value; OnPropertyChanged(); } }
        */
        private string _KSThongTinTimKiem;
        public string KSThongTinTimKiem { get => _KSThongTinTimKiem; set { _KSThongTinTimKiem = value; OnPropertyChanged(); } }


        private string passUserName;

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

        private string _TTMaDocGia;
        public string TTMaDocGia { get => _TTMaDocGia; set { _TTMaDocGia = value; OnPropertyChanged(); } }

        //DMMaPhieuMuon

        private string _DMMaPhieuMuon;
        public string DMMaPhieuMuon { get => _DMMaPhieuMuon; set { _DMMaPhieuMuon = value; OnPropertyChanged(); } }
        //DMNgayMuon
        private DateTime _DMNgayMuon;
        public DateTime DMNgayMuon { get => _DMNgayMuon; set { _DMNgayMuon = value; OnPropertyChanged(); } }


        private DateTime _DMNgayTraDuKien;
        public DateTime DMNgayTraDuKien { get => _DMNgayTraDuKien; set { _DMNgayTraDuKien = value; OnPropertyChanged(); } }


        bool SelectedGS = false;
        private GIOHANG _SelectedGioSach;
        public GIOHANG SelectedGioSach
        {
            get => _SelectedGioSach;
            set {

                _SelectedGioSach = value;
                OnPropertyChanged();
                if (SelectedGioSach != null)
                {
                    SelectedGS = true;
                }
            }
        }


        public bool SelectedKS = false;
        private SACH _SelectedKhoSach;
        public SACH SelectedKhoSach{
            get => _SelectedKhoSach;
            set {
                _SelectedKhoSach = value;
                OnPropertyChanged();
                if (SelectedKhoSach != null)  {
                    SelectedKS = true;
                }
            }
        }


        private string _KSChonLoaiSach;
        public string KSChonLoaiSach {
            get => _KSChonLoaiSach;
            set {
                _KSChonLoaiSach = value;
                OnPropertyChanged();
                if (_KSChonLoaiSach != null || _KSChonLoaiSach != "ALL") {
                    string maloai = "";
                  foreach(var item in LOAISACHLIST)
                    {
                        if (item.TENLOAISACH == _KSChonLoaiSach)
                            maloai = item.MALOAISACH;
                    }
                    SACHLIST = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes.Where(x => x.MALOAISACH == maloai));

                }
                if (_KSChonLoaiSach == "ALL"){
                    SACHLIST = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes);

                }
            }
        }


        private string _KSChonTacGia;
        public string KSChonTacGia  {
            get => _KSChonTacGia;
            set {
                _KSChonTacGia = value;
                OnPropertyChanged();

                if (_KSChonTacGia != null || _KSChonTacGia != "ALL")  {
                    SACHLIST = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes.Where(x => x.TACGIA == _KSChonTacGia));

                }
                if (_KSChonTacGia == "ALL") {
                    SACHLIST = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes);

                }
            }
        }

        private string _KSChonNamSX;
        public string KSChonNamSX
        {
            get => _KSChonNamSX;
            set {
                _KSChonNamSX = value;
                OnPropertyChanged();

                if (_KSChonNamSX != null || _KSChonNamSX != "ALL") {
                    SACHLIST = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes.Where(x => x.NAMSX.ToString() == _KSChonNamSX));

                }
                if (_KSChonNamSX == "ALL"){
                    SACHLIST = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes);

                }
            }
        }

        //SelectedDangMuon

        public DocGiaViewModel()
        {
            SelectedGS = false;
            SettingGrid = SachGrid = DangMuonGrid = DaTraGrid
                = TTDocGiaGrid = GioSachGrid = LogOutGrid = false;

            LODangXuat = new RelayCommand<Window>((p) => {
                return true;
            },
           (p) => {

               MainWindow main = new MainWindow();
               main.Show();
               p.Close();
           });

            STSetting = new RelayCommand<object>((p) => {
                return true;
            },
          (p) => {

              Setting();
          });

            SettingCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                SettingGrid = true;
                SachGrid = TTDocGiaGrid = LogOutGrid = GioSachGrid = DangMuonGrid = DaTraGrid = false;

            });

            SachCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                _SachGrid = true;
                SachGrid = true;
                SettingGrid = TTDocGiaGrid = LogOutGrid
                = GioSachGrid = DangMuonGrid = DaTraGrid = false;

            });

            DangXuatCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                LogOutGrid = true;
                SachGrid = TTDocGiaGrid = SettingGrid
                = GioSachGrid = DangMuonGrid = DaTraGrid = false;

            });

            ThongTinDocGiaCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                TTDocGiaGrid = true;
                SachGrid = SettingGrid = LogOutGrid
                = GioSachGrid = DangMuonGrid = DaTraGrid = false;

            });

            GioSachCommand = new RelayCommand<object>((p) => { return true; }, (p) => {

                GioSachGrid = true;
                SachGrid = TTDocGiaGrid = LogOutGrid
                = SettingGrid = DangMuonGrid = DaTraGrid = false;

            });
            DangMuonCommand = new RelayCommand<object>((p) => { return true; }, (p) => {

                DangMuonGrid = true;
                SachGrid = TTDocGiaGrid = LogOutGrid
                = GioSachGrid = SettingGrid = DaTraGrid = false;


                var phieu = DataProvider.Ins.DB.PHIEUGIAODICHes.Where(x => x.MADG == TTMaDocGia && x.NGAYTRA > DateTime.Today).SingleOrDefault();
                if (phieu != null)
                {
                    foreach (var item in PHIEUSACHLIST)
                    {
                        if (item.MAPHIEU == phieu.MAPHIEU)
                        {
                            var sach_phieu = DataProvider.Ins.DB.SACHes.Where(x => x.MASACH == item.MASACH).SingleOrDefault();
                            GIOHANG temp = new GIOHANG(sach_phieu, (int)item.SOLUONG);
                            DANGMUONLIST.Add(temp);

                        }
                    }
                    DMMaPhieuMuon = phieu.MAPHIEU;
                    DMNgayMuon = (DateTime)phieu.NGAYMUON;
                    DMNgayTraDuKien = (DateTime)phieu.NGAYTRA;
                }

              

            });
            DaTraCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                DaTraGrid = true;
                SachGrid = TTDocGiaGrid = LogOutGrid
                = GioSachGrid = DangMuonGrid = SettingGrid = false;
                LoadLichSuMuonSach();
            });


            STHuy = new RelayCommand<object>((p) => { return true; }, (p) => {
                LoadTTDocGia();
            });

            LOHuy = new RelayCommand<object>((p) => { return true; }, (p) => {
                LogOutGrid = false;
            });


            SACHLIST = new ObservableCollection<SACH>(DataProvider.Ins.DB.SACHes);
            LOAISACHLIST = new ObservableCollection<LOAISACH>(DataProvider.Ins.DB.LOAISACHes);
            DOCGIAList = new ObservableCollection<DOCGIA>(DataProvider.Ins.DB.DOCGIAs);
            TAIKHOANDGList = new ObservableCollection<TAIKHOANDG>(DataProvider.Ins.DB.TAIKHOANDGs);
            PHIEUDDLIST = new ObservableCollection<PHIEUGIAODICH>(DataProvider.Ins.DB.PHIEUGIAODICHes);
            PHATLIST = new ObservableCollection<PHAT>(DataProvider.Ins.DB.PHATs);
            PHIEUSACHLIST = new ObservableCollection<PHIEUSACH>(DataProvider.Ins.DB.PHIEUSACHes);
            GIOSACHLIST = new ObservableCollection<GIOHANG>();
            DANGMUONLIST = new ObservableCollection<GIOHANG>();
            DATRALIST = new ObservableCollection<DATRA>();

         

            LOAICBX = new ObservableCollection<string>();
            NAMSXCBX = new ObservableCollection<string>();
            TACGIACBX = new ObservableCollection<string>();

            LOAICBX.Add("ALL");
            foreach (var item in LOAISACHLIST) {
                LOAICBX.Add(item.TENLOAISACH);
            }

            string temp_nam = "";
            string temp_tg = "";

            TACGIACBX.Add("ALL");
            NAMSXCBX.Add("ALL");

            foreach (var item in SACHLIST) {
                if (item.TACGIA != temp_tg)
                    TACGIACBX.Add(item.TACGIA);
                if (item.NAMSX.ToString() != temp_nam)
                    NAMSXCBX.Add(item.NAMSX.ToString());

                temp_nam = item.NAMSX.ToString();
                temp_tg = item.TACGIA;

            }




            GSHuy = new RelayCommand<object>((p) => {
                if (GIOSACHLIST.Count == 0)
                    return false;
                if (SelectedGS)
                    return true;
                return false;

            },
            (p) =>
            {
                if (SelectedGioSach.SOLUONG == 1)
                    GIOSACHLIST.Remove(SelectedGioSach);
                else
                    SelectedGioSach.SOLUONG--;
            });

            GSTienHanhMuon = new RelayCommand<object>((p) => {
                if (GIOSACHLIST.Count > 0)
                    return true;
                return false;
            },
            (p) => {
                bool muon = true;
                foreach (var temp in PHATLIST) {
                    if (temp.MADG == TTMaDocGia) {
                        MessageBox.Show("Bạn hiện đang vi phạm nội quy của thư viện nên hiện không thể mượn sách");
                        muon = false;
                        break;
                    }
                }

                if (muon) {
                    foreach (var temp in PHIEUDDLIST) {
                        if (temp.MADG == TTMaDocGia && temp.NGAYTRA > DateTime.Today) {

                            MessageBox.Show("Bạn chưa thể mượn thêm sách khi chưa trả sách đã mượn");
                            muon = false;
                            break;
                        }

                    }
                }

                if (muon) {
                    int numOfPDD = DataProvider.Ins.DB.PHIEUGIAODICHes.Count();
                    string maPhieuDD = KhoiTaoMaPhieuGiaoDich(numOfPDD + 1);
                    var muonSach = new PHIEUGIAODICH() {
                        MAPHIEU = maPhieuDD,
                        MADG = TTMaDocGia,
                        LOAIPHIEU = "Mượn",
                        NGAYMUON = DateTime.Today,
                        NGAYTRA = DateTime.Today.AddDays(15),
                        PHIPHATSINH = 0,
                    };

                    DataProvider.Ins.DB.PHIEUGIAODICHes.Add(muonSach);
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Mượn sách thành công");

                    foreach (var item in GIOSACHLIST)
                    {
                        var GSSach = new PHIEUSACH()
                        {
                            MAPHIEU = maPhieuDD,
                            MASACH = item.MASACH,
                            SOLUONG = item.SOLUONG,
                        };
                        PHIEUSACHLIST.Add(GSSach);
                        DataProvider.Ins.DB.PHIEUSACHes.Add(GSSach);
                        DataProvider.Ins.DB.SaveChanges();
                    }

                    GIOSACHLIST = new ObservableCollection<GIOHANG>();
                }

            });

            int num = 0;
            KSThemVaoGio = new RelayCommand<object>((p) => {
                if (SelectedKS) {
                    return true;
                }
                return false;
            },
             (p) => {
                 var sach = DataProvider.Ins.DB.SACHes.Where(x => x.MASACH == SelectedKhoSach.MASACH).SingleOrDefault();

                 if (num >= 5) {
                     MessageBox.Show("Số lượng sách tối đa trong một lần mượn là 5 ");
                 }

                 else {
                     if (GIOSACHLIST.Count == 0)
                     {
                         var temp = new GIOHANG(sach.MASACH, sach.TENSACH, sach.MALOAISACH, sach.TACGIA, (int)sach.NAMSX,
                                                              (decimal)sach.GIASACH, 1);
                         GIOSACHLIST.Add(temp);
                         num++;
                     }
                     else
                     {
                         bool dathem = false;
                         foreach (var item in GIOSACHLIST)
                         {
                             if (item.MASACH == SelectedKhoSach.MASACH)
                             {
                                 item.SOLUONG++;
                                 num++;
                                 dathem = true;
                             }

                         }
                         if (!dathem)
                         {
                             var temp = new GIOHANG(sach.MASACH, sach.TENSACH, sach.MALOAISACH, sach.TACGIA, (int)sach.NAMSX,
                                                               (decimal)sach.GIASACH, 1);
                             GIOSACHLIST.Add(temp);
                             num++;
                         }


                     }




                 }
             }
             );

            DMTraSach = new RelayCommand<object>((p) => {return true; },
            (p)=>{
                var phieudd = DataProvider.Ins.DB.PHIEUGIAODICHes.Where(x => x.MAPHIEU == DMMaPhieuMuon).SingleOrDefault();
                phieudd.NGAYTRA = DateTime.Today;
                DataProvider.Ins.DB.SaveChanges();
                
                DANGMUONLIST = new ObservableCollection<GIOHANG>();
                LoadLichSuMuonSach();

                DMMaPhieuMuon = "";
                DMNgayMuon = DMNgayTraDuKien = DateTime.Today;


            }
            );
        }

        public DocGiaViewModel(string passUserName) : this()
        {
            this.passUserName = passUserName;

            LoadTTDocGia();

        }

        
        void LoadTTDocGia()
        {
            string temp = "";
            foreach( var temp1 in TAIKHOANDGList)
            {
                if (temp1.TENTK == passUserName)
                {
                    temp = temp1.MADG;
                    break;
                }
            }

            if(temp != "")
            {
                foreach(var temp1 in DOCGIAList)
                {
                    if(temp1.MADG == temp)
                    {
                        TTMaDocGia = temp1.MADG;
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

        void Setting() {
            if (checkDataSetting()) {
                var temp = DataProvider.Ins.DB.DOCGIAs.Where(x => x.MADG == TTMaDocGia).SingleOrDefault();

                temp.TEN = TTHoTen;
                temp.SODT = TTSoDT;
                temp.GIOITINH = TTGioiTinh;
                temp.DIACHI = TTDiaChi;
                temp.NGAYSINH = TTNgaySinh;
                DataProvider.Ins.DB.SaveChanges();

                MessageBox.Show("Lưu thành công");
            }
            else {
                MessageBox.Show("Thông tin nhập vào không hợp lệ");
            }
            
        }
        
        bool checkDataSetting() {
            foreach(var c in TTSoDT.Trim()) {
                if (c < 48 || c > 57)
                    return false;
            }

            foreach (var c in TTCMND.Trim()){
                if (c < 48 || c > 57)
                    return false;
            }

            if (TTGioiTinh.Trim() != "Nam" && TTGioiTinh.Trim() != "Nữ" && TTGioiTinh.Trim() != "Khác")
                return false;

            if ((DateTime.Today.Year - TTNgaySinh.Year) < 3 || (DateTime.Today.Year - TTNgaySinh.Year) > 130)
                return false;

            return true;
        }



         string KhoiTaoMaPhieuGiaoDich(int num) {
            string ma = "";
          
                if (num < 10) {
                    ma = "MAPHIEU00" + num.ToString();
                }
                else if (num < 100 ) {
                    ma = "MAPHIEU0" + num.ToString();
                }
                else ma = "MAPHIEU " + num.ToString();

           
            return ma;
        }


        void LoadLichSuMuonSach() {

            DATRALIST = new ObservableCollection<DATRA>();
            
          foreach(var item in PHIEUDDLIST) {
                if(item.MADG == TTMaDocGia)  {
                    foreach (var item1 in PHIEUSACHLIST) {
                        if (item1.MAPHIEU == item.MAPHIEU){
                            var sachtra = DataProvider.Ins.DB.SACHes.Where(x => x.MASACH == item1.MASACH).SingleOrDefault();
                            if (sachtra != null){
                                var datra = new GIOHANG(sachtra, (int)item1.SOLUONG);
                                DATRALIST.Add(new DATRA(datra, item.MAPHIEU));
                            }
                        }
                    }
                }
            }
        }

        bool CheckLichSuMuon(string maphieu, string masach)
        {
            
            return true;
        }
    }
}



