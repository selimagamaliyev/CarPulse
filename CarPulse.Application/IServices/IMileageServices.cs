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
    public interface IMileageServices
    {
        //public Task<List<Mileage>> GetAllMileage();
        public Task<List<MileageDTO>> GetAllMileageDTO();
        public Task<MileageDTO> AddMileageDTO(MileageDTO mileageDTO);
        public Task<MileageDTOput> UpdateMileage(MileageDTOput mileageDTOput, int mileageid);
        public Task<Mileage> DeleteMileage(int id);

    }
}
