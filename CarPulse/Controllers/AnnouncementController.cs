using CarPulse.Application.DTO_s;
using CarPulse.Application.DTO_s.EntityGet;
using CarPulse.Application.IServices;
using CarPulse.Domain.Entities;
using CarPulse.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarPulse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        private readonly IAnnouncementServices _services;
        public AnnouncementController(IAnnouncementServices announcementServices)
        {
            _services = announcementServices;
        }

        //[HttpGet]
        //public async Task<List<Announcement>> GetAllAnnouncements()
        //{
        //    return await _services.GetAllAnnouncements();
        //}
        
        [HttpGet]
        public async Task<List<AnnouncementDTO>> GetAllAnnouncementsDTO()
        {
            return await _services.GetAllAnnouncementsDTO();
        }

        [HttpPost]
        public async Task<AnnouncementDTO> AddAnnouncementsDTO([FromQuery] AnnouncementDTO announcementDTO)
        {
            return await _services.AddAnnouncementsDTO(announcementDTO);
        }

        [HttpPut]
        public async Task<AnnouncementDTOput> UpdateAnnouncement([FromQuery] AnnouncementDTOput announcementDTOput, int announcementid)
        {
            return await _services.UpdateAnnouncement(announcementDTOput,announcementid);
        }

        [HttpDelete]
        public async Task<Announcement>DeleteAnnouncement(int id)
        {
            return await _services.DeleteAnnouncement(id);
        }

    }
}
