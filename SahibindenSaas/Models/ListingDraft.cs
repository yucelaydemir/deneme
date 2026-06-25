namespace SahibindenSaas.Models
{
    public class ListingDraft
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string? Category { get; set; }
        public string? SubCategory { get; set; }
        public string? Location { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public List<string>? Images { get; set; }
        public string? AdditionalData { get; set; } // JSON
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public string UserId { get; set; } = string.Empty;
        public ApplicationUser? User { get; set; }
    }
}
