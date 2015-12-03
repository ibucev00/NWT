using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NWT_Rezervacija.Data
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Created { get; set; }


        public ICollection<Reservation> Reservations { get; set; }


    }
}