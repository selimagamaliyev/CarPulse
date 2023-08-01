using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPulse.Domain.Entities
{
    public class Announcement
    {
        [Key]
        public int AnnouncementID { get; set; }
        public int CarID { get; set; }
        public int SalesmanID { get; set; }
        public Car Car { get; set; }
        public Salesman Salesman { get; set; }

    }
}
