using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZnajdzLekarza.DBO
{
    public class Service
    {
        public int ID { get; set; }

        public string Name { get; set; }
        
        public virtual ICollection<Specialist> Specialists { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}
