using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Domain.Entities
{
    public class Mileage
    {
        [Key]
        public int MileageID { get; set; }

        [Required(ErrorMessage = "The mileage of the car must be specified")]
        public uint Distance { get; set; }

        [Required(ErrorMessage = "Unit of measurement must be specified")]
        public string DistanceType { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
    }
}
