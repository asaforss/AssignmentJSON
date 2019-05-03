using System;
using System.Runtime.Serialization;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement
{
    [DataContract()]
    public class DeliveryDate
    {
        [DataMember]
        private string postalCode;
        [DataMember]
        private DateTime deliveryDate;
        //[DataMember]
        //private bool isGreenDelivery;
        public string PostalCode { get { return postalCode; } }
           
        public DateTime DDate { get { return deliveryDate; } }
        //public bool IsGreenDelivery { get { return isGreenDelivery; } }
    }
}
