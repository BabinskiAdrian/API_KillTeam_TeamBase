using API_DataBase_KillTeamWarhammer40k.Entieties;
using API_DataBase_KillTeamWarhammer40k.Entieties.WeaponStats;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace API_DataBase_KillTeamWarhammer40k.SeedData
{
    public class SeederKillTeamLegionaries
    {
        internal readonly MainDbContext _dbContext; 

        public SeederKillTeamLegionaries(MainDbContext dbContext) //Wstrzykiwanie zależności
        {
            _dbContext = dbContext;
        }

        public void SeedKillTeamLegionaries()
        {
            if (_dbContext.Database.CanConnect())
            {
                // Sprawdzanie migracji
                var pendingMigrations = _dbContext.Database.GetPendingMigrations();
                // Sprawdzenie czy jest jakakolwiek && czy jest jakaś oczekjąca migracja
                if (pendingMigrations != null && pendingMigrations.Any())
                {
                    _dbContext.Database.Migrate(); // Wykonanie migracji, jeśli są jakieś oczekujące
                }


                GenericAddRange<Weapon>();
                //GenericAddRange<Weapon>();
                //GenericAddRange<WeaponAbility>();
                //GenericAddRange<WeaponAbility>();
                //GenericAddRange<WeaponAbility>();

            }


        }

        // fajne, dodanie where T : class -> oznacza że typ generyczny musi być klasą
        private void GenericAddRange<T>() where T : class
        {
            if (_dbContext.Set<T>().Any())
            {
                return;
            }


            // Pobranie nazwy typu T (zawsze plik .cs i .json muszą mieć taką samą nazwę)
            string fileName = typeof(T).Name;
            // Ścieżka do pliku JSON (działa na każdej maszynie)
            var jsonFilePath = Path.Combine(AppContext.BaseDirectory, "SeedData", "Legionaries", $"{fileName}.json");

            // Sprawdzenie czy plik na pewno istnieje
            if (!File.Exists(jsonFilePath))
            {
                throw new FileNotFoundException($"Nie znaleziono pliku seedera: {jsonFilePath}");
            }


            var json = File.ReadAllText("SeedData/Legionaries/WeaponAbilities.json");   // Tworzenie listy z wartościami = resjestry w tabeli
            var a = JsonSerializer.Deserialize<List<T>>(json)!;                         // Deserializacja JSON do listy obiektów WeaponAbility


            _dbContext.Set<T>().AddRange(a);
            _dbContext.SaveChanges();
        }
    }
}

/*
public void SeedKillTeamLegionaries()
{
    // Sprawdzenie czy tabela jest pusta
    if (!_dbContext.WeaponAbilityDbSet.Any())
    {
     // Metoda własna zwraca listę, następnie dodajemy ją do dbContext
        _dbContext.WeaponAbilityDbSet.AddRange(GetWeaponsAbilities());
        _dbContext.SaveChanges();
    }
}

// fajne, dodanie where T : class -> oznacza że typ generyczny musi być klasą
private IEnumerable<T> GenericAddRange<T>() where T : class
{
    // Pobranie nazwy typu T (zawsze plik .cs i .json muszą mieć taką samą nazwę)
    string fileName = typeof(T).Name;


    if (_dbContext.Set<T>().Any()) ; //no i pojawił się problem




    // Ścieżka do pliku JSON (działa na każdej maszynie)
    var jsonFilePath = Path.Combine(AppContext.BaseDirectory, "SeedData", "Legionaries", $"{fileName}.json");

    // Sprawdzenie czy plik na pewno istnieje
    if (!File.Exists(jsonFilePath))
    {
        throw new FileNotFoundException($"Nie znaleziono pliku seedera: {jsonFilePath}");
    }

    // Tworzenie listy z wartościami = resjestry w tabeli
    var json = File.ReadAllText("SeedData/Legionaries/WeaponAbilities.json");

    // Deserializacja JSON do listy obiektów WeaponAbility
    return JsonSerializer.Deserialize<List<T>>(json)!;
}
*/