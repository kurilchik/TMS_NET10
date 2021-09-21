using CarRegistration.DataAccessLayer.DataModels;
using CarRegistration.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegistration.DataAccessLayer.Repositories
{
    public class CarRepository : ICarRepository
    {
        private CarDbContext _carDbContext;
        public CarRepository(CarDbContext carDbContext)
        {
            _carDbContext = carDbContext;
        }
        public void Add(int ownerId, int engineTypeId, int carModelId)
        {
            Car car = new Car();
            car.OwnerId = ownerId;
            car.EngineTypeId = engineTypeId;
            car.CarModelId = carModelId;
            _carDbContext.Cars.Add(car);
        }
    }
}
