namespace CitizenHackathon2025.Contracts.Hubs
{
    public static class NotificationHubMethods
    {
        // ✅ bsolute hub path
        public const string HubPath = "/hubs/notificationHub";

        public static class ToClient
        {
            // xample: adapt to your real events
            public const string ReceiveNotification = "ReceiveNotification";
            public const string ReceiveNotificationBatch = "ReceiveNotificationBatch";
        }

        public static class FromClient
        {
            public const string Ping = "Ping";
            public const string Subscribe = "Subscribe";
            public const string Unsubscribe = "Unsubscribe";
        }
    }
}
