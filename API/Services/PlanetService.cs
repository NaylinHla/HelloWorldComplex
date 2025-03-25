using Monitoring;
namespace API.Services;

public class PlanetService
{
    private static PlanetService? _instance;
    
    public static PlanetService Instance
    {
        get { return _instance ??= new PlanetService(); }
    }
    
    public PlanetResponse GetPlanet()
    {
        using var activity = MonitorService.ActivitySource.StartActivity();
        MonitorService.Log.Debug("Getting planets");
        
        var planets = new[]
        {
            "Mercury",
            "Venus",
            "Earth",
            "Mars",
            "Jupiter",
            "Saturn",
            "Uranus",
            "Neptune"
        };
        
        MonitorService.Log.Debug("Got {planets.Count} planets :)", planets.Count());

        var index = new Random(DateTime.Now.Millisecond).Next(1, planets.Length+1);
        return new PlanetResponse
        {
            Planet = planets[index]
        };
    }
}