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
    
    public partial class RollingStock
    {
        public RollingStock()
        {
            this.StockOnTrain = new HashSet<StockOnTrain>();
        }
    
        public int SerialNumber { get; set; }
        public int StockTypeId { get; set; }
    
        public virtual StockType StockType { get; set; }
        public virtual ICollection<StockOnTrain> StockOnTrain { get; set; }
    }
}
