using AutoMapper;
using TestSol_API.Models.DTO;
using TestSol_API.ModelsTestSol;

namespace TestSol_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Empleado, EmpleadoDto>().ReverseMap();
            CreateMap<Area, AreaDto>().ReverseMap();
        }
    }
}
