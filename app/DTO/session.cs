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
    
    public partial class session
    {
        public string id { get; set; }
        public Nullable<long> user_id { get; set; }
        public string ip_address { get; set; }
        public string user_agent { get; set; }
        public string payload { get; set; }
        public int last_activity { get; set; }
    }
}