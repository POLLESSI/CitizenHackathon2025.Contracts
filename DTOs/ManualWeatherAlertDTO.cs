using CitizenHackathon2025.Contracts.Enums;

namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class ManualWeatherAlertDTO
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public WeatherType WeatherType { get; set; }

        public SeverityLevel Severity { get; set; }

        public string Description { get; set; } = "";
    }
}
