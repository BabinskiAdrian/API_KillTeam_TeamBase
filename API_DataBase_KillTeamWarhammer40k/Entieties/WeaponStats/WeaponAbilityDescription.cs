namespace API_DataBase_KillTeamWarhammer40k.Entieties.WeaponStats
{
    public class WeaponAbilityDescription
    {
        // private key
        public int Id { get; set; }


        // Filds
        public string Name { get; set; } //non-nullable
        public string Description { get; set; }
        public DateTime LastUpdate { get; set; }


        // foreign key
        // unidirectional, from Weapon
    }
}
