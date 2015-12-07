using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NWT_Rezervacija.Data
{
    public class Table
    {
        [Key]
        [ForeignKey("RezId")]
        public int TableId { get; set; }
        public string TypeOfTable { get; set; }
        

        public virtual Club Club { get; set; }
        public virtual Reservation RezId { get; set; }
    }
}