using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZnajdzLekarza.DBO
{
    public class VisitDbo
    {
        public int ID { get; set; }

        public int SpecialistDboID { get; set; }

        public int LocalizationDboID { get; set; }

        public int ServiceDboID { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }

        public virtual SpecialistDbo SpecialistDbo { get; set; }

        public virtual LocalizationDbo LocalizationDbo { get; set; }

        public virtual ServiceDbo ServiceDbo { get; set; }
    }
}
