namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class DisasterAlertResultDTO
    {
        public bool Ok { get; set; }
        public string Status { get; set; } = "";
        public string? Error { get; set; }

        public int ConfirmationCount { get; set; }
        public int RequiredCount { get; set; }

        public long? DisasterAlertId { get; set; }
        public long? EscalationRequestId { get; set; }

        public DateTime? ExpiresAtUtc { get; set; }
    }
}

























































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.