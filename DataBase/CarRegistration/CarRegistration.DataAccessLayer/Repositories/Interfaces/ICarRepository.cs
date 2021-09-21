using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegistration.DataAccessLayer.Repositories.Interfaces
{
    public interface ICarRepository 
    {
        void Add(int ownerId, int engineTypeId, int carModelId);
    }
}
