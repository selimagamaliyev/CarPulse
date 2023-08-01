using CarPulse.Application.DTO_s;
using CarPulse.Application.DTO_s.EntityGet;
using CarPulse.Application.IServices;
using CarPulse.Domain.Entities;
using CarPulse.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarPulse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplyController:ControllerBase
    {
        private readonly ISupplyServices _services;
        public SupplyController(ISupplyServices supplyServices)
        {
             _services = supplyServices;
        }

        //[HttpGet]
        //public async Task<List<Supply>> GetAllSupplies()
        //{
        //    return await _services.GetAllSuplies();
        //}
        
        [HttpGet]
        public async Task<List<SupplyDTO>> GetAllSuppliesDTO()
        {
            return await _services.GetAllSupliesDTO();
        }

        [HttpPost]
        public async Task<SupplyDTO> AddSupliesDTO([FromQuery] SupplyDTO supplyDTO)
        {
            return await _services.AddSupplyDTO(supplyDTO);
        }

        [HttpPut]
        public async Task<SupplyDTOput> UpdateSupply([FromQuery] SupplyDTOput supplyDTOput, int supplyid)
        {
            return await _services.UpdateSupply(supplyDTOput, supplyid);
        }

        [HttpDelete]
        public async Task<Supply> DeleteSupply(int id)
        {
            return await _services.DeleteSupply(id);
        }
    }
}
