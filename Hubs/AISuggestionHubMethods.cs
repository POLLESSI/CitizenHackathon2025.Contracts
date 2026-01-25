// CitizenHackathon2025.Contracts/Hubs/AISuggestionHubMethods.cs
namespace CitizenHackathon2025.Contracts.Hubs
{
    /// <summary>
    /// SignalR contract for AISuggestionHub.
    /// Centralizes hub path and method names to avoid magic strings.
    /// </summary>
    public static class AISuggestionHubMethods
    {
        /// <summary>
        /// Absolute hub path (used by API + Blazor).
        /// </summary>
        public const string HubPath = "ai-suggestion";

        // =========================
        // Server -> Client
        // =========================
        public static class ToClient
        {
            /// <summary>
            /// A new AI suggestion is available.
            /// Payload: SuggestionDTO / JSON
            /// </summary>
            public const string ReceiveSuggestion = "ReceiveSuggestion";

            /// <summary>
            /// Batch of AI suggestions.
            /// Payload: IEnumerable&lt;SuggestionDTO&gt;
            /// </summary>
            public const string ReceiveSuggestions = "ReceiveSuggestions";

            /// <summary>
            /// AI computation status update (running / done / error).
            /// Payload: { status, message }
            /// </summary>
            public const string SuggestionStatus = "SuggestionStatus";

            /// <summary>
            /// Request client to refresh suggestions.
            /// Payload: optional message
            /// </summary>
            public const string SuggestionRefreshRequested = "SuggestionRefreshRequested";
        }

        // =========================
        // Client -> Server
        // =========================
        public static class FromClient
        {
            /// <summary>
            /// Client explicitly requests a new AI suggestion.
            /// Hub method: Task RequestSuggestion(...)
            /// </summary>
            public const string RequestSuggestion = "RequestSuggestion";

            /// <summary>
            /// Client subscribes to suggestions for an event.
            /// Hub method: Task JoinEvent(int eventId)
            /// </summary>
            public const string JoinEvent = "JoinEvent";

            /// <summary>
            /// Client leaves event suggestion stream.
            /// Hub method: Task LeaveEvent(int eventId)
            /// </summary>
            public const string LeaveEvent = "LeaveEvent";
        }

        // =========================
        // Groups
        // =========================
        public static string EventGroup(int eventId)
            => $"ai:event:{eventId}";
    }
}


























































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.