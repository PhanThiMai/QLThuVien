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
    
    public partial class PHIEUSACH
    {
        public string MAPHIEU { get; set; }
        public string MASACH { get; set; }
        public Nullable<int> SOLUONG { get; set; }
    
        public virtual PHIEUGIAODICH PHIEUGIAODICH { get; set; }
        public virtual SACH SACH { get; set; }
    }
}
