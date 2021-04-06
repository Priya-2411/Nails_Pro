using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NailsPro.Models
{
    public class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            
            Bookings = new HashSet<Booking>();
        }

        [Key]
        public int StaffId { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        public string LastName { get; set; }
        [Column(TypeName = "char(10)")]
        [Required]
        public string Phone { get; set; }
       

        

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
