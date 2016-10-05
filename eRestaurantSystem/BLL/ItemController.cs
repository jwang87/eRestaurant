using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel; //ODS
using eRestaurantSystem.Data.Entities;
using eRestaurantSystem.Data.POCOs;
using eRestaurantSystem.Data.DTOs;
using eRestaurantSystem.DAL;
#endregion


namespace eRestaurantSystem.BLL
{
    [DataObject]
    public class ItemController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<MenuCategoryFoodItemsPOCO> MenueCategoryFoodItem_Get()
        {
            using (var context = new eRestaurantContext())
            {
                var results = (from food in context.Items
                               orderby food.MenuCategory.Description
                               select new MenuCategoryFoodItemsPOCO
                               {
                                   MenuCategoryDestription = food.MenuCategory.Description,
                                   ItemID = food.ItemID,
                                   FoodDescription = food.Description,
                                   CurrentPrice = food.CurrentPrice,
                                   //TimesServed = food.BillItems.Count()
                                   TimesServed =10
                               }).ToList();

                return results;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<MenuCategoryFoodItemsDTO> MenuCategoryFoodItemDTO_Get()
        {
            using (var context = new eRestaurantContext())
            {
                var results = (from food in context.Items
                               group food by new { food.MenuCategory.Description } into tempdataset
                               select new MenuCategoryFoodItemsDTO
                               {
                                   MenuCategoryDescription = tempdataset.Key.Description,
                                   FoodItems = (from x in tempdataset
                                                select new FoodItems
                                                {
                                                    ItemID = x.ItemID,
                                                    FoodDescription = x.Description,
                                                    CurrentPrice = x.CurrentPrice,
                                                    TimesServed = 10
                                                }).ToList()
                               });

                return results.ToList();
            }
        }
    }
}
