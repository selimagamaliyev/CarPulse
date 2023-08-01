using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Domain.Entities
{
    public class Price
    {
        [Key]
        public int PriceID { get; set; }
        [Required(ErrorMessage = "Amount must be specified")]       
        public double Amount { get; set;}

        [Required(ErrorMessage = "Currency must be specified")]
        public string Currency { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
    }
}
