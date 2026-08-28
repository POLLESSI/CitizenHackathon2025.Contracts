namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class LocalAiUserReportContextDTO
    {
        public int Id { get; set; }
        public string Content { get; set; } = "";
        public string? SourceType { get; set; }
        public string? RelatedName { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public DateTime CreatedAt { get; set; }
        public double? DistanceKm { get; set; }
    }
}






































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.