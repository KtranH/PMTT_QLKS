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
    
    public partial class job_batches
    {
        public string id { get; set; }
        public string name { get; set; }
        public int total_jobs { get; set; }
        public int pending_jobs { get; set; }
        public int failed_jobs { get; set; }
        public string failed_job_ids { get; set; }
        public string options { get; set; }
        public Nullable<int> cancelled_at { get; set; }
        public int created_at { get; set; }
        public Nullable<int> finished_at { get; set; }
    }
}