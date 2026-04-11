namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class WepEventImportDTO
    {
        public string ExternalId { get; set; } = "";
        public string? PlaceExternalId { get; set; }
        public string Name { get; set; } = "";
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public DateTime DateEvent { get; set; }
        public int? ExpectedCrowd { get; set; }
        public bool? IsOutdoor { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime? SourceUpdatedAtUtc { get; set; }
    }
}

















































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.