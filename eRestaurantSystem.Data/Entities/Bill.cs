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
    [Table("Bills")]
    public class Bill
    {
        public int BillID { get; set; }
        public DateTime BillDate { get; set; }
        public TimeSpan? OrderPlaced { get; set; }
        public TimeSpan? OrderReady { get; set; }
        public TimeSpan? OrderServed { get; set; }
        public TimeSpan? OrderPaid { get; set; }
        public int NumberInParty { get; set; }
        public bool PaidStatus { get; set; }
        public int WaiterID { get; set; }
        public int? TableID { get; set; }
        public int? ReservationID { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<BillItem> BillItems { get; set; }

    }
}
