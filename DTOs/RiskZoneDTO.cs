namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class RiskZoneDTO
    {
        public string ZoneName { get; set; } = "Unknown zone";

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public int RiskScore { get; set; }
        public byte Severity { get; set; }

        public int EstimatedPopulation { get; set; }

        public string Status { get; set; } = "PendingValidation";
    }
}


























































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.