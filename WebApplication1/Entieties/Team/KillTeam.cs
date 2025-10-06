using API_DataBase_KillTeamWarhammer40k.Entieties.Equipments;
using API_DataBase_KillTeamWarhammer40k.Entieties.Interfaces;
using API_DataBase_KillTeamWarhammer40k.Entieties.Operatives;
using API_DataBase_KillTeamWarhammer40k.Entieties.Ploys;

namespace API_DataBase_KillTeamWarhammer40k.Entieties.Team
{
    public class KillTeam : IBaseInterface
    {
        // private key
        public int Id { get; set; }


        // properties
        public string Name { get; set; }
        public DateTime LastUpdate { get; set; }


        // foreign key
        public ICollection<Operative> Operatives { get; set; } = new List<Operative>(); // Relacja jeden-do-wielu
        public ICollection<FactionRule> FactionRules { get; set; } = new List<FactionRule>(); // Relacja jeden-do-wielu
        public ICollection<FactionEquipment> FactionEquipments { get; set; } = new List<FactionEquipment>(); // Relacja jeden-do-wielu
        public ICollection<StrategyPloy> StrategyPloys { get; set; } = new List<StrategyPloy>(); // Relacja jeden-do-wielu
        public ICollection<FirefightPloy> FirefightPloys { get; set; } = new List<FirefightPloy>(); // Relacja jeden-do-wielu
    }
}
