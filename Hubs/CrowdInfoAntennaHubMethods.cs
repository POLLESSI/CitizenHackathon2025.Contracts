namespace CitizenHackathon2025.Contracts.Hubs
{
    /// <summary>
    /// Hub path + method names for CrowdInfoAntennaHub (avoid magic strings).
    /// </summary>
    public static class CrowdInfoAntennaHubMethods
    {
        public const string HubPath = "crowdinfo-antenna";

        // Groups
        public static string AntennaGroup(int antennaId) => $"antenna:{antennaId}";

        public static class ToClient
        {
            // payload: CrowdInfoAntennaDTO
            public const string AntennaUpserted = "AntennaUpserted";

            // payload: int antennaId
            public const string AntennaArchived = "AntennaArchived";
        }

        public static class FromClient
        {
            // signature: Task JoinAntenna(int antennaId)
            public const string JoinAntenna = "JoinAntenna";

            // signature: Task LeaveAntenna(int antennaId)
            public const string LeaveAntenna = "LeaveAntenna";
        }
    }
}













































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025V5.Blazor.Client. All rights reserved.