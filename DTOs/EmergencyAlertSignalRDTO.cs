using CitizenHackathon2025.Contracts.Enums;
using CitizenHackathon2025.Contracts.Enums.CitizenHackathon2025.Contracts.Enums;

namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class EmergencyAlertSignalRDTO
    {
        public Guid Id { get; set; }
        public string SourceCode { get; set; } = string.Empty;
        public string ExternalId { get; set; } = string.Empty;
        public EmergencyHazardType HazardType { get; set; }
        public string HazardCode { get; set; } = string.Empty;
        public EmergencySeverity Severity { get; set; }
        public EmergencyUrgency Urgency { get; set; }
        public EmergencyCertainty Certainty { get; set; }
        public EmergencyAlertStatus Status { get; set; }
        public SafetyInformationKind InformationKind { get; set; }
        public string Headline { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? Instructions { get; set; }
        public DateTimeOffset EffectiveFromUtc { get; set; }
        public DateTimeOffset? ExpiresAtUtc { get; set; }
        public DateTimeOffset LastUpdatedAtUtc { get; set; }
        public string? ProvinceCode { get; set; }
        public string? MunicipalityCode { get; set; }

        /// <summary>
        /// Serialized geometry in GeoJSON so that
        /// the Leaflet client can display it.
        /// </summary>
        public string? AreaGeoJson { get; set; }
        public double? RadiusMeters { get; set; }
        public string? OfficialInformationUri { get; set; }
        public bool IsOfficial { get; set; }
    }
}

































































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.