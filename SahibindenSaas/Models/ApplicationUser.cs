using Microsoft.AspNetCore.Identity;

namespace SahibindenSaas.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProfileImage { get; set; }
        public string? Bio { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Address { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsVerified { get; set; } = false;
        public bool IsEmailVerified { get; set; } = false;
        public bool IsPhoneVerified { get; set; } = false;
        public int TotalListings { get; set; } = 0;
        public int TotalSales { get; set; } = 0;
        public int TotalReviews { get; set; } = 0;
        public double AverageRating { get; set; } = 0;
        public string? PreferredLanguage { get; set; } = "tr";
        public bool NotificationsEnabled { get; set; } = true;
        public string? GoogleId { get; set; }
        public string? FacebookId { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public int LoginCount { get; set; } = 0;

        // Navigation properties
        public ICollection<Listing>? Listings { get; set; }
        public ICollection<Message>? SentMessages { get; set; }
        public ICollection<Message>? ReceivedMessages { get; set; }
        public ICollection<Favorite>? Favorites { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Transaction>? Transactions { get; set; }
        public ICollection<Follow>? Following { get; set; }
        public ICollection<Follow>? Followers { get; set; }
        public ICollection<ListingDraft>? Drafts { get; set; }
    }
}
