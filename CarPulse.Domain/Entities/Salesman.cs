using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Domain.Entities
{
    public class Salesman
    {
        [Key]
        public int SalesmanID { get; set; }

        [Required(ErrorMessage = "The name of the seller must be mentioned")]
        [MaxLength(20)]
        public string SalesmanName { get; set; }

        [Required(ErrorMessage = "The place of residence of the seller must be indicated")]
        [MaxLength(20)]
        public string SalesmanPlace { get; set; }

        [EmailAddress(ErrorMessage = "The email address is not entered correctly")]
        [Required(ErrorMessage = "The e-mail address of the seller should be noted")]
        public string SalesmanEmail { get; set; }

        [Phone] 
        [Required(ErrorMessage = "The phone number of the seller should be noted")]
        [MaxLength(20)]
        public string SalesmanPhone { get; set; }
        //public int AnnouncementID { get; set; }
        public ICollection<Announcement> Announcements { get; set; }
    }
}
