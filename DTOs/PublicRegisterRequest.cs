using System.ComponentModel.DataAnnotations;

namespace CitizenHackathon2025.Contracts.DTOs
{
    public sealed class PublicRegisterRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; init; } = string.Empty;

        [Required]
        [MinLength(12)]
        public string Password { get; init; } = string.Empty;
    }
}













































































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.