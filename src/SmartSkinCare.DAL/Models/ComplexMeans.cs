using System;

namespace SmartSkinCare.DAL.Models
{
    public class ComplexMeans
    {
        public Guid RecommendedComplexId { get; set; }

        public RecommendedComplex RecommendedComplex { get; set; }


        public Guid CareProductId { get; set; }

        public CareProduct CareProduct { get; set; }


        public string Comment { get; set; }

        public int Mark { get; set; }
    }
}
