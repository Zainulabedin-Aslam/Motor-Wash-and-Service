//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarServiceManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_cancel
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public string cancelled_by { get; set; }
        public string reason { get; set; }
    
        public virtual tbl_order tbl_order { get; set; }
    }
}