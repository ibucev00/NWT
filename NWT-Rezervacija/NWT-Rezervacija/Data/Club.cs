using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NWT_Rezervacija.Data
{
    public class Club
    {
        public int ClubName { get; set; }
        public string Location { get; set; }

        public int ManagerId { get; set; }
        public ICollection<Table> Tables { get; set; }
    }
}