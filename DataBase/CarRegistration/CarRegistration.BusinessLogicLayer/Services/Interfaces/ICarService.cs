using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegistration.BusinessLogicLayer.Services.Interfaces
{
    public interface ICarService
    {
        void Add(int ownerId, int engineTypeId, int carModelId);

    }
}
