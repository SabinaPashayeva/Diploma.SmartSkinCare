using System;
using SmartSkinCare.DAL.Contexts;
using SmartSkinCare.DAL.Models;

namespace SmartSkinCare.DAL.Repositories
{
    public class RecommendedComplexRepository : BaseRepository<RecommendedComplex, Guid>
    {
        public RecommendedComplexRepository(SkinCareDbContext context)
            : base(context)
        {
        }
    }
}
