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
    [Table("Reservations")]
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }
        public string CustomerName { get; set; }
        public DateTime ReservationDate { get; set; }
        public int NumberInParty { get; set; }
        public string ContactPhone { get; set; }
        public char ReservationStatus { get; set; }
        public char EventCode { get; set; }

        public virtual SpecialEvent SpecialEvent { get; set; }
    }
}
