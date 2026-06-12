using CitizenHackathon2025.Contracts.Enums;

namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class ManualTrafficAlertDTO
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public TrafficLevel TrafficLevel { get; set; } = TrafficLevel.Jammed;
        public string IncidentType { get; set; } = "Critical congestion";
        public string Description { get; set; } = "";
        public string? DeviceId { get; set; }
    }
}




























































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.