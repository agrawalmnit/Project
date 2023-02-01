using Agrawal.DTO;
using Agrawal.Models;

namespace Agrawal.Services
{
    public interface IService 
    {
        Task<List<Companies>> GetAll();

            Task<Companies> Get(int Id);

            Task<bool> Delete(int Id, CompaniesDTO companies);

            Task<bool> Update(int Id, CompaniesDTO companiesDTO);

            Task<bool> Create(CompaniesDTO companiesDTO);
    }
}
