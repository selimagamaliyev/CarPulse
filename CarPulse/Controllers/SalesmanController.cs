using CarPulse.Application.DTO_s;
using CarPulse.Application.DTO_s.EntityGet;
using CarPulse.Application.IServices;
using CarPulse.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarPulse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesmanController : ControllerBase
    {
        private readonly ISalesmanServices _services;

        public SalesmanController(ISalesmanServices salesmanServices)
        {
            _services = salesmanServices;
        }
        //[HttpGet]
        //public async Task<List<Salesman>> GetAllSalesmen()
        //{
        //    return await _services.GetAllSalesmans();
        //}
        
        [HttpGet]
        public async Task<List<SalesmanDTO>> GetAllSalesmenDTO()
        {
            return await _services.GetAllSalesmenDTO();
        }

        //[HttpPost]
        //public async Task<List<Salesman>> AddSalesman(Salesman salesman)
        //{
        //    return await _services.AddSalesman(salesman);
        //}

        [HttpPost/*("{DTO}")*/]
        public async Task<SalesmanDTO> AddSalesman([FromQuery] SalesmanDTO salesmanDTO)
        {
            return await _services.AddSalesmanDTO(salesmanDTO);
        }

        [HttpPut]
        public async Task<SalesmanDTOput> UpdateSalesman([FromQuery] SalesmanDTOput salesmanDTOput,int salesmanid)
        {
            return await _services.UpdateSalesman(salesmanDTOput,salesmanid);
        }

        [HttpDelete]
        public async Task<Salesman> DeleteSalesman(int id)
        {
            return await _services.DeleteSalesman(id);
        }
    }
}
