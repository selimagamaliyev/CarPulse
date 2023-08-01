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
    public interface IEngineServices
    {
        //public Task<List<Engine>> GetAllEngine();
        public Task<List<EngineDTO>> GetAllEngineDTO();
        public Task<EngineDTO> AddEngineDTO(EngineDTO engineDTO);
        public Task<EngineDTOput>UpdateEngine(EngineDTOput engineDTOput, int engineid);
        public Task<Engine> DeleteEngine(int id);
    }
}
