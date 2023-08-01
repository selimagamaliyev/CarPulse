using CarPulse.Application.DTO_s;
using CarPulse.Application.DTO_s.EntityGet;
using CarPulse.Application.IServices;
using CarPulse.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarPulse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : ControllerBase
    {

        private readonly IPriceServices _services;

        public PriceController(IPriceServices priceServices)
        {
            _services = priceServices;
        }

        //[HttpGet]
        //public async Task<List<Price>> GetAllPrice()
        //{
        //    return await _services.GetAllPrice();
        //}

        [HttpGet]
        public async Task<List<PriceDTO>> GetAllPriceDTO()
        {
            return await _services.GetAllPriceDTO();
        }

        [HttpPost]
        public async Task<PriceDTO> AddPriceDTO([FromQuery] PriceDTO priceDTO)
        {
            return await _services.AddPriceDTO(priceDTO);
        }

        [HttpPut]
        public async Task<PriceDTOput> UpdatePrice([FromQuery] PriceDTOput priceDTOput, int priceid)
        {
            return await _services.UpdatePrice(priceDTOput, priceid);
        }

        [HttpDelete]
        public async Task<Price> DeletePrice(int id)
        {
            return await _services.DeletePrice(id);
        }
    }
}
