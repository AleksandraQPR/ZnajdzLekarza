using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZnajdzLekarza.DBO
{
    public class SpecialistDbo
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Description { get; set; }

        public string Education { get; set; }

        public virtual ICollection<LocalizationDbo> LocalizationDbos { get; set; }

        public virtual ICollection<SpecializationDbo> SpecializationDbos { get; set; }

        public virtual ICollection<ServiceDbo> ServiceDbos { get; set; }

        public virtual ICollection<VisitDbo> VisitDbos { get; set; }
    }
}
