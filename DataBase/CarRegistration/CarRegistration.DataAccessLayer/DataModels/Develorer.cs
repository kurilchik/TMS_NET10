using System;
using System.Collections.Generic;

#nullable disable

namespace CarRegistration.DataAccessLayer.DataModels
{
    public partial class Develorer
    {
        public Develorer()
        {
            CarDevelorers = new HashSet<CarDevelorer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual ICollection<CarDevelorer> CarDevelorers { get; set; }
    }
}
