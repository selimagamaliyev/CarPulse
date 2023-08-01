using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Application.DTO_s
{
    public class CarDTO
    {
        //public int CarID { get; set; }
        //public string Marka { get; set; }
        //public string Model { get; set; }
        //public ushort Production { get; set; }
        //public string Situation { get; set; }
        //public string Color { get; set; }
        //public string Gearbox { get; set; }
        //public string Transmission { get; set; }
        //public string BodyType { get; set; }
        //public string Information { get; set; }

        //public int CarID { get; set; }
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
    //public int EngineID { get; set; }
    //public int MileageID { get; set; }
    //public int PriceID { get; set; }
    //public int PhotoID { get; set; }
    //public int SuppliesID { get; set; }

    //public string EngineType { get; set; }
    //public byte EngineValume { get; set; }


    //public uint Distance { get; set; }
    //public string DistanceType { get; set; }

}

