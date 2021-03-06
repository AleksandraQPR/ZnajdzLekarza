using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZnajdzLekarza.DBO
{
    public class Service
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        
        public virtual ICollection<Specialist> Specialists { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}
