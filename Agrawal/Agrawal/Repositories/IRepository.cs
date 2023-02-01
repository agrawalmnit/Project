using Agrawal.Models;
using Agrawal.DTO;
namespace Agrawal.Repositories
{
    public interface IRepository 
    {
        Task<List<CompaniesDTO>> GetAll();

        Task<CompaniesDTO> Get(int Id);

        Task<bool> Delete(int Id, CompaniesDTO companiesDTO);

        Task<bool> Update(int Id,CompaniesDTO companiesDTO);
        Task<bool> Create(CompaniesDTO companiesDTO);
    }
}
