﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NWT_Rezervacija.Data
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationTime { get; set; }
        



        public int UserId { get; set;}
        public int ManagerId { get; set; }
        public int ClubId { get; set; }  //Doda sam ovaj dio
    }
}