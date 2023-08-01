using CarPulse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Application.DTO_s
{
    public class AnnouncementDTO
    {
        ////public int AnnouncementID { get; set; }
        //public int CarID { get; set; }
        //public int SalesmanID { get; set; }
        public SalesmanDTO Salesman { get; set; }
        public CarDTO Car { get; set; }
    }
}
