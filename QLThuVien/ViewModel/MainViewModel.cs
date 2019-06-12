using QLThuVien.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QLThuVien.ViewModel
{
   public  class MainViewModel : BaseViewModel
    {
        

        public bool isLogin { get; set; }
        public bool isShowPass { get; set; }


        private string _UserName;
        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }

        private string _Password;
      //  private object FloatingPasswordBox;

        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }

        public ICommand LoginCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }

        public ICommand SignUp { get; set; }
        public ICommand HienThiMatKhau { get; set; }



        public MainViewModel()
        {
           
            isLogin = false;
            Password = "";
            UserName = "";
            isShowPass = false;


            LoginCommand = new RelayCommand<Window>((p) => {
                return true;
            },
            (p) => { Login(p);
            });

            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => {
                Password = p.Password; });


            HienThiMatKhau = new RelayCommand<Window>(
                (p) => 
            { return true;
            },(p) => {
                if (!isShowPass)
                {
                   
                  
                    isShowPass = true;
                }
                else
                {
                    isShowPass = false;
                }
              
            });


            SignUp = new RelayCommand<Window>((p) => {
                return true;
            },
              (p) => {
                  SignUp dangki = new SignUp();
                  dangki.ShowDialog();
              });

        }

        
        void Login(Window p)
        {
            if (p == null)
                return;
         
            string passEncode = MD5Hash(Base64Encode(Password));
        
            var accCountDG = DataProvider.Ins.DB.TAIKHOANDGs.Where(x => x.TENTK == UserName && x.ENCODE == passEncode).Count();
            var accCountNV = DataProvider.Ins.DB.TAIKHOANNVs.Where(x => x.TENTK == UserName && x.ENCODE == passEncode).Count();

            
            if (accCountDG > 0)
            {
                isLogin = true;
                DocGia docgia = new DocGia();
                docgia.DataContext = new DocGiaViewModel(UserName);
                docgia.Show();
                p.Close();
                
            }
            else if(accCountNV > 0)
            {
                isLogin = true;
                NhanVien nhanvien = new NhanVien();
                nhanvien.DataContext = new NhanVienViewModel(UserName);
                
                p.Close();
                nhanvien.Show();
            }
            else
            {
                isLogin = false;
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
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

       

    }
}

