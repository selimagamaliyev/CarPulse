using AutoMapper;
using CarPulse.Application.DTO_s;
using CarPulse.Application.IServices;
using CarPulse.Infrastructure.Services;
using CarPulse.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPulse.Infrastructure.Context;
using CarPulse.Application.DTO_s.EntityGet;

namespace CarPulse.Infrastructure.Services
{
    public class AnnouncementServices : IAnnouncementServices
    {
        private readonly ILogger<AnnouncementServices> logger;
        private readonly IMapper mapper;
        private readonly CarContext carContext;
        public AnnouncementServices(ILogger<AnnouncementServices> _logger, IMapper _mapper, CarContext _carContext)
        {
            carContext = _carContext;
            logger = _logger;
            mapper = _mapper;
        }

        //public async Task<List<Announcement>> GetAllAnnouncements()
        //{
        //    var announcement=await carContext.Announcements
        //        .Include(a=>a.Salesman)
        //        .Include(a=>a.Car)
        //        .Include(a => a.Car.Price)
        //        .Include(a => a.Car.Engine)
        //        .Include(a => a.Car.Mileage)
        //        .Include(a => a.Car.Supplies)
        //        .Include(a => a.Car.Photos)
        //        .ToListAsync();
        //    return announcement.ToList();
        //}


        public async Task<List<AnnouncementDTO>> GetAllAnnouncementsDTO()
        {
            var announcementsFromDatabase = await carContext.Announcements
            .Include(a => a.Car)
            .Include(a => a.Salesman)
            .Include(a => a.Car.Price)
            .Include(a => a.Car.Engine)
            .Include(a => a.Car.Mileage)
            .Include(a => a.Car.Supplies)
            .Include(a => a.Car.Photos)
            .ToListAsync();
            List<AnnouncementDTO> announcementDTOs = mapper.Map<List<AnnouncementDTO>>(announcementsFromDatabase);
            return announcementDTOs;
        }

        public async Task<AnnouncementDTO> AddAnnouncementsDTO(AnnouncementDTO announcementDTO)
        {
            //Announcement announcement = new Announcement();
            //announcement.CarID = announcementDTO.CarID;
            //announcement.SalesmanID = announcementDTO.SalesmanID;
            var announcement = mapper.Map<Announcement>(announcementDTO);
            await carContext.Announcements.AddAsync(announcement);
            await carContext.SaveChangesAsync();
            return announcementDTO;
        }

        public async Task<AnnouncementDTOput> UpdateAnnouncement(AnnouncementDTOput announcementDTOput, int announcementid)
        {
            var announcement = mapper.Map<Announcement>(announcementDTOput);
            announcement.AnnouncementID = announcementid;
            carContext.Update(announcement);
            await carContext.SaveChangesAsync();
            return announcementDTOput;
        }

        public async Task<Announcement> DeleteAnnouncement(int id)
        {
            Announcement announcement = await carContext.Announcements.FirstOrDefaultAsync(c => c.AnnouncementID == id);
            carContext.Announcements.Remove(announcement);
            await carContext.SaveChangesAsync();
            return announcement;
        }
    }
}
