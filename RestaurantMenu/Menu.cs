using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; }
        public DateTime LastTimeUpdated { get; set; }
        public string RestaurantName { get; set; }

        public Menu(List<MenuItem> menuItems, DateTime lastTimeUpdated, string restaurantName)
        {
            MenuItems = menuItems;
            LastTimeUpdated = lastTimeUpdated;
            RestaurantName = restaurantName;
        }

        public Menu()
        {
            MenuItems = new List<MenuItem>();
        }

        public object AddMenuItem(object menuItem)
        {
            MenuItems.Add((MenuItem)menuItem);
            return MenuItems;
        }

        public object RemoveMenuItem(object menuItem)
        {
            MenuItems.Remove((MenuItem)menuItem);
            return MenuItems;
        }

        public void PrintMenu()
        {
            Console.WriteLine("Restaurant Name: " + this.RestaurantName);
            Console.WriteLine("Menu Date: " + this.LastTimeUpdated.ToString("MMMM dd, yyyy"));
            Console.WriteLine("");
            foreach (MenuItem m in MenuItems)
            {
                m.PrintItem();

            }

        }

    }
}
