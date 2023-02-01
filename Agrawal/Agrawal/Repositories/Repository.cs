using Agrawal.DTO;
using Agrawal.Models;

namespace Agrawal.Repositories
{
    public class Repository : IRepository
    {

        List<CompaniesDTO> CompaniesList = new List<CompaniesDTO>()
        {
            new CompaniesDTO{ Id = 1, Name = "Abjima"} ,
            new CompaniesDTO{ Id = 2,Name = "IT"}
        };

        public async Task<CompaniesDTO> Get(int Id)
        {
            CompaniesDTO companiesDTO = new CompaniesDTO();
            companiesDTO = (from s in CompaniesList
                         where s.Id == Id
                         select s).FirstOrDefault();
            return companiesDTO;
        }

        public async Task<List<CompaniesDTO>> GetAll()
        {
            
            

            var companiesList = (from s in CompaniesList
                         select new CompaniesDTO
                         {
                             Id = s.Id,
                             Name = s.Name
                         }).ToList().FirstOrDefault();
            return CompaniesList;
        }

            public async Task<bool> Update(int Id, CompaniesDTO companiesDTO)
        {


            for (int i = 0; i < CompaniesList.Count; i++)
            {
                if (CompaniesList[i].Id == Id)
                {
                    CompaniesList[i].Id = companiesDTO.Id;
                    CompaniesList[i].Name = companiesDTO.Name;

                }
                else
                {
                    return false;
                }
            }
                return true;
            
            
        }

            public async Task<bool> Delete(int Id, CompaniesDTO companiesDTO)
        {
            
            var companiesDTOtobedeleted = (from s in CompaniesList
                         where s.Id == Id
                         select s).FirstOrDefault();
            CompaniesList.Remove(companiesDTOtobedeleted);

            return true;

        }

            public async Task<bool> Create(CompaniesDTO companiesDTO)
        {
            
            CompaniesList.Add(companiesDTO);
            return true;

        }
    }
}
