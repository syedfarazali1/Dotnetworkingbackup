﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace spcrud.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Syed_companyEntities : DbContext
    {
        public Syed_companyEntities()
            : base("name=Syed_companyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<salary> salaries { get; set; }
        public virtual DbSet<staff> staffs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual ObjectResult<SelectAllCustomers_Result> SelectAllCustomers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectAllCustomers_Result>("SelectAllCustomers");
        }
    
        public virtual ObjectResult<staff> selectallcustomer()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<staff>("selectallcustomer");
        }
    
        public virtual ObjectResult<staff> selectallcustomer(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<staff>("selectallcustomer", mergeOption);
        }
    }
}