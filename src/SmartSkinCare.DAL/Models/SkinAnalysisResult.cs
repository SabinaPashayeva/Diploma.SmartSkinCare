using System;

namespace SmartSkinCare.DAL.Models
{
    public class SkinAnalysisResult
    {
        public Guid SkinAnysisId { get; set; }

        public SkinAnalysis SkinAnalysis { get; set; }


        public Guid AnalysisDeviceId { get; set; }

        public AnalysisDevice AnalysisDevice { get; set; }


        public double AnalysisResult { get; set; }

        public string Measurement { get; set; }
    }
}
