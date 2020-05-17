using System;
using SmartSkinCare.DAL.Contexts;
using SmartSkinCare.DAL.Models;

namespace SmartSkinCare.DAL.Repositories
{
    public class UserRepository : BaseRepository<User, Guid>
    {
        public UserRepository(SkinCareDbContext context)
            : base(context)
        {
        }
    }
}
