using System;

namespace SmartSkinCare.DAL.Models
{
    public class UserCareProduct
    {
        public Guid UserId { get; set; }

        public User User { get; set; }


        public Guid CareProductId { get; set; }

        public CareProduct CareProduct { get; set; }


        public string CustomTitle { get; set; }

        public string Comment { get; set; }

        public int Mark { get; set; }
    }
}
