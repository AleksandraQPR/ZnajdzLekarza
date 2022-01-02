using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZnajdzLekarza.DBO
{
    public class LocalizationDbo
    {
        public int ID { get; set; }

        public int SpecialistDboID { get; set; }

        public string StreetName { get; set; }

        public string StreetNumber { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public virtual ICollection<VisitDbo> VisitDbos { get; set; }

        public virtual SpecialistDbo SpecialistDbo { get; set; }
    }
}
