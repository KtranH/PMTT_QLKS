﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WEB_APP_QLKSEntities : DbContext
    {
        public WEB_APP_QLKSEntities()
            : base("name=WEB_APP_QLKSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHITIETTRAPHONG> CHITIETTRAPHONGs { get; set; }
        public virtual DbSet<DANHGIA> DANHGIAs { get; set; }
        public virtual DbSet<DICHVU> DICHVUs { get; set; }
        public virtual DbSet<HINHLOAIPHONG> HINHLOAIPHONGs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAIPHONG> LOAIPHONGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUDATPHONG> PHIEUDATPHONGs { get; set; }
        public virtual DbSet<PHIEUNHANPHONG> PHIEUNHANPHONGs { get; set; }
        public virtual DbSet<PHIEUTRAPHONG> PHIEUTRAPHONGs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
