using System;
using SmartSkinCare.DAL.Contexts;
using SmartSkinCare.DAL.Models;

namespace SmartSkinCare.DAL.Repositories
{
    public class ManufacturerRepository : BaseRepository<Manufacturer, Guid>
    {
        public ManufacturerRepository(SkinCareDbContext context)
            : base(context)
        {
        }
    }
}
