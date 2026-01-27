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

        // Crowd / affluence - Antennas
        public const string CrowdInfoAntenna = CrowdInfoAntennaHubMethods.HubPath; // => /hubs/crowdInfoAntennaHub

        // Crowd / affluence - Antenna connections
        public const string CrowdInfoAntennaConnection = CrowdInfoAntennaConnectionHubMethods.HubPath; // => /hubs/crowdInfoAntennaConnectionHub

        // Events
        public const string Event = EventHubMethods.HubPath;         // => /hubs/events

        // GPT interactions
        public const string GptInteraction = GptInteractionHubMethods.HubPath; // => /hubs/gptInteractionHub

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
        // Antennas
        public const string Antenna = CrowdInfoAntennaHubMethods.HubPath;
        // Antenna connections
        public const string AntennaConnection = CrowdInfoAntennaConnectionHubMethods.HubPath;
        // IA
        public const string AISuggestion = AISuggestionHubMethods.HubPath;

    }
}

























































































/*// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025V5.Blazor.Client. All rights reserved.*/