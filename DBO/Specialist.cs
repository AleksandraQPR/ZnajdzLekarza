using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZnajdzLekarza.DBO
{
    public class Specialist
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string PhoneNumber { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        [MaxLength(250)]
        public string Education { get; set; }

        public virtual ICollection<Localization> Localizations { get; set; }

        public virtual ICollection<Specialization> Specializations { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}
