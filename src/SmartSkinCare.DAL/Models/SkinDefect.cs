using System;
using System.Collections.Generic;

namespace SmartSkinCare.DAL.Models
{
    public class SkinDefect
    {
        public Guid SkinDefectId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


        public ICollection<UserSkinDefect> UserSkinDefects { get; set; }
            = new List<UserSkinDefect>();
    }
}
