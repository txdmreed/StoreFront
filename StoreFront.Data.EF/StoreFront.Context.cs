﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreFront.Data.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StoreFrontEntities : DbContext
    {
        public StoreFrontEntities()
            : base("name=StoreFrontEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<PriceIndex> PriceIndexes { get; set; }
        public virtual DbSet<ProductBoard> ProductBoards { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
    }
}
