namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class GptResponseStartedDto
    {
        public int InteractionId { get; init; }
        public string RequestId { get; init; } = string.Empty;
        public DateTime StartedAtUtc { get; init; }
    }
}































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.