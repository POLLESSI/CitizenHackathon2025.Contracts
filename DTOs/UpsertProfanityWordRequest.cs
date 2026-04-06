namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class UpsertProfanityWordRequest
    {
        public string Word { get; set; } = "";
        public string LanguageCode { get; set; } = "fr";
        public int Weight { get; set; } = 10;
        public bool IsRegex { get; set; }
        public string? Category { get; set; }
        public bool Active { get; set; } = true;
    }
}
