namespace SahibindenSaas.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; } // 1-5
        public string Comment { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Reviewer
        public string ReviewerId { get; set; } = string.Empty;
        public ApplicationUser? Reviewer { get; set; }

        // Reviewed User
        public string ReviewedUserId { get; set; } = string.Empty;
        public ApplicationUser? ReviewedUser { get; set; }

        // Listing (optional)
        public int? ListingId { get; set; }
        public Listing? Listing { get; set; }
    }
}
