using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZnajdzLekarza.Models
{
    public class Localization
    {
        public int Id { get; set; }
        
        public string StreetName { get; set; }

        public string StreetNumber { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }
    }
}
