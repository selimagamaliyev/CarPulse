using CarPulse.Application.DTO_s;
using CarPulse.Application.DTO_s.EntityGet;
using CarPulse.Application.IServices;
using CarPulse.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarPulse.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {

        private readonly IPhotoServices _services;

        public PhotoController(IPhotoServices photoServices)
        {
            _services = photoServices;
        }

        //[HttpGet]
        //public async Task<List<Photo>> GetAllPhotos()
        //{
        //    return await _services.GetAllPhotos();
        //}

        [HttpGet]
        public async Task<List<PhotoDTO>> GetAllPhotosDTO()
        {
            return await _services.GetAllPhotosDTO();
        }
        //[HttpPost]
        //public async Task<Photo> AddPhotos([FromQuery]Photo photo)
        //{
        //    return await _services.AddPhotos(photo);
        //}

        [HttpPost/*("{DTO}")*/]
        public async Task<PhotoDTO> AddPhotosDTO([FromQuery] PhotoDTO photoDTO)
        {
            return await _services.AddPhotoDTO(photoDTO);
        }

        [HttpPut]
        public async Task<PhotoDTOput> UpdatePhoto([FromQuery] PhotoDTOput photoDTOput, int photoid)
        {
            return await _services.UpdatePhoto(photoDTOput, photoid);
        }

        [HttpDelete]
        public async Task<Photo> DeletePhoto(int id)
        {
            return await _services.DeletePhoto(id);
        }
    }
}
