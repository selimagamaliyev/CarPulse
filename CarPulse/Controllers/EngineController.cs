using CarPulse.Application.DTO_s;
using CarPulse.Application.DTO_s.EntityGet;
using CarPulse.Application.IServices;
using CarPulse.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarPulse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EngineController : ControllerBase
    {

        private readonly IEngineServices _services;

        public EngineController(IEngineServices engineServices)
        {
            _services = engineServices;
        }

        //[HttpGet]
        //public async Task<List<Engine>> GetAllEngine()
        //{
        //    return await _services.GetAllEngine();
        //}

        [HttpGet]
        public async Task<List<EngineDTO>> GetAllEngineDTO()
        {
            return await _services.GetAllEngineDTO();
        }

        [HttpPost]
        public async Task<EngineDTO> AddEngineDTO([FromQuery] EngineDTO engineDTO)
        {
            return await _services.AddEngineDTO(engineDTO);
        }

        [HttpPut]
        public async Task<EngineDTOput> UpdateEngine([FromQuery] EngineDTOput engineDTOput,int engineid)
        {
            return await _services.UpdateEngine(engineDTOput, engineid);
        }

        [HttpDelete]
        public async Task<Engine> DeleteEngne(int id)
        {
            return await _services.DeleteEngine(id);
        }
    }
}
