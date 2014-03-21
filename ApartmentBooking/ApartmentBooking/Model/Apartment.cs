using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApartmentBooking.Model
{
    public class Apartment
    {
        public int ApartmentId { get; set; }
        public string ApartmentDescription { get; set; }
        public byte Rooms { get; set; }
    }
}