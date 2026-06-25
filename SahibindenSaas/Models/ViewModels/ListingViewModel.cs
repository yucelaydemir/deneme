namespace SahibindenSaas.Models.ViewModels
{
    public class ListingViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Category { get; set; } = string.Empty;
        public string SubCategory { get; set; } = string.Empty;
        public string? Location { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public List<string>? Images { get; set; } = new List<string>();
        public string? MainImage { get; set; }
        public string? Condition { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int? Year { get; set; }
        public int? Kilometer { get; set; }
        public int Views { get; set; }
        public int FavoritesCount { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsPromoted { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string? UserImage { get; set; }
        public double UserRating { get; set; }
    }

    public class CreateListingViewModel
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Category { get; set; } = string.Empty;
        public string SubCategory { get; set; } = string.Empty;
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Address { get; set; }
        public List<IFormFile>? Images { get; set; }
        public string? Condition { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int? Year { get; set; }
        public int? Kilometer { get; set; }
    }
}
