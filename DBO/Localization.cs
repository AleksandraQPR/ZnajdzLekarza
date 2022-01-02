using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZnajdzLekarza.DBO
{
    public class Localization
    {
        public int ID { get; set; }

        public int SpecialistID { get; set; }

        public string StreetName { get; set; }

        public string StreetNumber { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }

        public virtual Specialist Specialist { get; set; }
    }
}
