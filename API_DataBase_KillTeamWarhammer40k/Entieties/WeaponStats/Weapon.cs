using API_DataBase_KillTeamWarhammer40k.Entieties.Interfaces;
using API_DataBase_KillTeamWarhammer40k.Entieties.Operatives;
using Microsoft.AspNetCore.Http;

namespace API_DataBase_KillTeamWarhammer40k.Entieties.WeaponStats
{
    public class Weapon_Old : IBaseInterface
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
        // public string Wr { get; set; } //pędzlowane później w dto a nie w bazie danych
        //List<string> wr;
        //foreach(string ability in wr)
        //{
        //    ability
        //}

        public DateTime LastUpdate { get; set; }
        // foreign key
        public ICollection<WeaponAbility> WeaponAbilities { get; set; } = new List<WeaponAbility>();  // Relacja wiele-do-wielu
        // unidirectional, from Operative
    }
}
