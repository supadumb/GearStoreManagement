//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gear_Store
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_Items
    {
        public string order_id { get; set; }
        public string product_id { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public decimal discount { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
