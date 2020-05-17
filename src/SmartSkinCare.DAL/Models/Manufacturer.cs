using System;
using System.Collections.Generic;

namespace SmartSkinCare.DAL.Models
{
    public class Manufacturer
    {
        public Guid ManufacturerId { get; set; }

        public string Name { get; set; }

        public string CountryCode { get; set; }


        public ICollection<CareProduct> CareProducts { get; set; }
            = new List<CareProduct>();
    }
}
