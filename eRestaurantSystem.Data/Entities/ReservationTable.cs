﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace eRestaurantSystem.Data.Entities
{
    [Table("ReservationTables")]
    public class ReservationTable
    {
        [Key, Column(Order = 0)]
        public int TableID { get; set; }
        [Key, Column(Order = 1)]
        public int ReservationID { get; set; }

        public virtual Table Table { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
