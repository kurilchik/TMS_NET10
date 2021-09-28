using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRegistration.WebApplication.Presentation.Models
{
    public class AddDeveloperDTO
    {
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
