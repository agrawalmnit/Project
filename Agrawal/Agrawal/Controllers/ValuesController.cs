using Agrawal.DTO;
using Agrawal.Models;
using Agrawal.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Agrawal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IService _iservice;
        
        public ValuesController(IService iservice)
        {
            _iservice = iservice;

        }

        [HttpGet]
        [Route("Get")]

        public async Task<Companies> Get(int Id)
        {
            var companies = new Companies();
            try
            {
                companies = await _iservice.Get(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return companies;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<List<Companies>> GetAll()
        {
            var companieslist = new List<Companies>();
            try
            {
                companieslist  = await _iservice.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return companieslist;
        }


        [HttpPut]
        [Route("put")]
        public async Task<bool> Update(int Id, CompaniesDTO companiesDTO)
        {
            try
            {
                await _iservice.Update(Id, companiesDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return true;
        }

        [HttpPost]
        [Route("post")]
        public async Task<bool> Create(CompaniesDTO companiesDTO)
        {
            try
            {
                await _iservice.Create(companiesDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
                return true;
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<bool> Delete(int Id, CompaniesDTO companiesDTO)
        {
            try
            {
                await _iservice.Delete(Id, companiesDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
                return true;
        }
    }
}
