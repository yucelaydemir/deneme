namespace SahibindenSaas.Models.ViewModels
{
    public class DashboardViewModel
    {
        public int ActiveListings { get; set; }
        public int TotalViews { get; set; }
        public int TotalFavorites { get; set; }
        public int UnreadMessages { get; set; }
        public decimal TotalRevenue { get; set; }
        public List<Listing>? RecentListings { get; set; }
        public List<Message>? RecentMessages { get; set; }
        public List<Review>? RecentReviews { get; set; }
        public double AverageRating { get; set; }
        public int TotalReviews { get; set; }
    }
}
