using System;
using System.Collections.Generic;

#nullable disable

namespace CarRegistration.DataAccessLayer.DataModels
{
    public partial class Car
    {
        public Car()
        {
            CarDevelorers = new HashSet<CarDevelorer>();
        }

        public int Id { get; set; }
        public int EngineTypeId { get; set; }
        public int? CarModelId { get; set; }
        public bool Accident { get; set; }
        public int OwnerId { get; set; }

        public virtual CarModel CarModel { get; set; }
        public virtual EngineType EngineType { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual ICollection<CarDevelorer> CarDevelorers { get; set; }
    }
}
