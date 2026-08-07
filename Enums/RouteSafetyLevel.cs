namespace CitizenHackathon2025.Contracts.Enums
{
    public enum RouteSafetyLevel
    {
        Unknown = 0,

        /// <summary>
        /// No active danger known affects the route.
        /// </summary>
        Safe = 1,

        /// <summary>
        /// Information or advisory without blockage.
        /// </summary>
        Advisory = 2,

        /// <summary>
        /// Potential danger requiring special attention.
        /// </summary>
        Warning = 3,

        /// <summary>
        /// Significant danger; the route should be avoided.
        /// </summary>
        Dangerous = 4,

        /// <summary>
        /// Route or destination officially inaccessible.
        /// </summary>
        Blocked = 5
    }
}



































































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.