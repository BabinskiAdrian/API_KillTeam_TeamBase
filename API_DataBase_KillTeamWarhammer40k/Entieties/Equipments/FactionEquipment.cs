using API_DataBase_KillTeamWarhammer40k.Entieties.Interfaces;
using API_DataBase_KillTeamWarhammer40k.Entieties.Team;

namespace API_DataBase_KillTeamWarhammer40k.Entieties.Equipments
{
    public class FactionEquipment : IBaseInterface
    {
        // private key
        public int Id { get; set; }


        // properties
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdate { get; set; }


        // foreign key
        public int KillTeamId { get; set; }
        public KillTeam KillTeam { get; set; }
    }
}
