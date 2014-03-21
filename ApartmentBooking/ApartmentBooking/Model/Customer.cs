using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApartmentBooking.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required (ErrorMessage ="Förnamn måste anges")]
        [StringLength(20, ErrorMessage="Fältet förnamn kan högst ha 20 tecken")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Efternamn måste anges")]
        [StringLength(25, ErrorMessage = "Fältet efternamn kan högst ha 25 tecken")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Adress måste anges")]
        [StringLength(25, ErrorMessage = "Fältet adress kan högst ha 25 tecken")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Postnummer måste anges")]
        [RegularExpression(@"^[1-9]\d{2} ?\d{2}$")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Ort måste anges")]
        [StringLength(25, ErrorMessage = "Fältet ort kan högst ha 25 tecken")]
        public string City { get; set; }
    }
}