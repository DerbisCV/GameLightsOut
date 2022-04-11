using Microsoft.EntityFrameworkCore;
using Solvtio.Models;

namespace Solvtio.Data
{
    public class SolvtioDbContext : DbContext
    {
        //public LightsOutDbContext() { }
        public SolvtioDbContext(DbContextOptions<SolvtioDbContext> options) : base(options) { }

        public DbSet<Configuracion> ConfiguracionSet { get; set; }
        public DbSet<CaracteristicaBase> CaracteristicaBaseSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder
            //    .Entity<LightsOutSetting>()
            //    .HasData(new LightsOutSetting("BoardSize", "5"));
        }

        public void SeedDataInitial()
        {
            //if (LightsOutSettingSet.Count() == 0)
            //{
            //    LightsOutSettingSet.Add(new LightsOutSetting("BoardSize", "5"));
            //    SaveChanges();
            //}
        }
    }
}
