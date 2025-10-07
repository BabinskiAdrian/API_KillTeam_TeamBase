namespace API_DataBase_KillTeamWarhammer40k.Entieties.Interfaces
{
    public interface IBaseInterface
    {
        int Id { get; set; }
        DateTime LastUpdate { get; set; }
    }
}

/*
// private key
public int Id { get; set; }


// properties
public string Name { get; set; }
public DateTime LastUpdate { get; set; }

// foreign key
*/