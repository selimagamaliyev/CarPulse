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
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Infrastructure.Services
{
    public class SalesmanServices:ISalesmanServices
    {
        private readonly ILogger<SalesmanServices> logger;
        private readonly IMapper mapper;
        private readonly CarContext carContext;

        public SalesmanServices(ILogger<SalesmanServices> _logger, IMapper _mapper, CarContext _carContext)
        {
            carContext = _carContext;
            logger = _logger;
            mapper = _mapper;
        }
        public async Task<SalesmanDTO> AddSalesmanDTO(SalesmanDTO salesmanDTO)
        {
            //Salesman salesman= new Salesman();
            //salesman.SalesmanName= salesmanDTO.SalesmanName;
            //salesman.SalesmanPhone= salesmanDTO.SalesmanPhone;
            //salesman.SalesmanPlace= salesmanDTO.SalesmanPlace;
            //salesman.SalesmanEmail= salesmanDTO.SalesmanEmail;
            var salesman = mapper.Map<Salesman>(salesmanDTO);
            await carContext.Salesmen.AddAsync(salesman);
            await carContext.SaveChangesAsync();
            return salesmanDTO;
        }

        public async Task<List<SalesmanDTO>> GetAllSalesmenDTO()
        {
            var salesmanfromdatabase =await carContext.Salesmen.ToListAsync();
            List<SalesmanDTO> salesmanDTOs = mapper.Map<List<SalesmanDTO>>(salesmanfromdatabase);
            return salesmanDTOs;
        }

        //public async Task<List<Salesman>> GetAllSalesmans()
        //{
        //    var salesman= await carContext.Salesmen.ToListAsync();
        //    return salesman;
        //}

        public async Task<SalesmanDTOput> UpdateSalesman(SalesmanDTOput salesmanDTOput, int salesmanid)
        {
            var salesman = mapper.Map<Salesman>(salesmanDTOput);
            salesman.SalesmanID = salesmanid;
            carContext.Salesmen.Update(salesman);
            await carContext.SaveChangesAsync();
            return salesmanDTOput;
        }

        public async Task<Salesman> DeleteSalesman(int id)
        {
            Salesman salesman = await carContext.Salesmen.FirstOrDefaultAsync(c => c.SalesmanID == id);
            carContext.Salesmen.Remove(salesman);
            await carContext.SaveChangesAsync();
            return salesman;
        }
    }
}
