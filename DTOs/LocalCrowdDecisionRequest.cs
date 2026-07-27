namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class LocalCrowdDecisionRequest
    {
        public string ZoneName { get; set; } = "";
        public int ActiveConnections { get; set; }
        public int UniqueDevices { get; set; }
        public int? BaselineConnections { get; set; }
        public int RiskScore { get; set; }
        public byte Severity { get; set; }
        public bool HasWeatherRisk { get; set; }
        public bool HasTrafficRisk { get; set; }
        public bool HasKnownEvent { get; set; }
    }
}











































































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.