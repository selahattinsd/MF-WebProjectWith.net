﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MfWebProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OtomasyonContainer : DbContext
    {
        public OtomasyonContainer()
            : base("name=OtomasyonContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AkademisyenlerSet> AkademisyenlerSets { get; set; }
        public virtual DbSet<FakultelerSet> FakultelerSets { get; set; }
        public virtual DbSet<KampuslerSet> KampuslerSets { get; set; }
        public virtual DbSet<OgrencilerSet> OgrencilerSets { get; set; }
    }
}