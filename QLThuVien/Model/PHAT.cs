//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLThuVien.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHAT
    {
        public string MADG { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public string GHICHU { get; set; }
    
        public virtual DOCGIA DOCGIA { get; set; }
    }
}
