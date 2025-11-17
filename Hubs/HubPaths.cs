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
        public const string CrowdInfo = "/crowdHub";          // => /hubs/crowdHub

        // Events
        public const string Event = "/events";            // => /hubs/events

        // Suggestions / tourisme
        public const string Suggestion = "/suggestionHub";     // => /hubs/suggestionHub

        // Météo
        public const string WeatherForecast = "/weatherforecastHub";// => /hubs/weatherforecastHub

        // Trafic
        public const string TrafficCondition = "/trafficHub";        // => /hubs/trafficHub

        // OutZen global
        public const string OutZen = "/outzen";            // => /hubs/outzen

        // Utilisateurs
        public const string User = "/userHub";           // => /hubs/userHub

        // GPT interactions
        public const string GptInteraction = "/gptInteractionHub"; // => /hubs/gptInteractionHub

        // Messages (si tu as un MessageHub / NotificationHub dédié, adapte le nom)
        public const string Message = "/messageHub";        // => /hubs/messageHub

        // Lieux (PlaceHub)
        public const string Place = "/placeHub";          // => /hubs/placeHub
    }
}
