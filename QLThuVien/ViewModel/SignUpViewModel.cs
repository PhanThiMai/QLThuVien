using System;
using System.Collections.Generic;
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
        /*
         DocGiaRadioButton
        ThuThuRadioButton
        KiemToanRadioButton
         NuRadioButton
        GioiTinhKhacRadioButton
        NamRadioButton
        HienThiMatKhau

        HoTen
        UserName
        MatKhau
        
        SoDienThoai
        CMND
        DiaChi
        SignUpCommand
             */

        public ICommand DocGiaRadioButton { get;
            set; }

        public ICommand ThuThuRadioButton
        {
            get;
            set;
        }
        public ICommand KeToanRadioButton
        {
            get;
            set;
        }

        public ICommand NamRadioButton
        {
            get;
            set;
        }
        public ICommand NuRadioButton
        {
            get;
            set;
        }
        public ICommand GioiTinhKhacRadioButton
        {
            get;
            set;
        }

        public ICommand HienThiMatKhau
        {
            get;
            set;
        }

        private string _HoTen;
        public string HoTen { get => _HoTen;
            set { _HoTen = value;
                OnPropertyChanged(); } }

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

        public ICommand SignUpCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }


        public SignUpViewModel()
        {
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

        }

        /*
           DocGiaRadioButton
        ThuThuRadioButton
        KiemToanRadioButton
         NuRadioButton
        GioiTinhKhacRadioButton
        NamRadioButton
        HienThiMatKhau
        PasswordChangedCommand
                SignUpCommand

         */

        void DocGia()
        {

        }
        void ThuThu()
        {

        }

        void KeToan()
        {

        }

        void Nam()
        {

        }
        void Nu()
        {

        }

        void GioiTinhKhac()
        {

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


    }
}
