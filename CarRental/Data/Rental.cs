//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRental.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rental
    {
        public int RentalID { get; set; }
        public int UserID { get; set; }
        public int CarID { get; set; }
        public System.DateTime Pickup { get; set; }
        public System.DateTime DropOff { get; set; }
        public int Price { get; set; }
    
        public virtual Car Car { get; set; }
        public virtual User User { get; set; }
    }
}