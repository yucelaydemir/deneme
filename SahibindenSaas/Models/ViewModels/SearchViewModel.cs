namespace SahibindenSaas.Models.ViewModels
{
    public class SearchViewModel
    {
        public string? SearchTerm { get; set; }
        public string? Category { get; set; }
        public string? City { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public string? Condition { get; set; }
        public string? SortBy { get; set; } = "newest";
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 12;
        public List<ListingViewModel>? Results { get; set; } = new List<ListingViewModel>();
        public int TotalCount { get; set; }
    }
}
