
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
    
public partial class PHONG
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public PHONG()
    {

        this.PHIEUNHANPHONGs = new HashSet<PHIEUNHANPHONG>();

    }


    public int ID { get; set; }

    public string TENPHONG { get; set; }

    public string VITRI { get; set; }

    public Nullable<int> LOAIPHONG_ID { get; set; }

    public string TRANGTHAI { get; set; }



    public virtual LOAIPHONG LOAIPHONG { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<PHIEUNHANPHONG> PHIEUNHANPHONGs { get; set; }

}

}
