using System.ComponentModel.DataAnnotations;

namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class CreateMessageRequest
    {
        public Guid ClientRequestId { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(2_000)]
        public string Content { get; set; } = string.Empty;

        [MaxLength(32)]
        public string SourceType { get; set; } = "Other";

        public int? RelatedId { get; set; }

        [MaxLength(256)]
        public string? RelatedName { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }
    }
}

















































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.