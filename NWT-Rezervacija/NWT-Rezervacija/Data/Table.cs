﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NWT_Rezervacija.Data
{
    public class Table
    {
        public int Id { get; set; }
        public string TypeOfTable { get; set; }


        public int ManagerId { get; set; }  //Dali treba imati strani ključ od voditelja kluba??
        public int ClubId { get; set; }
    }
}