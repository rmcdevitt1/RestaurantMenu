using System;
namespace RestaurantMenu
{
    public class Menu
    {
        public string MenuItem { get; set; }
        public DateTime LastTimeUpdated { get; set; }

        //or
        //[System.Serializable]
        //public struct DateTime : IComparable, IComparable<DateTime>, IConvertible, IEquatable<DateTime>, IFormattable, System.Runtime.Serialization.ISerializable

        ////or
        //public struct DateTime { get; set; }



        public Menu(string menuItem, DateTime lastTimeUpdated)
        {
            MenuItem = menuItem;
            LastTimeUpdated = lastTimeUpdated;
        }
    }
}
