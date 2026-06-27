namespace CitizenHackathon2025.Contracts.DTOs
{
    public class CrowdInfoDTO
    {
    #nullable disable
        public int Id { get; set; }
        public string LocationName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int CrowdLevel { get; set; }
        public DateTime Timestamp { get; set; }

        public bool IsManualCriticalAlert { get; set; }
        public DateTime? ExpiresAtUtc { get; set; }
        public string? Source { get; set; }
        public string? Reason { get; set; }

    }
}























































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.