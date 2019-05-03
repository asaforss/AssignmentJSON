using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement
{
    class Productlist
    {
        public static int productId;

        public string Name { get; set; }

        public int DaysInAdvance { get; set; }

        public ProductType Type { get; set; }

        
        public List<DayOfWeek> DeliveryDays { get; set; }

        public Productlist(string name, int daysInAdvance, ProductType type, List<DayOfWeek> deliveryDays)
        {
            Name = name;
            DaysInAdvance = daysInAdvance;
            Type = type;
            DeliveryDays = deliveryDays;
            productId++;
        }

    }
}
