using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Domain.Entities
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }
        //public int AnnouncementID { get; set; }


        [Required(ErrorMessage = "The marka of the car is required")]
        [MaxLength(20)]
        public string Marka { get; set; }
      

        [Required(ErrorMessage = "The car model is required")]
        [MaxLength(20)]
        public string Model { get; set; }

        [Required(ErrorMessage = "Production year must be specified")]
        public ushort Production { get; set; }

        [Required(ErrorMessage = "The technical stuation of the car must be specified")]
        [MaxLength(20)]
        public string Situation { get; set; }

        [Required(ErrorMessage = "Car color must be specified")]
        [MaxLength(20)]
        public string Color { get; set; }

        [Required(ErrorMessage = "Box name must be specified")]
        [StringLength(10, ErrorMessage = "Box name must not exceed 10 characters")]
        public string Gearbox { get; set; }
        
        [Required(ErrorMessage = "The transmission of the car must be specified")]
        [MaxLength(20)]
        public string Transmission { get; set; }

        [Required(ErrorMessage = "Body style must be specified")]
        [MaxLength(20)]
        public string BodyType { get; set; }

        public string Information { get; set; }
        //public int EngineID { get; set; }
        //public int MileageID { get; set; }
        ////public int PriceID { get; set; }
        //public int PhotoID { get; set; }
        //public int SuppliesID { get; set; }

        public Announcement Announcement { get; set; }
        public Engine Engine { get; set; }
        public Mileage Mileage { get; set; }
        public Price Price { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Supply> Supplies { get; set; }

    }
}
