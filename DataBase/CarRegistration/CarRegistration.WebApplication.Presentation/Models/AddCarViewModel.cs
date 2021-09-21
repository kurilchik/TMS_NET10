using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRegistration.WebApplication.Presentation.Models
{
    public class AddCarViewModel
    {
        public int OwnerId { get; set; } 
        public int EngineTypeId { get; set; }
        public int CarModelId { get; set; }
    }
}
