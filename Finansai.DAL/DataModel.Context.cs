﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Finansai.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FinansaiEntities : DbContext
    {
        public FinansaiEntities()
            : base("name=FinansaiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AsmeninePrieziura> AsmeninePrieziura { get; set; }
        public virtual DbSet<BustoIslaidos> BustoIslaidos { get; set; }
        public virtual DbSet<Dienos> Dienos { get; set; }
        public virtual DbSet<Dovanos> Dovanos { get; set; }
        public virtual DbSet<Kita> Kita { get; set; }
        public virtual DbSet<Maistas> Maistas { get; set; }
        public virtual DbSet<Menesiai> Menesiai { get; set; }
        public virtual DbSet<Metai> Metai { get; set; }
        public virtual DbSet<Pramogos> Pramogos { get; set; }
        public virtual DbSet<Savaites> Savaites { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Transportas> Transportas { get; set; }
        public virtual DbSet<Santaupos> Santaupos { get; set; }
        public virtual DbSet<BustoIslaidos_Savaitine> BustoIslaidos_Savaitine { get; set; }
    }
}
