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
    public class MileageServices : IMileageServices
    {
        private readonly ILogger<MileageServices> logger;
        private readonly IMapper mapper;
        private readonly CarContext carContext;

        public MileageServices(ILogger<MileageServices> _logger, IMapper _mapper, CarContext _carContext)
        {
            carContext = _carContext;
            logger = _logger;
            mapper = _mapper;
        }

        public async Task<MileageDTO> AddMileageDTO(MileageDTO mileageDTO)
        {
            //Mileage mileage = new Mileage();
            //mileage.CarID = mileageDTO.CarID;
            //mileage.Distance = mileageDTO.Distance;
            //mileage.DistanceType = mileageDTO.DistanceType;
            var mileage = mapper.Map<Mileage>(mileageDTO);
            await carContext.Mileages.AddAsync(mileage);
            await carContext.SaveChangesAsync();
            return mileageDTO;
        }

        public async Task<List<MileageDTO>> GetAllMileageDTO()
        {
            var mileagefromdatabase = await carContext.Mileages.ToListAsync();
            List<MileageDTO> mileageDTOs = mapper.Map<List<MileageDTO>>(mileagefromdatabase);
            return mileageDTOs;
        }

        //public async Task<List<Mileage>> GetAllMileage()
        //{
        //    var mileage = await carContext.Mileages.ToListAsync();
        //    return mileage;
        //}

        public async Task<MileageDTOput> UpdateMileage(MileageDTOput mileageDTOput, int mileageid)
        {
            var mileage = mapper.Map<Mileage>(mileageDTOput);
            mileage.MileageID = mileageid;
            carContext.Mileages.Update(mileage);
            await carContext.SaveChangesAsync();
            return mileageDTOput;
        }

        public async Task<Mileage> DeleteMileage(int id)
        {
            Mileage mileage = await carContext.Mileages.FirstOrDefaultAsync(c => c.MileageID == id);
            carContext.Mileages.Remove(mileage);
            await carContext.SaveChangesAsync();
            return mileage;
        }
    }
}
