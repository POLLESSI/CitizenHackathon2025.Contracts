namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class GptResponseChunkDto
    {
        public int InteractionId { get; init; }
        public string RequestId { get; init; } = string.Empty;
        public string Chunk { get; init; } = string.Empty;
        public bool IsFinal { get; init; }
    }
}











































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.