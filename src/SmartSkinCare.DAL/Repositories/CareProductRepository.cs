using System;
using SmartSkinCare.DAL.Contexts;
using SmartSkinCare.DAL.Models;

namespace SmartSkinCare.DAL.Repositories
{
    public class CareProductRepository : BaseRepository<CareProduct, Guid>
    {
        public CareProductRepository(SkinCareDbContext context)
            : base(context)
        {
        }
    }
}
