﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoosterCRM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DatabaseEntities : DbContext
    {
        internal readonly object ObjectStateManager;

        public DatabaseEntities()
            : base("name=DatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<contact> contacts { get; set; }
        public virtual DbSet<@event> events { get; set; }
        public virtual DbSet<lead> leads { get; set; }
        public virtual DbSet<task> tasks { get; set; }
        public virtual DbSet<company> companies { get; set; }
    
        public virtual int LeadStatusPRocedure()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LeadStatusPRocedure");
        }
    }
}