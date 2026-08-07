namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class EmergencyAlertRefreshDTO
    {
        public string SourceCode { get; set; } = string.Empty;
        public int ActiveAlertCount { get; set; }
        public DateTimeOffset RefreshedAtUtc { get; set; }
    }
}
