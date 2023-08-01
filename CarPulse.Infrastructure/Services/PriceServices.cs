using AutoMapper;
using CarPulse.Application.DTO_s;
using CarPulse.Application.DTO_s.EntityGet;
using CarPulse.Application.IServices;
using CarPulse.Domain.Entities;
using CarPulse.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Infrastructure.Services
{
    public class PriceServices : IPriceServices
    {
        private readonly ILogger<PriceServices> logger;
        private readonly IMapper mapper;
        private readonly CarContext carContext;

        public PriceServices(ILogger<PriceServices> _logger, IMapper _mapper, CarContext _carContext)
        {
            carContext = _carContext;
            logger = _logger;
            mapper = _mapper;
        }

        public async Task<PriceDTO> AddPriceDTO(PriceDTO priceDTO)
        {
            //Price price=new Price();
            //price.CarID = priceDTO.CarID;
            //price.Amount = priceDTO.Amount;
            //price.Currency=priceDTO.Currency;
            var price = mapper.Map<Price>(priceDTO);
            await carContext.Prices.AddAsync(price);
            await carContext.SaveChangesAsync();
            return priceDTO;
        }


        public async Task<List<PriceDTO>> GetAllPriceDTO()
        {
            var pricefromdatabase = await carContext.Prices.ToListAsync();
            List<PriceDTO> priceDTOs = mapper.Map<List<PriceDTO>>(pricefromdatabase);
            return priceDTOs;
        }

        //public async Task<List<Price>> GetAllPrice()
        //{
        //    var engine = await carContext.Prices.ToListAsync();
        //    return engine;
        //}

        public async Task<PriceDTOput> UpdatePrice(PriceDTOput priceDTOput, int priceid)
        {
            var price = mapper.Map<Price>(priceDTOput);
            price.PriceID = priceid;
            carContext.Prices.Update(price);
            await carContext.SaveChangesAsync();
            return priceDTOput;
        }

        public async Task<Price> DeletePrice(int id)
        {
            Price price = await carContext.Prices.FirstOrDefaultAsync(c => c.PriceID == id);
            carContext.Prices.Remove(price);
            await carContext.SaveChangesAsync();
            return price;
        }
    }
}
