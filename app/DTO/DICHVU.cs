//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class DICHVU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICHVU()
        {
            this.CHITIETTRAPHONGs = new HashSet<CHITIETTRAPHONG>();
        }
    
        public int ID { get; set; }
        public string TENDICHVU { get; set; }
        public Nullable<decimal> GIA { get; set; }
        public string MOTA { get; set; }
        public string HINH { get; set; }
        public Nullable<bool> ISDELETED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETTRAPHONG> CHITIETTRAPHONGs { get; set; }
    }
}
