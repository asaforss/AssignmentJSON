using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace Assignment
{
    public class Methods
    {


        /// <summary>
        /// Main Logic. The list of available Dates is calculated and returned.
        /// </summary>
        /// <param name="postalCode"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        public List<DeliveryDate> ToDeliveryDateList(string postalCode, Productlist product)
        {

            //DateTime upcomingDate;
            int daysInAdvance = product.DaysInAdvance;

            //The number of the day of the week with Monday as 1 and Sunday as 7
            int thisDayOfWeek = GetThisDayOfWeekAsANumber();

            //Gets the number of upcoming dates for the product. Depends on how many days in advance the 
            //product should be ordered and the product type
            int numberOfAllUpcomingDays = GetNumberOfAllUpcomingDays(product, thisDayOfWeek);

            //Gets Delivery dates for this productlist
            List<DeliveryDate> deliveryDates = GetDeliveryDates(postalCode, product, numberOfAllUpcomingDays);

            //Sorts deliver dates ascending.
            deliveryDates = deliveryDates.OrderBy(d => d.DDate).ToList();

            return deliveryDates;
        }

     
        /// <summary>
        /// The number of the current day of the week with Monday as 1 and Sunday as 7
        /// </summary>
        /// <returns></returns>
        public int GetThisDayOfWeekAsANumber()
        {
            int thisDayOfWeek = (int)DateTime.Now.DayOfWeek;
            if (thisDayOfWeek == 0)
            {
                thisDayOfWeek = 7; //Sunday
            }
            return thisDayOfWeek;
        }
 
        /// <summary>
        /// Gets the number of upcoming dates for the product
        /// </summary>
        /// <param name="product"></param>
        /// <param name="thisDayOfWeek"></param>
        /// <returns></returns>
        public int GetNumberOfAllUpcomingDays(Productlist product, int thisDayOfWeek)
        {
            int numberOfAllUpcomingDays;
            int daysInAdvance = product.DaysInAdvance;
            //All external products need to be ordered 5 days in advance
            if (product.Type == ProductType.External)
            {
                daysInAdvance = 5;
            }
            numberOfAllUpcomingDays = 14 - daysInAdvance;
            //Temporary products can only be ordered witin the current week
            if (product.Type == ProductType.Temporary)
            {
                numberOfAllUpcomingDays = 8 - daysInAdvance - thisDayOfWeek;
            }
            return numberOfAllUpcomingDays;
        }

        //Gets Delivery dates for this productlist and time
        public List<DeliveryDate> GetDeliveryDates(string postalCode, Productlist product, int numberOfAllUpcomingDays)
        {
            List<DeliveryDate> deliveryDates = new List<DeliveryDate>();
            List<DeliveryDate> tempDeliveryDates = new List<DeliveryDate>();
            for (int i = 0; i < numberOfAllUpcomingDays; i++) //(1 i +1)
            {
                DateTime upcomingDate = DateTime.Now.AddDays(i).Date.AddDays(product.DaysInAdvance);
                tempDeliveryDates.Add(new DeliveryDate(postalCode, upcomingDate));
            }
            //A delivery date is not valid if a product can't be delivered on that weekday
            foreach (var item in product.DeliveryDays)
            {
                deliveryDates.AddRange(tempDeliveryDates.Where(d => d.DDate.DayOfWeek == item));
            }
            return deliveryDates;
        }


    }

}


