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
    public class PhotoServices : IPhotoServices
    {
        private readonly ILogger<PhotoServices> logger;
        private readonly IMapper mapper;
        private readonly CarContext carContext;

        public PhotoServices(ILogger<PhotoServices> _logger, IMapper _mapper, CarContext _carContext)
        {
            carContext = _carContext;
            logger = _logger;
            mapper = _mapper;
        }

        public async Task<PhotoDTO> AddPhotoDTO(PhotoDTO photoDTO)
        {
            //Photo photo = new Photo();
            ////photo.PhotoID = photoDTO.PhotoID;
            //photo.CarID = photoDTO.CarID;
            //photo.PhotoAdress = photoDTO.PhotoAdress;
            var photo = mapper.Map<Photo>(photoDTO);
            await carContext.Photos.AddAsync(photo);
            await carContext.SaveChangesAsync();
            return photoDTO;
        }


        public async Task<List<PhotoDTO>> GetAllPhotosDTO()
        {
            var photofromdatabase = await carContext.Photos.ToListAsync();
            List<PhotoDTO> photoDTOs = mapper.Map<List<PhotoDTO>>(photofromdatabase);
            return photoDTOs;
        }

        //public async Task<List<Photo>> GetAllPhotos()
        //{
        //    var photo=await carContext.Photos.ToListAsync();
        //    return photo;
        //}

        public async Task<PhotoDTOput> UpdatePhoto(PhotoDTOput photoDTOput, int photoid)
        {
            var photo = mapper.Map<Photo>(photoDTOput);
            photo.PhotoID = photoid;
            carContext.Photos.Update(photo);
            await carContext.SaveChangesAsync();
            return photoDTOput;
        }

        public async Task<Photo> DeletePhoto(int id)
        {
            Photo photo = await carContext.Photos.FirstOrDefaultAsync(c => c.PhotoID == id);
            carContext.Photos.Remove(photo);
            await carContext.SaveChangesAsync();
            return photo;
        }
    }
}
