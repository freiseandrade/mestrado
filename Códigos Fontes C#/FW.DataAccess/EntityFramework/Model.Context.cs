﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FW.DataAccess.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Feed> Feed { get; set; }
        public virtual DbSet<IdxIBMWatsonToneAnalyzer> IdxIBMWatsonToneAnalyzer { get; set; }
        public virtual DbSet<Quotation> Quotation { get; set; }
        public virtual DbSet<RssConfig> RssConfig { get; set; }
        public virtual DbSet<StopWords> StopWords { get; set; }
        public virtual DbSet<V_IBM_WatsonToneAnalyzer> V_IBM_WatsonToneAnalyzer { get; set; }
        public virtual DbSet<IdxGoogleCloudNaturalLanguageAPI> IdxGoogleCloudNaturalLanguageAPI { get; set; }
        public virtual DbSet<FeedPos> FeedPos { get; set; }
        public virtual DbSet<V_Google_CloudNaturalLanguageAPI> V_Google_CloudNaturalLanguageAPI { get; set; }
    }
}
