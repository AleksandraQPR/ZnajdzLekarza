using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZnajdzLekarza.DBO
{
    public class Specialist
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Description { get; set; }

        public string Education { get; set; }

        public virtual ICollection<Localization> Localizations { get; set; }

        public virtual ICollection<Specialization> Specializations { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}
