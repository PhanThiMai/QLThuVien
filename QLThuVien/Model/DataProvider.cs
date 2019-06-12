using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Model
{
    public class DataProvider
    {
        //singelton
        private static DataProvider _ins;
        public static DataProvider Ins { get { if (_ins == null) _ins = new DataProvider(); return _ins; } set { _ins = value; } }
        public quanlythuvienEntities1 DB { get; set; }

        private DataProvider()
        {
            DB = new quanlythuvienEntities1();
        }
    }
}
