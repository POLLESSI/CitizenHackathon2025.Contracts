namespace CitizenHackathon2025.Contracts.Hubs
{
    public static class EmergencyAlertHubMethods
    {
        public const string HubPath = "/emergencyAlertHub";
        public const string AlertUpserted = "EmergencyAlertUpserted";
        public const string AlertCancelled = "EmergencyAlertCancelled";
        public const string RouteSafetyChanged = "RouteSafetyChanged";
        public const string NearbyCriticalAlert = "NearbyCriticalAlert";
        public const string SubscribeAll = nameof(SubscribeAll);
        public const string UnsubscribeAll = nameof(UnsubscribeAll);
        public const string SubscribeProvince = nameof(SubscribeProvince);
        public const string UnsubscribeProvince = nameof(UnsubscribeProvince);
        public const string SubscribeMunicipality = nameof(SubscribeMunicipality);
        public const string UnsubscribeMunicipality = nameof(UnsubscribeMunicipality);
        public const string EmergencyAlertUpserted = nameof(EmergencyAlertUpserted);
        public const string EmergencyAlertCancelled = nameof(EmergencyAlertCancelled);
        public const string EmergencyAlertExpired = nameof(EmergencyAlertExpired);
        public const string EmergencyAlertsRefreshed = nameof(EmergencyAlertsRefreshed);
        public static string AllGroup => "emergency:all";

        public static class ToClient
        {
            public const string Upserted = nameof(IEmergencyAlertHubClient.EmergencyAlertUpserted);
            public const string Cancelled = nameof(IEmergencyAlertHubClient.EmergencyAlertCancelled);
            public const string Expired = nameof(IEmergencyAlertHubClient.EmergencyAlertExpired);
            public const string Refreshed = nameof(IEmergencyAlertHubClient.EmergencyAlertsRefreshed);
        }
        public static string ProvinceGroup(string provinceCode)
        {
            return $"emergency:province:{Normalize(provinceCode)}";
        }
        public static string MunicipalityGroup(string municipalityCode)
        {
            return $"emergency:municipality:{Normalize(municipalityCode)}";
        }
        private static string Normalize(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Group code cannot be empty.", nameof(value));
            }

            value = value.Trim().ToUpperInvariant();

            if (value.Length > 32)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Group code cannot exceed 32 characters.");
            }

            if (!value.All(c => char.IsLetterOrDigit(c) || c == '-' || c == '_'))
            {
                throw new ArgumentException("Group code contains invalid characters.", nameof(value));
            }

            return value;
        }
    }
}


















































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.