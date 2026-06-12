namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class TrafficAlertResultDTO
    {
        public bool Ok { get; set; }
        public string Status { get; set; } = "";
        public string? Error { get; set; }
        public DateTime? ExpiresAtUtc { get; set; }
        public int ConfirmationCount { get; set; }
        public int RequiredCount { get; set; }
    }
}