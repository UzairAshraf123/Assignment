﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class hrplink_dbEntities : DbContext
    {
        public hrplink_dbEntities()
            : base("name=hrplink_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<OrgCountry> OrgCountries { get; set; }
        public virtual DbSet<OrgDataAccess> OrgDataAccesses { get; set; }
        public virtual DbSet<OrgGender> OrgGenders { get; set; }
        public virtual DbSet<OrgProvince> OrgProvinces { get; set; }
        public virtual DbSet<SysCustomField> SysCustomFields { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<PermissionDetail> PermissionDetails { get; set; }
        public virtual DbSet<PermissionHeader> PermissionHeaders { get; set; }
        public virtual DbSet<SystemCustomField> SystemCustomFields { get; set; }
        public virtual DbSet<TableDataAccess> TableDataAccesses { get; set; }
        public virtual DbSet<UserElementPermission> UserElementPermissions { get; set; }
        public virtual DbSet<UserPermission> UserPermissions { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}
