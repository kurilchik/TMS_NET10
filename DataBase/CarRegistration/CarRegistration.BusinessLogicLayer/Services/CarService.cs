using CarRegistration.BusinessLogicLayer.Services.Interfaces;
using CarRegistration.DataAccessLayer.DataModels;
using CarRegistration.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegistration.BusinessLogicLayer.Services
{
    public class CarService : ICarService
    {
        private ICarRepository _carRepository;
        private CarDbContext _carDbContext;

        public CarService(ICarRepository carRepository, CarDbContext carDbContext)
        {
            _carRepository = carRepository;
            _carDbContext = carDbContext;
        }
        public void Add(int ownerId, int engineTypeId, int carModelId)
        {
            _carRepository.Add(ownerId, engineTypeId, carModelId);
            _carDbContext.SaveChanges();
        }
    }
}
