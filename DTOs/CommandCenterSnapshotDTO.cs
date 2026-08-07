namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class CommandCenterSnapshotDTO
    {
        public DateTime GeneratedAtUtc { get; set; } = DateTime.UtcNow;
        public int GlobalRiskScore { get; set; }
        public int CriticalIncidentCount { get; set; }
        public int HighIncidentCount { get; set; }
        public int ModerateIncidentCount { get; set; }
        public int TotalActiveConnections { get; set; }
        public string Summary { get; set; } = "";
    }
}





























































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.