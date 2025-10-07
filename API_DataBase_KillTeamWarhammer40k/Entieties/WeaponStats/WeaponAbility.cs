using API_DataBase_KillTeamWarhammer40k.Entieties.Interfaces;

namespace API_DataBase_KillTeamWarhammer40k.Entieties.WeaponStats
{
    public class WeaponAbility : IBaseInterface
    {
        // private key
        public int Id { get; set; }


        // Filds
        public int? ValueBeforeName{ get; set; }  //nullable
        public int? ValueAfterName { get; set; }  //nullable
        public DateTime LastUpdate { get; set; }


        // foreign key
        // unidirectional, from Weapon
        public int? WeaponAbilityDescriptionId { get; set; } // foreign key
        public WeaponAbilityDescription? WeaponAbilityDescription { get; set; }
    }
}
