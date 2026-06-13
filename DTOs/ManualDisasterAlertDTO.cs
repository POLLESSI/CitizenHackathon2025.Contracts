using CitizenHackathon2025.Contracts.Enums;

namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class ManualDisasterAlertDTO
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string? PlaceName { get; set; }
        public DisasterType DisasterType { get; set; } = DisasterType.Other;
        public byte Severity { get; set; } = 4;
        public string? Description { get; set; }
        public string? DeviceId { get; set; }
    }
}



















































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.