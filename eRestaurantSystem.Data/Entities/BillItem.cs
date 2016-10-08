using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region AdditionalSpaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace eRestaurantSystem.Data.Entities
{
    [Table("BillItems")]
    public class BillItem
    {
        [Key]
        public int BillID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal SalePrice { get; set; }
        public decimal UnitCost { get; set; }
        public string Notes { get; set; }
        public Byte TableNumber { get; set; }
        public Byte SeatNumber { get; set; }
        public int QtyServed { get; set; }

        public virtual Item Item { get; set; }
        public virtual Bill Bill { get; set; }
    }
}
