using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Assignement
{
    public class Methods
    {
      
        //Main Logic. The list of available Dates is calculated and returned. 
        public List<DeliveryDate> ToDeliveryDateList(string postalCode, Productlist product)
        {
            
            //DateTime upcomingDate;
            int daysInAdvance = product.DaysInAdvance;

            //The number of the current day of the week with Monday as 1 and Sunday as 7
            int thisDayOfWeek=GetThisDayOfWeekAsANumber();

            //Gets the number of upcoming dates for the product. Depends on how many days in advance the 
            //product should be ordered and the product type
            int numberOfUpcomingDays= GetNumberOfUpcomingDays(product,thisDayOfWeek);
           
            //Gets Delivery dates for this productlist
            List<DeliveryDate> deliveryDates=GetDeliveryDates(postalCode,product,numberOfUpcomingDays);             
            
            //Sorts deliver dates ascending.
            deliveryDates = deliveryDates.OrderBy(d => d.DDate).ToList();

            return deliveryDates;
        }

        //The number of the current day of the week with Monday as 1 and Sunday as 7
        private int GetThisDayOfWeekAsANumber()
        {
            int thisDayOfWeek = (int)DateTime.Now.DayOfWeek;
            if (thisDayOfWeek == 0)
            {
                thisDayOfWeek = 7; //Sunday
            }
            return thisDayOfWeek;
        }

        // Gets the number of upcoming dates for the product
        private int GetNumberOfUpcomingDays(Productlist product,int thisDayOfWeek){
            //All external products need to be ordered 5 days in advance
            int numberOfUpcomingDays;
            int daysInAdvance=product.DaysInAdvance;
             //All external products need to be ordered 5 days in advance
            if (product.Type == ProductType.External)
            {
                daysInAdvance = 5;
            }
            numberOfUpcomingDays = 14 - daysInAdvance;
           //Temporary products can only be ordered witin the current week
            if (product.Type == ProductType.Temporary)
            {
                numberOfUpcomingDays = 8 - daysInAdvance - thisDayOfWeek;
            }
            return numberOfUpcomingDays;
        }

        //Gets Delivery dates for this productlist and time
        private List<DeliveryDate> GetDeliveryDates(string postalCode,Productlist product,int numberOfUpcomingDays)
        {
            List<DeliveryDate> deliveryDates = new List<DeliveryDate>();
            List<DeliveryDate> tempDeliveryDates = new List<DeliveryDate>();
            for (int i = 0; i < numberOfUpcomingDays; i++) //(1 i +1)
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

     // JSON 
        //http://csharphelper.com/blog/2018/01/use-json-to-serialize-and-deserialize-objects-in-c/
        public string ToJson(List<DeliveryDate> deliveryDates)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<DeliveryDate>));
                ser.WriteObject(stream, deliveryDates);
                stream.Flush();
                stream.Seek(0, SeekOrigin.Begin);
                using (StreamReader reader = new StreamReader(stream))
                {
                    string json = reader.ReadToEnd();
                    json = ToJsonFormatted(json);
                    return json;
                }

            }

        }
        //https://stackoverflow.com/questions/2661063/how-do-i-get-formatted-json-in-net-using-c
        private string ToJsonFormatted(string json)
        {
            json = JToken.Parse(json).ToString(Formatting.Indented);
            return json;
        }

    }
    
    }


