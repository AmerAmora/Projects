//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project7.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Show_Seats
    {
        public int Show_Seat_id { get; set; }
        public Nullable<int> Show_id { get; set; }
        public Nullable<int> CinemaSeatid { get; set; }
        public string Ticket_id { get; set; }
    
        public virtual Show Show { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
