using LightsOut.Services.Data.TableEntity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LightsOut.Services.Data
{
    public class LightsOutDbContext : DbContext
    {
        //public LightsOutDbContext() { }
        public LightsOutDbContext(DbContextOptions<LightsOutDbContext> options) : base(options) { }

        public DbSet<LightsOutSetting> LightsOutSettingSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<LightsOutSetting>()
                .HasData(new LightsOutSetting("BoardSize", "5"));
        }

        public void SeedDataInitial()
        {
            if (LightsOutSettingSet.Count() == 0)
            {
                LightsOutSettingSet.Add(new LightsOutSetting("BoardSize", "5"));
                SaveChanges();
            }
        }
    }
}
