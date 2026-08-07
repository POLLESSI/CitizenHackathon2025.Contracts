namespace CitizenHackathon2025.Contracts.Enums
{
    /// <summary>
    /// Emergency based on the Common Alerting Protocol.
    /// </summary>
    public enum EmergencyUrgency
    {
        Unknown = 0,

        /// <summary>
        /// The event has already ended.
        /// </summary>
        Past = 1,

        /// <summary>
        /// An action may be required later.
        /// </summary>
        Future = 2,

        /// <summary>
        /// An action is expected soon.
        /// </summary>
        Expected = 3,

        /// <summary>
        /// An immediate action is required.
        /// </summary>
        Immediate = 4
    }
}













































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.