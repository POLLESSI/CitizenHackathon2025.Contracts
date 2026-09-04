namespace CitizenHackathon2025.Contracts.DTOs.GeoPortal
{
    public sealed record GeoPortalFeedSnapshotDto
    {
        public bool IsSuccess { get; init; }
        public bool HasErrors { get; init; }
        public bool FromCache { get; init; }
        public bool IsStale { get; init; }
        public DateTimeOffset GeneratedAtUtc { get; init; }
        public DateTimeOffset? LastSuccessfulSyncUtc { get; init; }
        public string? ErrorMessage { get; init; }
        public IReadOnlyList<GeoPortalFeedItemDto> Items { get; init; } = Array.Empty<GeoPortalFeedItemDto>();
        public IReadOnlyList<GeoPortalFeedSourceStatusDto> Sources { get; init; } = Array.Empty<GeoPortalFeedSourceStatusDto>();
    }
}
































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.