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
    
    public partial class Delivery
    {
        public int TrainId_FK { get; set; }
        public int GoodsId_FK { get; set; }
        public string Quantity { get; set; }
        public int CollectionFrom_FK { get; set; }
        public int DeliveryTo_FK { get; set; }
    
        public virtual Station DeliveryHasOnly1CollectionTown { get; set; }
        public virtual Station DeliveryHasOnly1DeliveryTown { get; set; }
        public virtual Goods DeliveryHasOnly1Good { get; set; }
        public virtual Train ADeliveryIsOnOnly1Train { get; set; }
    }
}
