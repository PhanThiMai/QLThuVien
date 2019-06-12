using QLThuVien.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Validation;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QLThuVien.ViewModel
{
    public class SignUpViewModel : BaseViewModel
    {

        public ICommand HienThiMatKhau
        {
            get;
            set;
        }

        private string _HoTen = "";
        public string HoTen { get => _HoTen;
            set { _HoTen = value;
                OnPropertyChanged(); } }

        //ErrorHoTen
        private bool _ErrorHoTen;
        public bool ErrorHoTen
        {
            get => _ErrorHoTen;
            set
            {
                _ErrorHoTen = value;
                OnPropertyChanged();
            }
        }
       

        private string _UserName;
        public string UserName
        {
            get => _UserName;
            set
            {
                _UserName = value;
                OnPropertyChanged();
            }
        }

        private string _MatKhau;
        public string MatKhau
        {
            get => _MatKhau;
            set
            {
                _MatKhau = value;
                OnPropertyChanged();
            }
        }

        private string _SoDienThoai;
        public string SoDienThoai
        {
            get => _SoDienThoai;
            set
            {
                _SoDienThoai = value;
                OnPropertyChanged();
            }
        }

        private string _CMND;
        public string CMND
        {
            get => _CMND;
            set
            {
                _CMND = value;
                OnPropertyChanged();
            }
        }

        private string _DiaChi;
        public string DiaChi
        {
            get => _DiaChi;
            set
            {
                _DiaChi = value;
                OnPropertyChanged();
            }
        }



        private string _ChonGioiTinh;
        public string ChonGioiTinh
        {
            get => _ChonGioiTinh;
            set
            {
                _ChonGioiTinh = value;
                OnPropertyChanged();
            }
        }

        private DateTime _NgaySinh;
        public DateTime NgaySinh { get => _NgaySinh; set { _NgaySinh = value; OnPropertyChanged(); } }


        private string _TypeOfAccount;
        public string TypeOfAccount
        {
            get => _TypeOfAccount;
            set
            {
                _TypeOfAccount = value;
                OnPropertyChanged();
            }
        }

        public ICommand SignUpCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }



        public SignUpViewModel()
        {
            MatKhau = UserName = HoTen = DiaChi = CMND =ChonGioiTinh= TypeOfAccount= SoDienThoai="";
            NgaySinh = new DateTime(1980, 1, 1);
            ErrorHoTen = false;
            SignUpCommand = new RelayCommand<Window>((p) => {
                return true;
            },
           (p) => {

               SignUp(p);
           });

            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => {
                MatKhau = p.Password;
            });

        }

        void SignUp(Window p)
        {
            string passEncode = MD5Hash(Base64Encode(MatKhau));
           
            if(HoTen == "" || HoTen.StartsWith("@@@"))
            {
                ErrorHoTen = true;
            }

            if (ChonGioiTinh == "" )
            {
                MessageBox.Show("Bạn chưa chọn giới tính");

            }


            if (UserName == "" || UserName.StartsWith("@@@"))
            {
                MessageBox.Show("Username không hợp lệ ");

            }

            if (passEncode == "" )
            {
                MessageBox.Show("Mật khẩu không hợp lệ ");

            }

            if (SoDienThoai == "" )
            {
                MessageBox.Show("Số điện thoại không hợp lệ ");

            }

            if (CMND == "" ) {
                MessageBox.Show("CMND không hợp lệ ");

            }

            if (DiaChi == "" || UserName.StartsWith("@@@")){
                MessageBox.Show("Địa chỉ không hợp lệ ");

            }

            else
            {
                if(TypeOfAccount == "DocGia") {
                    string maDocGia = "";
                    int numDocGia = DataProvider.Ins.DB.DOCGIAs.Count();
                    maDocGia = KhoiTaoMa("DG", numDocGia + 1);

                    try {
                        var DG = new DOCGIA() {
                            MADG = maDocGia,
                            TEN = HoTen,
                            GIOITINH = ChonGioiTinh,
                            CMND = CMND,
                            DIACHI = DiaChi,
                            SODT = SoDienThoai,
                            NGAYSINH = NgaySinh

                        };

                        DataProvider.Ins.DB.DOCGIAs.Add(DG);
                        DataProvider.Ins.DB.SaveChanges();


                    }
                    catch (DbEntityValidationException e) {
                        foreach (var eve in e.EntityValidationErrors){
                            Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                eve.Entry.Entity.GetType().Name, eve.Entry.State);
                            foreach (var ve in eve.ValidationErrors) {
                                Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                    ve.PropertyName, ve.ErrorMessage);
                            }
                        }
                        throw e;
                    }


                    try {
                        var tk = new TAIKHOANDG() {
                            TENTK = UserName,
                            MADG = maDocGia,
                            MATKHAU = MatKhau,
                            ENCODE = passEncode
                        };

                        DataProvider.Ins.DB.TAIKHOANDGs.Add(tk);
                        DataProvider.Ins.DB.SaveChanges();


                    }
                    catch (DbEntityValidationException e) {
                        foreach (var eve in e.EntityValidationErrors){
                            Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                eve.Entry.Entity.GetType().Name, eve.Entry.State);
                            foreach (var ve in eve.ValidationErrors)  {
                                Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                    ve.PropertyName, ve.ErrorMessage);
                            }
                        }
                        throw e;
                    }
                  
                

                }
                else if(TypeOfAccount == "NhanVien") {
                    string maNhanVien = "";
                    int numNhanVien = DataProvider.Ins.DB.NHANVIENs.Count();
                    maNhanVien = KhoiTaoMa("NV", numNhanVien + 1);

                    var NV = new NHANVIEN()  {
                        MANV = maNhanVien,
                        TEN = HoTen,
                        GIOITINH = ChonGioiTinh,
                        CMND = CMND,
                        DIACHI = DiaChi,
                        SODT = SoDienThoai,
                        NGAYSINH = NgaySinh

                    };

                    DataProvider.Ins.DB.NHANVIENs.Add(NV);
                    DataProvider.Ins.DB.SaveChanges();

                    var tk = new TAIKHOANNV() {
                        TENTK = UserName,
                        MANV = maNhanVien,
                        MATKHAU = MatKhau,
                        ENCODE = passEncode
                    };

                    DataProvider.Ins.DB.TAIKHOANNVs.Add(tk);
                    DataProvider.Ins.DB.SaveChanges();

                   
                 
                }
                else
                {

                }

                MainWindow main = new MainWindow();
                main.Show();
                p.Close();
            }


        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

      public static string KhoiTaoMa(string loai, int num)
        {
            string ma = "";
            if (loai == "DG")
            {
                if (num < 10)
                {
                    ma = "DG000" + num.ToString();
                }
                else if (num < 100)
                {
                    ma = "DG00" + num.ToString();
                }
                else if (num < 1000)
                    ma = "DG0" + num.ToString();
                else ma = "DG " + num.ToString();
            }
            else
            {

                if (num < 10)
                {
                    ma = "NV00" + num.ToString();
                }
                else if (num < 100)
                {
                    ma = "NV0" + num.ToString();
                }
              
                else ma = "NV " + num.ToString();

            }
            
            return ma;
        }


    }
}
