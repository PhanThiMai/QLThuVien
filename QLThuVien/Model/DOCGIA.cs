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
    
    public partial class DOCGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOCGIA()
        {
            this.PHIEUGIAODICHes = new HashSet<PHIEUGIAODICH>();
            this.TAIKHOANDGs = new HashSet<TAIKHOANDG>();
        }
    
        public string MADG { get; set; }
        public string TEN { get; set; }
        public string GIOITINH { get; set; }
        public string CMND { get; set; }
        public string DIACHI { get; set; }
        public string SODT { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
    
        public virtual PHAT PHAT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUGIAODICH> PHIEUGIAODICHes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAIKHOANDG> TAIKHOANDGs { get; set; }
    }
}
