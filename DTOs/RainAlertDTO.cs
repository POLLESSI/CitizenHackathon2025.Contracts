namespace CitizenHackathon2025.Contracts.DTOs
{
    public class RainAlertDTO
    {
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }

        public double Total1h { get; set; }
        public double Total72h { get; set; }

        public string Message { get; set; } = "";
        public bool IsNearSensitiveArea { get; set; }
        public string? SensitiveAreaName { get; set; }
    }

}










































































































/*// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025V5.Blazor.Client. All rights reserved.*/