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
    public interface IAnnouncementServices
    {
        //public Task<List<Announcement>> GetAllAnnouncements();
        public Task<List<AnnouncementDTO>> GetAllAnnouncementsDTO();
        public Task<AnnouncementDTO> AddAnnouncementsDTO(AnnouncementDTO announcementDTO);
        public Task<AnnouncementDTOput> UpdateAnnouncement(AnnouncementDTOput announcementDTOput, int announcementid);
        public Task<Announcement> DeleteAnnouncement(int id);
    }
}
