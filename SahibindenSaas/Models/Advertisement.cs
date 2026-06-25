namespace SahibindenSaas.Models
{
    public class Advertisement
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public string? TargetUrl { get; set; }
        public string Position { get; set; } = string.Empty; // TopBanner, Sidebar, Footer
        public bool IsActive { get; set; } = true;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DisplayOrder { get; set; } = 0;
        public int Views { get; set; } = 0;
        public int Clicks { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}
