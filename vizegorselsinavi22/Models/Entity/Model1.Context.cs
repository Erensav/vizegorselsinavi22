﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vizegorselsinavi22.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class vizegorselsinavEntities1 : DbContext
    {
        public vizegorselsinavEntities1()
            : base("name=vizegorselsinavEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbl_idari> tbl_idari { get; set; }
        public virtual DbSet<tbl_ogrenciler> tbl_ogrenciler { get; set; }
        public virtual DbSet<tbl_ogretmen> tbl_ogretmen { get; set; }
    }
}