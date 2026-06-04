namespace CitizenHackathon2025.Contracts.DTOs
{
    public class FullAlertDTO
    {
        public int PlaceId { get; set; }
        public string PlaceName { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime DeclaredAtUtc { get; set; }
        public DateTime ExpiresAtUtc { get; set; }
    }
}
