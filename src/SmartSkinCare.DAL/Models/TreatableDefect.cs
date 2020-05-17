using System;

namespace SmartSkinCare.DAL.Models
{
    public class TreatableDefect
    {
        public Guid CareProductId { get; set; }

        public CareProduct CareProduct { get; set; }


        public Guid SkinDefectId { get; set; }

        public SkinDefect SkinDefect { get; set; }
    }
}
