using System;
namespace RestaurantMenu
{
    public class Restaurant
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Menu myMenu = new Menu()
            {
                RestaurantName = "Mission Taco",
                LastTimeUpdated = DateTime.Today
            };


            MenuItem myItem = new MenuItem("Queso con Chorizo", "Cheesey Goodness", "Appetizer", (double)7.99, false);
            MenuItem myItem1 = new MenuItem("Churros", "Comes With Chocolate", "Dessert", (double)4.99, false);
            MenuItem myItem2 = new MenuItem("Hot Fried Chicken", "On A Flour Tortilla", "Taco", (double)3.75, true);
            MenuItem myItem3 = new MenuItem("South Beach", "Chicken, Beans, & Other Stuff", "Burrito", (double)10.99, false );

            myMenu.AddMenuItem(myItem);
            myMenu.AddMenuItem(myItem1);
            myMenu.AddMenuItem(myItem2);
            myMenu.AddMenuItem(myItem3);

            myMenu.PrintMenu();
        }
    }
}
