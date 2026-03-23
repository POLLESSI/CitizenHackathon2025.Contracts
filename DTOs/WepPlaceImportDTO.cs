namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class WepPlaceImportDTO
    {
        public string ExternalId { get; set; } = "";
        public string Name { get; set; } = "";
        public string? Type { get; set; }
        public bool? Indoor { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int? Capacity { get; set; }
        public string? Tag { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime? SourceUpdatedAtUtc { get; set; }
    }
}
