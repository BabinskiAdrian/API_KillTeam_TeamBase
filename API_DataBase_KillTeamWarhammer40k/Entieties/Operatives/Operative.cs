using API_DataBase_KillTeamWarhammer40k.Entieties.Interfaces;
using API_DataBase_KillTeamWarhammer40k.Entieties.Team;
using API_DataBase_KillTeamWarhammer40k.Entieties.WeaponStats;

namespace API_DataBase_KillTeamWarhammer40k.Entieties.Operatives
{
    public class Operative : IBaseInterface
    {
        // private key
        public int Id { get; set; }


        // properties
        public string Name { get; set; }
        public int Apl { get; set; }
        public int Move { get; set; }
        public int Save { get; set; }
        public int Wounds { get; set; }
        public string WeaponsName { get; set; } // wypisać po przecinku
        public DateTime LastUpdate { get; set; }


        // foreign key
        public ICollection<Weapon> Weapons { get; set; } = new List<Weapon>(); 
        public ICollection<OperativeAbility>? OperativeAbilities { get; set; } = new List<OperativeAbility>();

        // Relacja jeden-do-jednego
        public int KillTeamId { get; set; }
        public KillTeam KillTeam { get; set; }
    }
}
