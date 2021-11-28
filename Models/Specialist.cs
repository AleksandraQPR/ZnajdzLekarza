using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZnajdzLekarza.Models
{
    public class Specialist
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Description { get; set; }

        public string Education { get; set; }

        public IList<Localization> Localizations { get; set; }

        public IList<Specialization> Specializations { get; set; }

        public IList<Service> Services { get; set; }
    }
}
