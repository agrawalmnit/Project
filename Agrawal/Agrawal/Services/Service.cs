using Agrawal.Builders;
using Agrawal.DTO;
using Agrawal.Models;
using Agrawal.Repositories;


namespace Agrawal.Services
{

    public class Service : IService
    {
        private readonly IRepository _irepository;
        private readonly IBuilder _ibuilder;
        public Service(IRepository irepository, IBuilder ibuilder)
        {
            _irepository = irepository;
            _ibuilder = ibuilder;
        }

        public async Task<List<Companies>> GetAll()
        {

            var companiesDTOlist = await _irepository.GetAll();
             return companiesDTOlist.Select(x=> _ibuilder.AutoMap(x)).ToList();
                             
        }

        public async Task<Companies> Get(int Id)
        {

            var companiesDTO = await _irepository.Get(Id);
            var companies = _ibuilder.AutoMap(companiesDTO);
            return companies;
        }
        public async Task<bool> Update(int Id, CompaniesDTO companiesDTO)
        {
            await _irepository.Update(Id, companiesDTO);
            return true;
        }
        public async Task<bool> Delete(int Id, CompaniesDTO companiesDTO)
        {
            await _irepository.Delete(Id, companiesDTO);
            return true;
        }
        public async Task<bool> Create(CompaniesDTO companiesDTO)
        {
            await _irepository.Create(companiesDTO);
            return true;
        }
    }
}






