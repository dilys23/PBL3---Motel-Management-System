//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3___Motel_Management_System.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThietBi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThietBi()
        {
            this.ChiTietThietBi = new HashSet<ChiTietThietBi>();
        }
    
        public int MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public double GiaThietBi { get; set; }
        public Nullable<bool> TonTai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietThietBi> ChiTietThietBi { get; set; }
    }
}
