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
    
    public partial class ChiTietDichVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChiTietDichVu()
        {
            this.ChiTietSuDungDichVus = new HashSet<ChiTietSuDungDichVu>();
        }
    
        public string MaChiTietDichVu { get; set; }
        public string MaDichVu { get; set; }
        public string MaPhongTro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSuDungDichVu> ChiTietSuDungDichVus { get; set; }
        public virtual DichVu DichVu { get; set; }
        public virtual PhongTro PhongTro { get; set; }
    }
}
