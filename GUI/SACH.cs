//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI
{
    using System;
    using System.Collections.Generic;
    
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            this.CHI_TIET_HOA_DON_BAN = new HashSet<CHI_TIET_HOA_DON_BAN>();
            this.CHI_TIET_HOA_DON_NHAP = new HashSet<CHI_TIET_HOA_DON_NHAP>();
        }
    
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public int GiaBan { get; set; }
        public int SoLuong { get; set; }
        public string MaNXB { get; set; }
        public string MaLoaiSach { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_HOA_DON_BAN> CHI_TIET_HOA_DON_BAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_HOA_DON_NHAP> CHI_TIET_HOA_DON_NHAP { get; set; }
        public virtual LOAI_SACH LOAI_SACH { get; set; }
        public virtual NHA_XUAT_BAN NHA_XUAT_BAN { get; set; }
    }
}
