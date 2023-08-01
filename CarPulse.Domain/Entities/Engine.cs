using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Domain.Entities
{
    public class Engine
    {
        [Key]
        public int EngineID { get; set; }

        [Required(ErrorMessage = "Motor type must be specified")]
        [MaxLength(20)]
        public string EngineType { get; set; }

        [Required(ErrorMessage = "Motor valume must be specified")]
        [Range(1, 10, ErrorMessage = "Motor valume must be between 0 and 10")]
        public double EngineValume { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
    }
}
