using CitizenHackathon2025.Contracts.DTOs;

namespace CitizenHackathon2025.Contracts.Hubs
{
    public interface IEmergencyAlertHubClient
    {
        Task EmergencyAlertUpserted(EmergencyAlertSignalRDTO alert);
        Task EmergencyAlertCancelled(Guid alertId, string sourceCode, string externalId);
        Task EmergencyAlertExpired(Guid alertId, string sourceCode, string externalId);
        Task EmergencyAlertsRefreshed(EmergencyAlertRefreshDTO refresh);
    }
}
































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.