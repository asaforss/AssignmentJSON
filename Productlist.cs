using System;
using System.Collections.Generic;


namespace Assignment
{
    public class Productlist
    {
        // Statisk räknare som håller reda på hur många 
        // produkter som har skapats
        public static int productCounter;

        // Properties
        public int Id { get;}
       
        public string Name { get; }

        public int DaysInAdvance { get; }

        public ProductType Type { get; }

        //public bool IsGreenDelivery { get; }


        public List<DayOfWeek> DeliveryDays { get; set; }

        //Constructor
        public Productlist(string name, int daysInAdvance, ProductType type, List<DayOfWeek> deliveryDays)
        {
            Name = name;
            DaysInAdvance = daysInAdvance;
            Type = type;
            DeliveryDays = deliveryDays;
            Id = productCounter;
            productCounter++;
        }

    }
}
