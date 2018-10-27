﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlasticsFactory.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PlasticFactoryEntities : DbContext
    {
        public PlasticFactoryEntities()
            : base("name=PlasticFactoryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<PaymentInput> PaymentInputs { get; set; }
        public virtual DbSet<PaymentOutput> PaymentOutputs { get; set; }
        public virtual DbSet<ProductInput> ProductInputs { get; set; }
        public virtual DbSet<ProductIP> ProductIPs { get; set; }
        public virtual DbSet<ProductOP> ProductOPs { get; set; }
        public virtual DbSet<ProductOutput> ProductOutputs { get; set; }
        public virtual DbSet<Timekeeping> Timekeepings { get; set; }
        public virtual DbSet<TypeofCustomer> TypeofCustomers { get; set; }
        public virtual DbSet<TypeWeight> TypeWeights { get; set; }
        public virtual DbSet<Truck> Trucks { get; set; }
    
        public virtual ObjectResult<string> AutoIdEmployee()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("AutoIdEmployee");
        }
    }
}