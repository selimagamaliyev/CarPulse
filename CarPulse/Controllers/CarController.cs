using CarPulse.Application.DTO_s;
using CarPulse.Application.DTO_s.EntityGet;
using CarPulse.Application.IServices;
using CarPulse.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarPulse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {

        private readonly ICarServices _services;

        public CarController(ICarServices carServices)
        {
            _services = carServices;
        }

        //[HttpGet]
        //public async Task<List<Car>> GetAllCars()
        //{
        //    return await _services.GetAllCars();
        //}
        [HttpGet]
        public async Task<List<CarDTO>> GetAllCarDTOs()
        {
            return await _services.GetAllCarsDTO();
        }

        [HttpPost]
        public async Task<CarDTO> AddCarsDTO([FromQuery] CarDTO carDTO)
        {
            return await _services.AddCarsDTO(carDTO);
        }

        [HttpPut]
        public async Task<CarDTOput> UpdateCar([FromQuery] CarDTOput carDTOput, int carid)
        {
            return await _services.UpdateCar(carDTOput, carid);
        }

        [HttpDelete]
        public async Task<Car> DeleteCar(int id)
        {
            return await _services.DeleteCar(id);
        }
    }
}
