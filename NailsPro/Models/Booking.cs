using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NailsPro.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }


        public DateTime BookingDate { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int staff_id { get; set; }

       

        public virtual Customer Customer { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
