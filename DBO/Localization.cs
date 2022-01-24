using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZnajdzLekarza.DBO
{
    public class Localization
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string StreetName { get; set; }

        [Required]
        [MaxLength(10)]
        public string StreetNumber { get; set; }

        [Required]
        [MaxLength(5)]
        public string ZipCode { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }  // czy to powinno tutaj być??
        
        public virtual ICollection<Specialist> Specialists { get; set; }
    }
}
