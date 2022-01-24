using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZnajdzLekarza.DBO
{
    public class Visit
    {
        public int ID { get; set; }

        public int SpecialistID { get; set; }

        public int LocalizationID { get; set; }

        public int ServiceID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public decimal Price { get; set; }

        public virtual Specialist Specialist { get; set; }

        public virtual Localization Localization { get; set; }

        public virtual Service Service { get; set; }
    }
}
