﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyHangHoa
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QUANLYHANGHOAEntities : DbContext
    {
        public QUANLYHANGHOAEntities()
            : base("name=QUANLYHANGHOAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CHITIETNHAP> CHITIETNHAPs { get; set; }
        public DbSet<CHITIETXUAT> CHITIETXUATs { get; set; }
        public DbSet<CHUCVU> CHUCVUs { get; set; }
        public DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public DbSet<KHO> KHOes { get; set; }
        public DbSet<MATHANG> MATHANGs { get; set; }
        public DbSet<NHANVIEN> NHANVIENs { get; set; }
        public DbSet<NHAP> NHAPs { get; set; }
        public DbSet<NHASANXUAT> NHASANXUATs { get; set; }
        public DbSet<PHONGBAN> PHONGBANs { get; set; }
        public DbSet<XUAT> XUATs { get; set; }
    }
}
