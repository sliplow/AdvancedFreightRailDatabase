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
    
    public partial class Stage
    {
        public Stage()
        {
            this.AStageHas1OrManyRouteStages = new HashSet<RouteStage>();
        }
    
        public int StageId { get; set; }
        public int From_FK { get; set; }
        public int To_FK { get; set; }
        public string Distance { get; set; }
    
        public virtual ICollection<RouteStage> AStageHas1OrManyRouteStages { get; set; }
        public virtual Town AStageHasOnly1FromTown { get; set; }
        public virtual Town AStageHasOnly1ToTown { get; set; }
    }
}
