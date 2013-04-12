﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdvancedFreightRailDatabase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelContainer : DbContext
    {
        public ModelContainer()
            : base("name=ModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<StockType> StockTypes { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<StockOnTrain> StockOnTrains { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<RollingStock> RollingStocks { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<RouteStage> RouteStages { get; set; }
        public DbSet<DriverQualification> DriverQualifications { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<TrainRoutes> TrainRoutes { get; set; }
    }
}
