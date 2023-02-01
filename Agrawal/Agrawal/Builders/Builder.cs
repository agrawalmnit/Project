using Agrawal.DTO;
using Agrawal.Models;
using AutoMapper;

namespace Agrawal.Builders
{
    public class Builder : IBuilder
    {
        public readonly IMapper _map;

        public Builder(IMapper map) 
        {
            _map = map;
        
        }

        public Companies AutoMap(CompaniesDTO companiesDTO)
        {
            return _map.Map<Companies> (companiesDTO);
        }

        public CompaniesDTO AutoMap(Companies companies)
        {
           return  _map.Map<CompaniesDTO>(companies);
        }
    }
}
