using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; }
        public DateTime LastTimeUpdated { get; set; }



        public Menu(List<MenuItem> menuItems, DateTime lastTimeUpdated)
        {
            MenuItems = menuItems;
            LastTimeUpdated = lastTimeUpdated;
            //LastTimeUpdated =  DateTime.Now ???????
        }
      
    }
}
