using API_DataBase_KillTeamWarhammer40k.Entieties.Interfaces;
using API_DataBase_KillTeamWarhammer40k.Entieties.Team;

namespace API_DataBase_KillTeamWarhammer40k.Entieties.Ploys
{
    public class StrategyPloy : IBaseInterface
    {
        // private key
        public int Id { get; set; }


        // properties
        public string Name { get; set; }
        public DateTime LastUpdate { get; set; }


        // foreign key
        public int KillTeamId { get; set; }
        public KillTeam KillTeam { get; set; }
    }
}
