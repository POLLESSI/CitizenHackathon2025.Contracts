namespace CitizenHackathon2025.Contracts.Hubs
{
    /// <summary>
    /// Shared constants (server + client) for WeatherForecastHub (SignalR).
    /// </summary>
    public static class WeatherForecastHubMethods
    {
        /// <summary>
        /// Hub path (relative, used with app.MapGroup("/hubs")).
        /// Final URL = {ApiBaseUrl}/hubs/{HubPath}
        /// </summary>
        public const string HubPath = "weatherforecastHub";

        /// <summary>Events sent by the server to clients.</summary>
        public static class ToClient
        {
            /// <summary>
            /// Broadcasting a new weather forecast.
            /// Hub: await Clients.All.SendAsync(WeatherForecastHubMethods.ToClient.ReceiveForecast, dto)
            /// </summary>
            public const string ReceiveForecast = "ReceiveForecast";

            /// <summary>
            /// Notification that a forecast/event has been archived.
            /// Hub: await Clients.All.SendAsync(WeatherForecastHubMethods.ToClient.EventArchived, id)
            /// </summary>
            public const string EventArchived = "EventArchived";

            /// <summary>
            /// Heavy rain alert (payload: RainAlertDTO).
            /// Hub: await Clients.All.SendAsync(WeatherForecastHubMethods.ToClient.HeavyRainAlert, alert)
            /// </summary>
            public const string HeavyRainAlert = "HeavyRainAlert";
        }

        /// <summary>Methods invoked by clients on the hub.</summary>
        public static class FromClient
        {
            /// <summary>
            /// Ask the server to refresh/broadcast forecasts.
            /// Hub signature: Task RefreshWeatherForecast(string message)
            /// </summary>
            public const string RefreshWeatherForecast = "RefreshWeatherForecast";

            /// <summary>
            /// Send a generic notification.
            /// Hub signature: Task Notify(string message)
            /// </summary>
            public const string Notify = "Notify";
        }
    }
}



























































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.