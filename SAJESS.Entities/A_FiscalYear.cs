//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAJESS.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class A_FiscalYear
    {
        public int FYId { get; set; }
        public string FiscalYear { get; set; }
        public System.DateTime FromDate { get; set; }
        public System.DateTime ToDate { get; set; }
        public bool IsBooked { get; set; }
        public string UserId { get; set; }
        public Nullable<System.DateTime> BookedDate { get; set; }
    
        public virtual A_BookValue A_BookValue { get; set; }
    }
}
