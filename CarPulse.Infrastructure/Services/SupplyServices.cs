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
    public class SupplyServices : ISupplyServices
    {
        private readonly ILogger<SupplyServices> logger;
        private readonly IMapper mapper;
        private readonly CarContext carContext;

        public SupplyServices(ILogger<SupplyServices> _logger, IMapper _mapper, CarContext _carContext)
        {
            carContext = _carContext;
            logger = _logger;
            mapper = _mapper;
        }
        public async Task<SupplyDTO> AddSupplyDTO(SupplyDTO supplyDTO)
        {
            //Supply supply = new Supply();
            //supply.CarID = supplyDTO.CarID;
            //supply.AddSupplies= supplyDTO.AddSupplies;
            var supply=mapper.Map<Supply>(supplyDTO);
            await carContext.Supplies.AddAsync(supply);
            await carContext.SaveChangesAsync();
            return supplyDTO;
        }

        public async Task<List<SupplyDTO>> GetAllSupliesDTO()
        {
            var supplyfromdatabase = await carContext.Supplies.ToListAsync();
            List<SupplyDTO> supplyDTOs = mapper.Map<List<SupplyDTO>>(supplyfromdatabase);
            return supplyDTOs;
        }

        //public async Task<List<Supply>> GetAllSuplies()
        //{
        //    var supply=await carContext.Supplies.ToListAsync();
        //    return supply;
        //}

        public async Task<SupplyDTOput> UpdateSupply(SupplyDTOput supplyDTOput, int supplyid)
        {
            var supply = mapper.Map<Supply>(supplyDTOput);
            supply.SupplyID = supplyid;
            carContext.Supplies.Update(supply);
            await carContext.SaveChangesAsync();
            return supplyDTOput;
        }

        public async Task<Supply> DeleteSupply(int id)
        {
            Supply supply = await carContext.Supplies.FirstOrDefaultAsync(c => c.SupplyID == id);
            carContext.Supplies.Remove(supply);
            await carContext.SaveChangesAsync();
            return supply;
        }
    }
}
