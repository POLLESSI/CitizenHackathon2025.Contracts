namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class AdminMessageQueueDto
    {
        public int QueueId { get; set; }
        public int MessageId { get; set; }
        public string Content { get; set; } = "";
        public string? RelatedName { get; set; }
        public string? SourceType { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string Category { get; set; } = "";
        public byte Priority { get; set; }
        public string Status { get; set; } = "";
        public decimal? Confidence { get; set; }
        public string? ClassificationSource { get; set; }
        public string? AssignedTo { get; set; }
        public string? AdminNote { get; set; }
        public DateTime MessageCreatedAt { get; set; }
        public DateTime QueueCreatedAtUtc { get; set; }
    }
}













































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.