using API_DataBase_KillTeamWarhammer40k.Entieties.Interfaces;
using API_DataBase_KillTeamWarhammer40k.Entieties.Operatives;
using Microsoft.AspNetCore.Http;

namespace API_DataBase_KillTeamWarhammer40k.Entieties.WeaponStats
{
    public class Weapon : IBaseInterface
    {
        // private key
        public int Id { get; set; }


        // Filds
        public bool IsRange { get; set; }
        public string Name { get; set; }
        public int Atk { get; set; }
        public int Hit { get; set; }
        public int DmgNormal { get; set; }
        public int DmgCrit { get; set; }
        public string Wr { get; set; } // wypisane po przecinku
        public DateTime LastUpdate { get; set; }


        // foreign key
        public ICollection<Operative> Operatives { get; set; } = new List<Operative>();
        // bez klucza Id
        // możliwość odnoszenia się z aktualnej klasy do pól WeaponAbilityDescription w kodzie 
        public ICollection<WeaponAbilityDescription>? WeaponAbilityDescription { get; set; } = new List<WeaponAbilityDescription>();
    }
}
