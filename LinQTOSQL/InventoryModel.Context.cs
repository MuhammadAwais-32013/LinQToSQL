﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinQTOSQL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class InventoryDB : DbContext
    {
        public InventoryDB()
            : base("name=InventoryDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeUser> EmployeeUsers { get; set; }
        public DbSet<EmployeeUser1> EmployeeUsers1 { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}