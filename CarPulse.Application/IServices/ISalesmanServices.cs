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
    public interface ISalesmanServices
    {
        //public Task<List<Salesman>> GetAllSalesmans();
        //public Task<List<Salesman>> AddSalesman(Salesman salesman);
        public Task<List<SalesmanDTO>> GetAllSalesmenDTO();
        public Task<SalesmanDTO>AddSalesmanDTO(SalesmanDTO salesmanDTO);
        public Task<SalesmanDTOput> UpdateSalesman(SalesmanDTOput salesmanDTOput, int salesmanid);
        public Task<Salesman> DeleteSalesman(int id);

    }
}
