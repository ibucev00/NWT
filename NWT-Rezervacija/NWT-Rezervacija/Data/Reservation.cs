using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NWT_Rezervacija.Data
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public DateTime ReservationTime { get; set; }
        

        public virtual Manager Manager { get; set; }
        public virtual Club Club { get; set; }  //Doda sam ovaj dio      
        public virtual Table Table { get; set; }
        
    }
}