namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class ReplayFrameDTO
    {
        public long Id { get; set; }
        public DateTime CapturedAtUtc { get; set; }
        public CommandCenterSnapshotDTO Snapshot { get; set; } = new();
        public List<CrowdAlertCluster> Incidents { get; set; } = new();
        public List<RiskZoneDTO> RiskZones { get; set; } = new();
    }
}






































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.