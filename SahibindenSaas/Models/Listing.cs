namespace SahibindenSaas.Models
{
    public class Listing
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public string? Location { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Address { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        // Media
        public List<string>? Images { get; set; } = new List<string>();
        public string? MainImage { get; set; }
        public List<string>? Videos { get; set; } = new List<string>();

        // Details
        public string? Condition { get; set; } // New, Used, Like New
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int? Year { get; set; }
        public int? Kilometer { get; set; }
        public string? AdditionalDetails { get; set; } // JSON

        // Metadata
        public int Views { get; set; } = 0;
        public int FavoritesCount { get; set; } = 0;
        public int ContactsCount { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public DateTime? ActiveUntilAt { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsFeatured { get; set; } = false;
        public DateTime? FeaturedUntilAt { get; set; }
        public bool IsPromoted { get; set; } = false;
        public DateTime? PromotedUntilAt { get; set; }
        public bool IsVitrin { get; set; } = false; // Vitrin İlan
        public DateTime? VitrinUntilAt { get; set; }
        public bool IsPending { get; set; } = true; // Admin approval
        public string? RejectionReason { get; set; }

        // User
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser? User { get; set; }

        // Navigation properties
        public ICollection<Message>? Messages { get; set; }
        public ICollection<Favorite>? Favorites { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Transaction>? Transactions { get; set; }
    }
}
