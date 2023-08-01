using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Application.DTO_s.EntityGet
{
    public class AnnouncementDTOput
    {
        public int AnnouncementID { get; set; }
        public int SalesmanID { get; set; }
        public SalesmanDTO Salesman { get; set; }
        public CarDTO Car { get; set; }
        public EngineDTO Engine { get; set; }
        public MileageDTO Mileage { get; set; }
        public PriceDTO Price { get; set; }
        //public List<string> Photos { get; set; }
        //public List<string> Supplies { get; set; }
    }
}
