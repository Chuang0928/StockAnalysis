﻿//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceLibrary
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class stockdbaEntities : DbContext
    {
        public stockdbaEntities()
            : base("name=stockdbaEntities")
        {

        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Broker> Broker { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<DailyDetail> DailyDetail { get; set; }
        public DbSet<DailyRate> DailyRate { get; set; }
        public DbSet<DailySettlement> DailySettlement { get; set; }
        public DbSet<DailySummary> DailySummary { get; set; }
        public DbSet<DailyWork> DailyWork { get; set; }
        public DbSet<ServiceLog> ServiceLog { get; set; }
        public DbSet<WeeklyRate> WeeklyRate { get; set; }
        public DbSet<TotalRate> TotalRate { get; set; }
    
        public virtual int ResetCompany()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ResetCompany");
        }
    }
}
