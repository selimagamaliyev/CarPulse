using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Domain.Entities
{
    public class Photo
    {
        [Key]
        public int PhotoID { get; set; }

        [Required(ErrorMessage = "The pictures of the car must be specified")]
        public string PhotoAdress { get; set; }

        public int CarID { get; set; }
        public Car Car { get; set; }
    }
}
