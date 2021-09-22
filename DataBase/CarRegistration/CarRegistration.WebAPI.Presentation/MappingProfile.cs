using AutoMapper;
using CarRegistration.DataAccessLayer.DataModels;
using CarRegistration.WebAPI.Presentation.Models;

namespace CarRegistration.WebAPI.Presentation
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Develorer, DeveloperDTO>();
            CreateMap<DeveloperDTO, Develorer>();
        }
    }
}
