using AutoMapper;
using CarPulse.Application.DTO_s;
using CarPulse.Application.DTO_s.EntityGet;
using CarPulse.Application.IServices;
using CarPulse.Domain.Entities;
using CarPulse.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Infrastructure.Services
{
    public class EngineServices : IEngineServices
    {
        private readonly ILogger<EngineServices> logger;
        private readonly IMapper mapper;
        private readonly CarContext carContext;

        public EngineServices(ILogger<EngineServices> _logger, IMapper _mapper, CarContext _carContext)
        {
            carContext = _carContext;
            logger = _logger;
            mapper = _mapper;
        }

        public async Task<EngineDTO> AddEngineDTO(EngineDTO engineDTO)
        {
            //Engine engine = new Engine();
            //engine.CarID=engineDTO.CarID;
            //engine.EngineType= engineDTO.EngineType;
            //engine.EngineValume = engineDTO.EngineValume;
            var engine = mapper.Map<Engine>(engineDTO);
            await carContext.Engines.AddAsync(engine);
            await carContext.SaveChangesAsync();
            return engineDTO;
        }


        //public async Task<List<Engine>> GetAllEngine()
        //{
        //    var engine=await carContext.Engines.ToListAsync();
        //    return engine;
        //}

        public async Task<List<EngineDTO>> GetAllEngineDTO()
        {
            var enginefromdatabase = await carContext.Engines.ToListAsync();
            List<EngineDTO> engineDTOs = mapper.Map<List<EngineDTO>>(enginefromdatabase);
            return engineDTOs;
        }

        public async Task<EngineDTOput> UpdateEngine(EngineDTOput engineDTOput, int engineid)
        {
            var engine = mapper.Map<Engine>(engineDTOput);
            engine.EngineID = engineid;
            carContext.Engines.Update(engine);
            await carContext.SaveChangesAsync();
            return engineDTOput;
        }

        public async Task<Engine> DeleteEngine(int id)
        {
            Engine engine = await carContext.Engines.FirstOrDefaultAsync(c => c.EngineID == id);
            carContext.Engines.Remove(engine);
            await carContext.SaveChangesAsync();
            return engine;
        }

    }
}
