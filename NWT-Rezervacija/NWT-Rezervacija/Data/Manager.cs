using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NWT_Rezervacija.Data
{
    public class Manager
    {
        public int ManagerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        //public string ClubLeader { get; set; }   //Ovaj dio ne treba jer smo dodali strani ključ od kluba


        public virtual Club Club { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}