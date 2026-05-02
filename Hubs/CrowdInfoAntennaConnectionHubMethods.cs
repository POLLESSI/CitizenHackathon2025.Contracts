namespace CitizenHackathon2025.Contracts.Hubs
{
    /// <summary>
    /// Hub path + method names for CrowdInfoAntennaConnectionHub (avoid magic strings).
    /// </summary>
    public static class CrowdInfoAntennaConnectionHubMethods
    {
        public const string HubPath = "crowdInfoAntennaConnectionHub";

        // Groups
        public static string AntennaGroup(int antennaId) => $"antenna:{antennaId}";
        public static string EventGroup(int eventId) => $"event:{eventId}";

        public static class ToClient
        {
            // payload: { antennaId, counts: AntennaCountsDTO }
            public const string AntennaCountsUpdated = "AntennaCountsUpdated";

            // payload: EventAntennaCrowdDTO (event -> nearest antenna -> counts)
            public const string EventCrowdUpdated = "EventCrowdUpdated";
        }

        public static class FromClient
        {
            // signature: Task JoinAntenna(int antennaId)
            public const string JoinAntenna = "JoinAntenna";

            public const string JoinAntennas = "JoinAntennas";

            // signature: Task LeaveAntenna(int antennaId)
            public const string LeaveAntenna = "LeaveAntenna";

            // signature: Task JoinEvent(int eventId)
            public const string JoinEvent = "JoinEvent";

            // signature: Task LeaveEvent(int eventId)
            public const string LeaveEvent = "LeaveEvent";

            public const string RequestEventCrowd = "RequestEventCrowd";

            // signature: Task Ping(int antennaId, string? deviceIdBase64OrPlain = null)  (optionnel)
            public const string Ping = "Ping";
        }
    }
}












































































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025V5.Blazor.Client. All rights reserved.