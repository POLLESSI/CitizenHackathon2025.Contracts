// CitizenHackathon2025.Contracts/Hubs/HubPaths.cs
namespace CitizenHackathon2025.Contracts.Hubs
{
    /// <summary>
    /// Client-side hub URLs (path part AFTER "/hubs").
    /// Used by Blazor to build "https://host/hubs/xxx".
    /// </summary>
    public static class HubPaths
    {
        // Crowd / affluence
        public const string CrowdInfo = "/hubs/crowdHub";          // => /hubs/crowdHub

        // Events
        public const string Event = "/hubs/eventHub";            // => /hubs/events

        // GPT interactions
        public const string GptInteraction = "/hubs/gptHub"; // => /hubs/gptInteractionHub

        // Messages (If you have a dedicated MessageHub / NotificationHub, adapt the name)
        public const string Message = "/hubs/messageHub";        // => /hubs/messageHub

        // OutZen global
        public const string OutZen = "/hubs/outzen";            // => /hubs/outzen

        // Place (PlaceHub)
        public const string Place = "/hubs/placeHub";          // => /hubs/placeHub

        // Suggestions / tourisme
        public const string Suggestion = "/hubs/suggestionHub";     // => /hubs/suggestionHub

        // Trafic
        public const string TrafficCondition = "/hubs/trafficHub";        // => /hubs/trafficHub

        // Users
        public const string User = "/hubs/userHub";           // => /hubs/userHub

        // Weather report
        public const string WeatherForecast = "/hubs/weatherforecastHub";// => /hubs/weatherforecastHub

    }
}
