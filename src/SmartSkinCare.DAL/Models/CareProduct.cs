using System;
using System.Collections.Generic;

namespace SmartSkinCare.DAL.Models
{
    public class CareProduct
    {
        public Guid CareProductId { get; set; }

        public string Title { get; set; }

        public CareProductType ProductType { get; set; }

        public SkinType? RecommendedSkinType { get; set; }

        public byte? RecommendedMinAge { get; set; }

        public byte? RecommendedMaxAge { get; set; }

        public string Composition { get; set; }

        public double DurationOfUse { get; set; }


        public Guid ManufacturerId { get; set; }

        public Manufacturer Manufacturer { get; set; }


        public ICollection<UserCareProduct> UserCareProducts { get; set; }
            = new List<UserCareProduct>();

        public ICollection<TreatableDefect> TreatableDefects { get; set; }
            = new List<TreatableDefect>();

        public ICollection<ComplexMeans> ComplexMeans { get; set; }
            = new List<ComplexMeans>();
    }
}