using Microsoft.EntityFrameworkCore;
using SmartSkinCare.DAL.Models;

namespace SmartSkinCare.DAL.Contexts
{
    public class SkinCareDbContext : DbContext
    {
        public SkinCareDbContext(DbContextOptions<SkinCareDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SkinAnalysisResult>()
                .HasKey(r => new { r.SkinAnysisId, r.AnalysisDeviceId });

            modelBuilder.Entity<UserSkinDefect>()
                .HasKey(d => new { d.UserId, d.SkinDefectId });

            modelBuilder.Entity<UserCareProduct>()
                .HasKey(p => new { p.UserId, p.CareProductId });

            modelBuilder.Entity<ComplexMeans>()
                .HasKey(c => new { c.RecommendedComplexId, c.CareProductId });

            modelBuilder.Entity<TreatableDefect>()
                .HasKey(t => new { t.CareProductId, t.SkinDefectId });
        }
    }
}
