//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIPSorcery.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class RTCC
    {
        public string ID { get; set; }
        public string CDRID { get; set; }
        public string AccountCode { get; set; }
        public Nullable<int> SecondsReserved { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public string ReservationError { get; set; }
        public string ReconciliationResult { get; set; }
        public bool IsHangingUp { get; set; }
        public Nullable<decimal> PostReconciliationBalance { get; set; }
        public decimal SetupCost { get; set; }
        public int IncrementSeconds { get; set; }
        public System.DateTime Inserted { get; set; }
    
        public virtual CDR cdr { get; set; }
    }
}
