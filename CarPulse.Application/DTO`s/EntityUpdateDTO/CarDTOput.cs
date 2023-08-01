using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Application.DTO_s.EntityGet
{
    public class CarDTOput
    {
        public int CarID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Production { get; set; }
        public string Situation { get; set; }
        public string Color { get; set; }
        public string Gearbox { get; set; }
        public string Transmission { get; set; }
        public string BodyType { get; set; }
        public string Information { get; set; }
        public EngineDTO Engine { get; set; }
        public MileageDTO Mileage { get; set; }
        public PriceDTO Price { get; set; }
        public List<string> Photos { get; set; }
        public List<string> Supplies { get; set; }
    }
}
