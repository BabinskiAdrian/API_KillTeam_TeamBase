using API_DataBase_KillTeamWarhammer40k.Entieties.Interfaces;

namespace API_DataBase_KillTeamWarhammer40k.Entieties.Operatives
{
    public class OperativeAbility : IBaseInterface
    {
        // private key
        public int Id { get; set; }


        // properties
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdate { get; set; }


        public int OperativeId { get; set; }
    }
}
