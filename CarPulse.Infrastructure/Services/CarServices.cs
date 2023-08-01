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
    public class CarServices : ICarServices
    {
        private readonly ILogger<CarServices> logger;
        private readonly IMapper mapper;
        private readonly CarContext carContext;

        public CarServices(ILogger<CarServices> _logger, IMapper _mapper, CarContext _carContext)
        {
            carContext = _carContext;
            logger = _logger;
            mapper = _mapper;
        }
        public async Task<CarDTO> AddCarsDTO(CarDTO carDTO)
        {
            var car = mapper.Map<Car>(carDTO);
            await carContext.Cars.AddAsync(car);
            await carContext.SaveChangesAsync();
            return carDTO;
        }


        //public async Task<List<Car>> GetAllCars()
        //{
        //    var car = await carContext.Cars
        //    .Include(c => c.Mileage)
        //    .Include(c => c.Engine)
        //    .Include(c => c.Price)
        //    .Include(c => c.Supplies)
        //    .Include(c => c.Photos)
        //    .ToListAsync();
        //    return car;
        //}

        public async Task<List<CarDTO>> GetAllCarsDTO()
        {
            var carsFromDatabase = await carContext.Cars
            .Include(c => c.Mileage)
            .Include(c => c.Engine)
            .Include(c => c.Price)
            .Include(c => c.Supplies)
            .Include(c => c.Photos)
            .ToListAsync();
            List<CarDTO> carDTOs = mapper.Map<List<CarDTO>>(carsFromDatabase);
            return carDTOs;
        }

        public async Task<CarDTOput> UpdateCar(CarDTOput carDTOput, int carid)
        {
            var car = mapper.Map<Car>(carDTOput);
            car.CarID = carid;
            carContext.Cars.Update(car);
            await carContext.SaveChangesAsync();
            return carDTOput;
        }

        public async Task<Car> DeleteCar(int id)
        {
            Car car = await carContext.Cars.FirstOrDefaultAsync(c => c.CarID == id);
            carContext.Cars.Remove(car);
            await carContext.SaveChangesAsync();
            return car;

        }
    }
}
