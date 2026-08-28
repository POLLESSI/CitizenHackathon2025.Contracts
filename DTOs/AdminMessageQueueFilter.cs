namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class AdminMessageQueueFilter
    {
        public string? Status { get; set; }
        public string? Category { get; set; }
        public byte? Priority { get; set; }
        public int Take { get; set; } = 200;
    }
}















































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.