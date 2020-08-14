using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaSystem.Models
{
    public class BookingModel
    {
        public int Id { get; set; }
        public int BookingId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string EmailAddress { get; set; }

        public string BookingDate { get; set; }


    }
}