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
    public interface ICarServices
    {
        //public Task<List<Car>> GetAllCars();
        public Task<List<CarDTO>> GetAllCarsDTO();
        public Task<CarDTO> AddCarsDTO(CarDTO carDTO);
        public Task<CarDTOput> UpdateCar(CarDTOput carDTOput, int carid);
        public Task<Car> DeleteCar(int id);

    }
}
