//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlasticsFactory.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Truck
    {
        public int ID { get; set; }
        public string LicencePlate { get; set; }
        public Nullable<int> Weight { get; set; }
        public int MSKH { get; set; }
        public bool isDelete { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}