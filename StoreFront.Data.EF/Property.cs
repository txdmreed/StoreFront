//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreFront.Data.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Property
    {
        public int PropertyID { get; set; }
        public int ProductID { get; set; }
        public string FiberCode { get; set; }
        public Nullable<int> Weight { get; set; }
        public string Color { get; set; }
        public string OriginCode { get; set; }
        public Nullable<bool> Baby { get; set; }
        public string ActivityType { get; set; }
        public string EndProductType { get; set; }
        public string Size { get; set; }
    
        public virtual ProductBoard ProductBoard { get; set; }
    }
}
