using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProprtyTypes
{
    public class ClientAddress
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public string FullAddress
        {
            get
            {
                return $"{StreetAddress} {City} {State} {ZipCode}";
            }
             
        }

       
    }
}
