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

        public DbSet<FactionEquipment> FactionEquipmentDbSet { get; set; }
        public DbSet<UniversalEquipment> UniversalEquipmentDbSet { get; set; }

        public DbSet<Operative> OperativeDbSet { get; set; }
        public DbSet<OperativeAbility> OperativeAbilityDbSet { get; set; }

        public DbSet<FirefightPloy> FirefightPloyDbSet { get; set; }
        public DbSet<StrategyPloy> StrategyPloyDbSet { get; set; }

        public DbSet<FactionRule> FactionRuleDbSet { get; set; }
        public DbSet<KillTeam> KillTeamDbSet { get; set; }

        public DbSet<Weapon> WeaponDbSet { get; set; }
        public DbSet<WeaponAbility> WeaponAbilityDbSet { get; set; }


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
