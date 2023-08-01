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
    public interface IPhotoServices
    {
        //public Task<List<Photo>> GetAllPhotos();
        public Task<List<PhotoDTO>> GetAllPhotosDTO();
        public Task<PhotoDTO> AddPhotoDTO(PhotoDTO photoDTO);
        public Task<PhotoDTOput> UpdatePhoto(PhotoDTOput photoDTOput, int photoid);
        public Task<Photo> DeletePhoto(int id);

    }
}
