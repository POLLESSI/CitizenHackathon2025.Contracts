// CitizenHackathon2025.Contracts/Hubs/HubPaths.cs
namespace CitizenHackathon2025.Contracts.Hubs
{
    /// <summary>
    /// Client-side hub URLs: *relative* path after "/hubs".
    /// Used by Blazor to build "https://host/hubs/xxx".
    /// </summary>
    public static class HubPaths
    {
        // Crowd / affluence
        public const string CrowdInfo = "crowdHub";          // => /hubs/crowdHub

        // Events
        public const string Event = "eventHub";            // => /hubs/events

        // GPT interactions
        public const string GptInteraction = "gptHub"; // => /hubs/gptInteractionHub

        // Messages (If you have a dedicated MessageHub / NotificationHub, adapt the name)
        public const string Message = "messageHub";        // => /hubs/messageHub

        // OutZen global
        public const string OutZen = "outzen";            // => /hubs/outzen

        // Place (PlaceHub)
        public const string Place = "placeHub";          // => /hubs/placeHub

        // Suggestions / tourisme
        public const string Suggestion = "suggestionHub";     // => /hubs/suggestionHub

        // Trafic
        public const string TrafficCondition = "trafficHub";        // => /hubs/trafficHub

        // Users
        public const string User = "userHub";           // => /hubs/userHub

        // Weather report
        public const string WeatherForecast = WeatherForecastHubMethods.HubPath; // "weatherforecastHub"

    }
}
