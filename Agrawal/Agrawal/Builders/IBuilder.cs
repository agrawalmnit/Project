using Agrawal.DTO;
using Agrawal.Models;

namespace Agrawal.Builders
{
    public interface IBuilder 
    {
        public Companies AutoMap(CompaniesDTO companiesDTO);

        public CompaniesDTO AutoMap(Companies companies);
    }
}
