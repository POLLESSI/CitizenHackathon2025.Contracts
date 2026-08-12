namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class RiskZoneDTO
    {
        public string ZoneName { get; set; } = "";
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int RiskScore { get; set; }
        public byte Severity { get; set; }
        public int ActiveConnections { get; set; }
        public bool HasCrowdRisk { get; set; }
        public bool HasWeatherRisk { get; set; }
        public bool HasTrafficRisk { get; set; }
        public bool HasEventRisk { get; set; }
        public bool HasCitizenReports { get; set; }
        public string Recommendation { get; set; } = "";
        public bool HasOfficialEmergencyRisk { get; set; }
        public string? EmergencySourceCode { get; set; }
        public IReadOnlyList<Guid> EmergencyAlertIds { get; set; } = Array.Empty<Guid>();
        public string? OfficialInstruction { get; set; }
    }
}


























































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.