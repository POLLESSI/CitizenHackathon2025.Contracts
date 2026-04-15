namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class GptStartResponseDto
    {
        public bool Accepted { get; set; }
        public int InteractionId { get; set; }
        public string RequestId { get; set; } = string.Empty;
        public DateTime StartedAtUtc { get; set; }
        public string Status { get; set; } = "started";
        public string? Message { get; set; }
    }
}
