using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZnajdzLekarza.Models
{
    public class Visit 
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public Specialist Specialist { get; set; }

        public Localization Localization { get; set; }

        public Service Service { get; set; }

        public decimal Price { get; set; }
    }
}
