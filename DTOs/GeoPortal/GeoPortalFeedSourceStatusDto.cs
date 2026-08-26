namespace CitizenHackathon2025.Contracts.DTOs.GeoPortal
{
    public sealed record GeoPortalFeedSourceStatusDto
    {
        public string SourceCode { get; init; } = string.Empty;
        public string SourceName { get; init; } = string.Empty;
        public bool IsSuccess { get; init; }
        public bool IsStale { get; init; }
        public int ItemCount { get; init; }
        public DateTimeOffset? LastSuccessfulSyncUtc { get; init; }
        public string? ErrorMessage { get; init; }
    }
}




























































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.