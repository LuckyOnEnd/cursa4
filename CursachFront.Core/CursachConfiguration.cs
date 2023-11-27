using CursachFront.Core.Models;
using Newtonsoft.Json;

namespace CursachFront.Core;

public class CursachConfiguration
{
    public List<AppUser> AppUsers = new();
    public List<Prisoner> Prisoners = new();
    
    public static CursachConfiguration LoadFromFile(string fileName)
    {
        try
        {
            return JsonConvert.DeserializeObject<CursachConfiguration>(File.ReadAllText(fileName));
        }
        catch(Exception ex)
        {
            return new CursachConfiguration();
        }
    }
    
    public void SaveToFile(string fileName)
    {
        File.WriteAllText(fileName, JsonConvert.SerializeObject(this));
    }
}