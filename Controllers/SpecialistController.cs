using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZnajdzLekarza.Models;

namespace ZnajdzLekarza.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpecialistController : ControllerBase
    {
        private static readonly Specialist Specialist1 = new Specialist
        {
            Id = 1,
            FirstName = "Imie1",
            LastName = "Nazwisko1",
            Email = "imie1.nazwisko1@kontakt.com",
            PhoneNumber = "000 000 000",
            Localizations = new List<Localization> { new Localization
                {
                    Id = 1,
                    StreetName = "Ulica1",
                    StreetNumber = "1",
                    ZipCode = "00-0000",
                    City = "Miasto1"
                }
            },
            Specializations = new List<Specialization> { new Specialization
                {
                    Id = 1,
                    Name = "Specializacja 1"
                }
            },
            Services = new List<Service> { new Service
                {
                    Id = 1,
                    Name = "Usługa 1"
                }
            }
        };

        private static readonly Specialist Specialist2 = new Specialist
        {
            Id = 2,
            FirstName = "Imie2",
            LastName = "Nazwisko2",
            Email = "imie2.nazwisko2@kontakt.com",
            PhoneNumber = "100 000 000",
            Localizations = new List<Localization> { new Localization
                {
                    Id = 2,
                    StreetName = "Ulica2",
                    StreetNumber = "2",
                    ZipCode = "20-0000",
                    City = "Miasto2"
                }
            },
            Specializations = new List<Specialization> { new Specialization
                {
                    Id = 2,
                    Name = "Specializacja 2"
                }
            },
            Services = new List<Service> { new Service
                {
                    Id = 2,
                    Name = "Usługa 2"
                }
            }
        };

        private readonly ILogger<SpecialistController> _logger;

        public SpecialistController(ILogger<SpecialistController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Specialist> Get()
        {
            return new List<Specialist>
            {
                Specialist1,
                Specialist2
            };
        }
    }
}
