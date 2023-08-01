using CarPulse.Application.DTO_s;
using CarPulse.Application.DTO_s.EntityGet;
using CarPulse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Application.IServices
{
    public interface IPriceServices
    {
        //public Task<List<Price>> GetAllPrice();
        public Task<List<PriceDTO>> GetAllPriceDTO();
        public Task<PriceDTO> AddPriceDTO(PriceDTO priceDTO);
        public Task<PriceDTOput> UpdatePrice(PriceDTOput priceDTOput, int priceid);
        public Task<Price> DeletePrice(int id);

    }
}
