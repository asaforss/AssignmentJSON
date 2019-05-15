using System;
using System.Runtime.Serialization;

namespace Assignment
    
{   [Serializable]
    [DataContract()]
    public class DeliveryDate
    {
        //Fields
        [DataMember]
        private string postalCode;
        [DataMember]
        private DateTime deliveryDate;
        //[DataMember]
        //private bool isGreenDelivery;

        //Properties
        public string PostalCode { get { return postalCode; } }   
        public DateTime DDate { get { return deliveryDate; } }
        //public bool IsGreenDelivery { get { return isGreenDelivery; } }
        
        //Constructor
        public DeliveryDate(string postalCode,DateTime dDate)
        {
            this.postalCode = postalCode;
            this.deliveryDate = dDate;
           
        }

        
    }
}
