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
    
    public partial class job
    {
        public long id { get; set; }
        public string queue { get; set; }
        public string payload { get; set; }
        public byte attempts { get; set; }
        public Nullable<int> reserved_at { get; set; }
        public int available_at { get; set; }
        public int created_at { get; set; }
    }
}
