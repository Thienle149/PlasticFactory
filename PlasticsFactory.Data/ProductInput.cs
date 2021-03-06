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
    
    public partial class ProductInput
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductInput()
        {
            this.PaymentInputs = new HashSet<PaymentInput>();
        }
    
        public int ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public int MSKH { get; set; }
        public string MSXE { get; set; }
        public Nullable<int> TruckWeight { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> ProductWeight { get; set; }
        public Nullable<int> ProductPrice { get; set; }
        public Nullable<int> TotalAmount { get; set; }
        public int Payed { get; set; }
        public Nullable<int> Own { get; set; }
        public bool Paid { get; set; }
        public Nullable<int> TotalWeight { get; set; }
        public bool isDelete { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentInput> PaymentInputs { get; set; }
    }
}
