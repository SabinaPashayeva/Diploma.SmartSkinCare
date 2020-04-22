using System;
using System.Collections.Generic;

namespace SmartSkinCare.DAL.Models
{
    public class User
    {
        public Guid UserId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }


        public ICollection<UserCareProduct> UserCareProducts { get; set; }
            = new List<UserCareProduct>();

        public ICollection<UserSkinDefect> UserSkinDefects { get; set; }
            = new List<UserSkinDefect>();

        public ICollection<SkinAnalysis> SkinAnalyses { get; set; }
            = new List<SkinAnalysis>();

        public ICollection<AnalysisDevice> AnalysisDevices { get; set; }
            = new List<AnalysisDevice>();
    }
}
