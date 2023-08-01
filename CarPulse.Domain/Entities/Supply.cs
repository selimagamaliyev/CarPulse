using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Domain.Entities
{
    public class Supply
    {
        public int SupplyID { get; set; }
        public string AddSupplies { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
    }
}
