using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Application.DTO_s.EntityGet
{
    public class PriceDTOput
    {
        public int PriceID { get; set; }
        //public int CarID { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }
    }
}
