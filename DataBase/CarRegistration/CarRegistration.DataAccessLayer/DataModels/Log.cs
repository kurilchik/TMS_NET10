using System;
using System.Collections.Generic;

#nullable disable

namespace CarRegistration.DataAccessLayer.DataModels
{
    public partial class Log
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Changes { get; set; }
    }
}
