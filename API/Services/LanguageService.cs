using Messages;
using Monitoring;

namespace API.Services;

public class LanguageService
{
    private static LanguageService? _instance;
    
    public static LanguageService Instance
    {
        get { return _instance ??= new LanguageService(); }
    }
    
    private LanguageService()
    { }
    
    public LanguageResponse GetLanguages()
    {
        MonitorService.Log.Debug("Getting languages");
        return new LanguageResponse
        {
            Languages = GreetingService.Instance.GetLanguages()
        };
    }
}