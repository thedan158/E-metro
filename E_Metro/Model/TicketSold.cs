//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_Metro.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TicketSold
    {
        public int SoldID { get; set; }
        public Nullable<int> Id { get; set; }
        public Nullable<int> RailwayID { get; set; }
        public Nullable<int> IdType { get; set; }
    
        public virtual RailWay RailWay { get; set; }
        public virtual StandarTicket StandarTicket { get; set; }
        public virtual TicketType TicketType { get; set; }
    }
}
