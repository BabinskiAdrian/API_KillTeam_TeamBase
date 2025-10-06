using API_DataBase_KillTeamWarhammer40k.Entieties.Equipments;
using API_DataBase_KillTeamWarhammer40k.Entieties.Interfaces;
using API_DataBase_KillTeamWarhammer40k.Entieties.Operatives;
using API_DataBase_KillTeamWarhammer40k.Entieties.Ploys;
using API_DataBase_KillTeamWarhammer40k.Entieties.Team;
using API_DataBase_KillTeamWarhammer40k.Entieties.WeaponStats;
using Microsoft.EntityFrameworkCore;

namespace API_DataBase_KillTeamWarhammer40k.Entieties
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {
        }

        public DbSet<FactionEquipment> FactionEquipment { get; set; }
        public DbSet<UniversalEquipment> UniversalEquipment { get; set; }

        public DbSet<Operative> Operative { get; set; }
        public DbSet<OperativeAbility> OperativeAbility { get; set; }

        public DbSet<FirefightPloy> FirefightPloy { get; set; }
        public DbSet<StrategyPloy> StrategyPloy { get; set; }

        public DbSet<FactionRule> FactionRule { get; set; }
        public DbSet<KillTeam> KillTeam { get; set; }

        public DbSet<Weapon> Weapon { get; set; }
        public DbSet<WeaponAbility> WeaponAbility { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker
            .Entries<IBaseInterface>() // zakładam, że IBaseInterface ma LastUpdate
            .Where(e => (e.State == EntityState.Modified || e.State == EntityState.Added));

            foreach (var entry in entries)
            {
                entry.Entity.LastUpdate = DateTime.UtcNow;
            }

            return base.SaveChanges();
        }
    }
}
