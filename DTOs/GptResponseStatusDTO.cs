namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class GptResponseStatusDto
    {
        public int InteractionId { get; init; }
        public string RequestId { get; init; } = string.Empty;
        public string Status { get; init; } = string.Empty;
        public string? Message { get; init; }
        public DateTime TimestampUtc { get; init; }
    }
}


























































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.