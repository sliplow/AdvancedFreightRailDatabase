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
    
    public partial class RouteStage
    {
        public int RouteId_FK { get; set; }
        public int StageId_FK { get; set; }
        public int VisitSequence { get; set; }
    
        public virtual Route ARouteStageHasOnly1Route { get; set; }
        public virtual Stage ARouteStageHasOnly1Stage { get; set; }
    }
}
