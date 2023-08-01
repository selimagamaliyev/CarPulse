using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Application.DTO_s.EntityGet
{
    public class MileageDTOput
    {
        public int MileageID { get; set; }
        //public int CarID { get; set; }
        public uint Distance { get; set; }
        public string DistanceType { get; set; }
    }
}
