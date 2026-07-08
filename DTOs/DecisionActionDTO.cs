namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class DecisionActionDTO
    {
        public string ZoneName { get; set; } = "";

        public int RiskScore { get; set; }

        public byte Severity { get; set; }

        public string Priority { get; set; } = "Normal";

        public string ActionType { get; set; } = "";

        public string Message { get; set; } = "";

        public bool RequiresHumanValidation { get; set; }

        public DateTime GeneratedAtUtc { get; set; } = DateTime.UtcNow;
    }
}








































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.