using System;
using System.Collections.Generic;

#nullable disable

namespace CarRegistration.DataAccessLayer.DataModels
{
    public partial class Owner
    {
        public Owner()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
