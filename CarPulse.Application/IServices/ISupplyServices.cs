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
    public interface ISupplyServices
    {
        //public Task<List<Supply>> GetAllSuplies();
        public Task<List<SupplyDTO>> GetAllSupliesDTO();
        public Task<SupplyDTO> AddSupplyDTO(SupplyDTO supplyDTO);
        public Task<SupplyDTOput> UpdateSupply(SupplyDTOput supplyDTOput, int supplyid);
        public Task<Supply> DeleteSupply(int id);

    }
}
