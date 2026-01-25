// CitizenHackathon2025.Contracts/Hubs/MessageHubMethods.cs
namespace CitizenHackathon2025.Contracts.Hubs
{
    /// <summary>
    /// SignalR contract for MessageHub (chat / user messages).
    /// </summary>
    public static class MessageHubMethods
    {
        /// <summary>
        /// Absolute hub path.
        /// </summary>
        public const string HubPath = "messageHub";

        // =========================
        // Server -> Client
        // =========================
        public static class ToClient
        {
            /// <summary>
            /// New message received.
            /// Payload: MessageDTO / JSON
            /// </summary>
            public const string ReceiveMessage = "ReceiveMessage";

            /// <summary>
            /// Batch of messages (history).
            /// Payload: IEnumerable&lt;MessageDTO&gt;
            /// </summary>
            public const string ReceiveMessages = "ReceiveMessages";

            /// <summary>
            /// Message delivery confirmation.
            /// Payload: { messageId, deliveredUtc }
            /// </summary>
            public const string MessageDelivered = "MessageDelivered";

            /// <summary>
            /// Generic notification (system / info).
            /// Payload: string or JSON
            /// </summary>
            public const string ReceiveNotification = "ReceiveNotification";
        }

        // =========================
        // Client -> Server
        // =========================
        public static class FromClient
        {
            /// <summary>
            /// Client sends a message.
            /// Hub method: Task SendMessage(...)
            /// </summary>
            public const string SendMessage = "SendMessage";

            /// <summary>
            /// Client requests message history.
            /// Hub method: Task LoadHistory(...)
            /// </summary>
            public const string LoadHistory = "LoadHistory";

            /// <summary>
            /// Client joins a conversation.
            /// Hub method: Task JoinConversation(string conversationId)
            /// </summary>
            public const string JoinConversation = "JoinConversation";

            /// <summary>
            /// Client leaves a conversation.
            /// Hub method: Task LeaveConversation(string conversationId)
            /// </summary>
            public const string LeaveConversation = "LeaveConversation";

            public const string Ping = "Ping";
        }

        // =========================
        // Groups
        // =========================
        public static string ConversationGroup(string conversationId)
            => $"msg:conv:{conversationId}";

        public static string UserGroup(string userId)
            => $"msg:user:{userId}";
    }
}



































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.