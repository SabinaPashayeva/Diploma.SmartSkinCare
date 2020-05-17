using System;
using SmartSkinCare.DAL.Contexts;
using SmartSkinCare.DAL.Models;

namespace SmartSkinCare.DAL.Repositories
{
    public class SkinDefectRepository : BaseRepository<SkinDefect, Guid>
    {
        public SkinDefectRepository(SkinCareDbContext context)
            : base(context)
        {
        }
    }
}
