namespace CitizenHackathon2025.Contracts.Enums
{
    namespace CitizenHackathon2025.Contracts.Enums
    {
        /// <summary>
        /// Certainty level based on the Common Alerting Protocol.
        /// </summary>
        public enum EmergencyCertainty
        {
            Unknown = 0,

            /// <summary>
            /// The event is unlikely.
            /// </summary>
            Unlikely = 1,

            /// <summary>
            /// The event is possible.
            /// </summary>
            Possible = 2,

            /// <summary>
            /// The event is likely.
            /// </summary>
            Likely = 3,

            /// <summary>
            /// The event has been observed or confirmed.
            /// </summary>
            Observed = 4
        }
    }
}































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.