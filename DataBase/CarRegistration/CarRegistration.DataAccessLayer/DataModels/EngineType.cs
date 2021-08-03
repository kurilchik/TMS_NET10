using System;
using System.Collections.Generic;

#nullable disable

namespace CarRegistration.DataAccessLayer.DataModels
{
    public partial class EngineType
    {
        public EngineType()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
