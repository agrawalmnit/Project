using Agrawal.DTO;
using Agrawal.Models;
using AutoMapper;

namespace Agrawal.Builders
{
    public class CustomBuilder : Profile
    {
        public CustomBuilder()
        {
            CreateMap<Companies, CompaniesDTO>();
            CreateMap<CompaniesDTO, Companies>();
        }
    }
}
