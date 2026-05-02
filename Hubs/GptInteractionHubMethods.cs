namespace CitizenHackathon2025.Contracts.Hubs
{
    public static class GptInteractionHubMethods
    {
        public const string HubPath = "gptHub";

        public static class ToClient
        {
            public const string ReceiveStarted = nameof(IGptClient.ReceiveGptResponseStarted);
            public const string ReceiveChunk = nameof(IGptClient.ReceiveGptResponseChunk);
            public const string ReceiveStatus = nameof(IGptClient.ReceiveGptResponseStatus);
            public const string ReceiveCompleted = nameof(IGptClient.ReceiveGptResponseCompleted);
        }

        public static class FromClient
        {
            public const string RefreshGpt = nameof(RefreshGpt); // legacy if you really want to keep it
        }
    }
}







































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.