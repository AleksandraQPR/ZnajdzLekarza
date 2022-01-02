using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZnajdzLekarza.DBO
{
    public class Specialization
    {
        public int ID { get; set; }

        public int SpecialistID { get; set; }

        public string Name { get; set; }

        public virtual Specialist Specialist { get; set; }
    }
}
