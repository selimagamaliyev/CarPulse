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
    public class MileageController : ControllerBase
    {

        private readonly IMileageServices _services;

        public MileageController(IMileageServices engineServices)
        {
            _services = engineServices;
        }

        //[HttpGet]
        //public async Task<List<Mileage>> GetAllMileage()
        //{
        //    return await _services.GetAllMileage();
        //}

        [HttpGet]
        public async Task<List<MileageDTO>> GetAllMileageDTO()
        {
            return await _services.GetAllMileageDTO();
        }

        [HttpPost]
        public async Task<MileageDTO> AddMileageDTO([FromQuery] MileageDTO mileageDTO)
        {
            return await _services.AddMileageDTO(mileageDTO);
        }

        [HttpPut]
        public async Task<MileageDTOput> UpdateMileage([FromQuery] MileageDTOput mileageDTOput, int mileageid)
        {
            return await _services.UpdateMileage(mileageDTOput, mileageid);
        }

        [HttpDelete]
        public async Task<Mileage> DeleteMileage(int id)
        {
            return await _services.DeleteMileage(id);
        }
    }
}
