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
        }
    
        public int TrainId { get; set; }
        public int CollectionFrom { get; set; }
        public int DeliveryTo { get; set; }
    
        public virtual Town Town { get; set; }
        public virtual Town Town1 { get; set; }
        public virtual ICollection<StockOnTrain> StockOnTrains { get; set; }
    }
}
