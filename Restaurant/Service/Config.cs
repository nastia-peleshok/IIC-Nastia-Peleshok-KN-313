using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Service
{
    public class Config
    {
        public static string ConnectionString { get; set; }
        public static string RestaurantName { get; set; }
        public static string RestaurantPhone { get; set; }
        public static string RestaurantPhoneShort { get; set; }
        public static string RestaurantEmail { get; set; }
    }
}
