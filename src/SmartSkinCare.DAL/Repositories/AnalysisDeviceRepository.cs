using System;
using SmartSkinCare.DAL.Contexts;
using SmartSkinCare.DAL.Models;

namespace SmartSkinCare.DAL.Repositories
{
    public class AnalysisDeviceRepository : BaseRepository<AnalysisDevice, Guid>
    {
        public AnalysisDeviceRepository(SkinCareDbContext context)
            : base(context)
        {
        }
    }
}
