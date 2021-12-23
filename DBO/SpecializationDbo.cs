using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZnajdzLekarza.DBO
{
    public class SpecializationDbo
    {
        public int ID { get; set; }

        public int SpecialistDboID { get; set; }

        public string Name { get; set; }

        public virtual SpecialistDbo SpecialistDbo { get; set; }
    }
}
