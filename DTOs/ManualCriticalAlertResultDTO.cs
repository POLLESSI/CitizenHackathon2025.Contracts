namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class ManualCriticalAlertResultDTO
    {
        public bool Ok { get; set; }
        public string? Error { get; set; }
        public string Status { get; set; } = "Pending";
        public int ConfirmationCount { get; set; }
        public int RequiredCount { get; set; }
        public DateTime? ExpiresAtUtc { get; set; }
        public int? CrowdInfoId { get; set; }
    }
}

















































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.