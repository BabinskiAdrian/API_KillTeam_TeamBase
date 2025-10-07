using API_DataBase_KillTeamWarhammer40k.Entieties.Interfaces;

namespace API_DataBase_KillTeamWarhammer40k.Entieties.WeaponStats
{
    public class WeaponAbility : IBaseInterface
    {
        // private key
        public int Id { get; set; }


        // Filds
        public string Name { get; set; } //non-nullable
        public string? ValueBeforeName{ get; set; }  //nullable
        public string? ValueAfterName { get; set; }  //nullable
        public DateTime LastUpdate { get; set; }


        // foreign key
        public ICollection<Weapon> Weapons { get; set; } = new List<Weapon>();  // Relacja wiele-do-wielupublic
        public int WeaponAbilityDescriptionId { get; set; } // foreign key
        public  WeaponAbilityDescription WeaponAbilityDescription { get; set; }
    }
}
