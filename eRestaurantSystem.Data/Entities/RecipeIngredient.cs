using System;
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
    [Table("RecipeIngredients")]
    public class RecipeIngredient
    {
        [Key]
        public int RecipeIngredientID { get; set; }
        public int RecipeID { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
