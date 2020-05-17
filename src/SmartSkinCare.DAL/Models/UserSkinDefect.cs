using System;

namespace SmartSkinCare.DAL.Models
{
    public class UserSkinDefect
    {
        public Guid UserId { get; set; }

        public User User { get; set; }


        public Guid SkinDefectId { get; set; }

        public SkinDefect SkinDefect { get; set; }
    }
}
