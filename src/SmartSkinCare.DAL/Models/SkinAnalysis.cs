using System;
using System.Collections.Generic;

namespace SmartSkinCare.DAL.Models
{
    public class SkinAnalysis
    {
        public Guid SkinAnalysisId { get; set; }

        public DateTimeOffset DateTime { get; set; }


        public Guid UserId { get; set; }

        public User User { get; set; }


        public ICollection<SkinAnalysisResult> SkinAnalysisResults { get; set; }
            = new List<SkinAnalysisResult>();
    }
}
