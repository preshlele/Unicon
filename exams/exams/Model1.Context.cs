﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace exams
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UnicomEntities : DbContext
    {
        public UnicomEntities()
            : base("name=UnicomEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Priority> Priorities { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
