//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Train
    {
        public Train()
        {
            this.StockOnTrains = new HashSet<StockOnTrain>();
            this.Routes = new HashSet<Route>();
            this.Goods = new HashSet<Goods>();
        }
    
        public int TrainId { get; set; }
        public int DriverId_FK { get; set; }
        public int CoDriverId_FK { get; set; }
        public decimal GrossWeight { get; set; }
        public string TotalLength { get; set; }
    
        public virtual ICollection<StockOnTrain> StockOnTrains { get; set; }
        public virtual Driver MainDriver { get; set; }
        public virtual Driver SecondaryDriver { get; set; }
        public virtual ICollection<Route> Routes { get; set; }
        public virtual ICollection<Goods> Goods { get; set; }
    }
}
