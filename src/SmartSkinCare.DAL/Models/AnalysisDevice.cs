using System;
using System.Collections.Generic;

namespace SmartSkinCare.DAL.Models
{
    public class AnalysisDevice
    {
        public Guid AnalysisDeviceId { get; set; }

        public string Name { get; set; }

        public DeviceType DeviceType { get; set; }

        public string Measurement { get; set; }


        public Guid UserId { get; set; }

        public User User { get; set; }


        public ICollection<SkinAnalysisResult> SkinAnalysisResults { get; set; }
            = new List<SkinAnalysisResult>();
    }
}
