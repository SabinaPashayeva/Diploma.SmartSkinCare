using System;
using System.Collections.Generic;

namespace SmartSkinCare.DAL.Models
{
    public class RecommendedComplex
    {
        public Guid RecommendedComplexId { get; set; }

        public DateTimeOffset GenerationTime { get; set; }

        public double DurationOfUse { get; set; }


        public Guid UserId { get; set; }

        public User User { get; set; }


        public ICollection<ComplexMeans> ComplexMeans { get; set; }
            = new List<ComplexMeans>();
    }
}
