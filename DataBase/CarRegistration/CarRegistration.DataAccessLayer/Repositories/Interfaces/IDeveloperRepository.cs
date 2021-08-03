using CarRegistration.DataAccessLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegistration.DataAccessLayer.Repositories.Interfaces
{
    public interface IDeveloperRepository
    {
        void Add(Develorer developer);
    }
}
