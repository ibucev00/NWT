using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NWT_Rezervacija.Data
{
    public class Club
    {
        public int ClubId { get; set; }
        public int ClubName { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Manager> Managers { get; set; }
        public virtual ICollection<Table> Tables { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}