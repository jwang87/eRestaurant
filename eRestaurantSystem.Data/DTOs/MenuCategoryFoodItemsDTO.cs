using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRestaurantSystem.Data.POCOs;

namespace eRestaurantSystem.Data.DTOs
{
    public class MenuCategoryFoodItemsDTO
    {
        public string MenuCategoryDescription { get; set; }
        public List<FoodItems> FoodItems { get; set; }
    }
}
