namespace CitizenHackathon2025.Contracts.Hubs
{
    /// <summary>
    /// Names and paths used by the EventHub (SignalR).
    /// Single reference on server side (Hubs) and client side (Blazor/TS) to avoid "magic strings".
    /// </summary>
    public static class EventHubMethods
    {
        /// <summary>
        /// Hub path RELATIVE to the "/hubs" group.
        /// In Program.cs: hubs.MapHub<EventHub>(EventHubMethods.HubPath);
        /// => final URL: "/hubs/events"
        /// </summary>
        public const string HubPath = "events";   // ⚠️ plus "/events" ici, juste "events"

        // -------------------------------
        // Calls made by the server to clients
        // (Clients.SendAsync(...))
        // -------------------------------
        public static class ToClient
        {
            /// <summary>
            /// Notify clients that a new event is available or updated.
            /// </summary>
            public const string NewEvent = "NewEvent";

            /// <summary>
            /// Event updated (optional if you want finer-grain notifications).
            /// </summary>
            public const string EventUpdated = "EventUpdated";

            /// <summary>
            /// Event deleted / archived.
            /// </summary>
            public const string EventDeleted = "EventDeleted";
        }

        // -------------------------------
        // Calls made by clients to the server
        // (hubConnection.InvokeAsync(...))
        // -------------------------------
        public static class FromClient
        {
            /// <summary>
            /// Ask the server to refresh / push events.
            /// Hub signature: Task RefreshEvent(string message)
            /// </summary>
            public const string RefreshEvent = "RefreshEvent";
        }
    }
}




































































/*// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025V5.Blazor.Client. All rights reserved.*/