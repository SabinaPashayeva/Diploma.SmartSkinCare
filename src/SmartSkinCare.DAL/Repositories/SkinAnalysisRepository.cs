using System;
using SmartSkinCare.DAL.Contexts;
using SmartSkinCare.DAL.Models;

namespace SmartSkinCare.DAL.Repositories
{
    public class SkinAnalysisRepository : BaseRepository<SkinAnalysis, Guid>
    {
        public SkinAnalysisRepository(SkinCareDbContext context)
            : base(context)
        {
        }
    }
}
