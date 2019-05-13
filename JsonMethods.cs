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
    public class JsonMethods
    {
      
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


