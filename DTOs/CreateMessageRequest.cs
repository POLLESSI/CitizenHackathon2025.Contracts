namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class CreateMessageRequest
    {
        public string Content { get; set; } = string.Empty;

        public string SourceType { get; set; } = "Other";

        public int? RelatedId { get; set; }

        public string? RelatedName { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }
    }
}
