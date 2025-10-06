using API_DataBase_KillTeamWarhammer40k.Entieties.Interfaces;
using API_DataBase_KillTeamWarhammer40k.Entieties.Operatives;
using API_DataBase_KillTeamWarhammer40k.Entieties.Team;

namespace API_DataBase_KillTeamWarhammer40k.Entieties.Equipments
{
    public class UniversalEquipment : IBaseInterface
    {
        // private key
        public int Id { get; set; }


        // properties
        public string Name { get; set; }
        public DateTime LastUpdate { get; set; }


        // foreign key
    }
}
