using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZnajdzLekarza.DBO
{
    public class ServiceDbo
    {
        public int ID { get; set; }

        public string Name { get; set; }
        
        public virtual ICollection<SpecialistDbo> SpecialistDbos { get; set; }

        public virtual ICollection<VisitDbo> VisitDbos { get; set; }
    }
}
