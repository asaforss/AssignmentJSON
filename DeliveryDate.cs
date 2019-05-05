using System;
using System.Runtime.Serialization;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignement
    
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
