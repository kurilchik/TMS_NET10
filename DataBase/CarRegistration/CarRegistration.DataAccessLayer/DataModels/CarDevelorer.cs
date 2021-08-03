using System;
using System.Collections.Generic;

#nullable disable

namespace CarRegistration.DataAccessLayer.DataModels
{
    public partial class CarDevelorer
    {
        public int DevelorerId { get; set; }
        public int CarId { get; set; }

        public virtual Car Car { get; set; }
        public virtual Develorer Develorer { get; set; }
    }
}
