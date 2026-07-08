namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class PredictionDTO
    {
        public string ZoneName { get; set; } = "";
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public int CurrentRiskScore { get; set; }

        public int PredictedRiskScore15Min { get; set; }

        public int PredictedRiskScore30Min { get; set; }

        public bool SaturationLikely { get; set; }

        public string Explanation { get; set; } = "";
    }
}






























































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.