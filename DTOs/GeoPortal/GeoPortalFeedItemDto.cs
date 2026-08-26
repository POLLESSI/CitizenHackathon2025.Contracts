namespace CitizenHackathon2025.Contracts.DTOs.GeoPortal
{
    public sealed record GeoPortalFeedItemDto
    {
        public string Id { get; init; } = string.Empty;
        public string SourceCode { get; init; } = string.Empty;
        public string SourceName { get; init; } = string.Empty;

        /// <summary>
        /// news | agenda
        /// </summary>
        public string FeedKind { get; init; } = string.Empty;
        public string Title { get; init; } = string.Empty;
        public string? Summary { get; init; }
        public string? Url { get; init; }
        public DateTimeOffset? PublishedAtUtc { get; init; }
        public DateOnly? EventStartDate { get; init; }
        public DateOnly? EventEndDate { get; init; }
    }
}




















































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.