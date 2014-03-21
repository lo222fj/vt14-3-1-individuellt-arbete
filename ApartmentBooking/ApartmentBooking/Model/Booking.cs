using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApartmentBooking.Model
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int CustomerId { get; set; }
        public int ApartmentId { get; set; }

        [Required(ErrorMessage = "Ankomstdatum måste anges")]
        public DateTime DateArrival { get; set; }

        [Required(ErrorMessage = "Avresedatum måste anges")]
        public DateTime DateDeparture { get; set; }

        [Required(ErrorMessage = "Priset måste anges")]
        public int PriceApartment { get; set; }
    }
}