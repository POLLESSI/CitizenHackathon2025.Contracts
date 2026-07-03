namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class CrowdAlertCluster
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string ZoneName { get; set; } = "Unknown zone";

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public byte Severity { get; set; }

        public int RiskScore { get; set; }

        public int TotalActiveConnections { get; set; }
        public int TotalUniqueDevices { get; set; }

        public int EstimatedPopulation { get; set; }

        public int AntennaCount { get; set; }

        public List<int> AntennaIds { get; set; } = new();
        public List<long> AlertIds { get; set; } = new();

        public DateTime FirstDetectedAtUtc { get; set; }
        public DateTime LastDetectedAtUtc { get; set; }

        public string Status { get; set; } = "PendingValidation";

        public string Message { get; set; } = "";
    }
}












































































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.