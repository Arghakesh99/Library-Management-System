﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_Management_System.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class lmsProjectEntities : DbContext
    {
        public lmsProjectEntities()
            : base("name=lmsProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblBook> tblBook { get; set; }
        public virtual DbSet<tblBorrowHistory> tblBorrowHistory { get; set; }
        public virtual DbSet<tblCustomer> tblCustomer { get; set; }
    }
}
