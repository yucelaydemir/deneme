namespace SahibindenSaas.Models
{
    public class Follow
    {
        public int Id { get; set; }
        public string FollowerId { get; set; } = string.Empty;
        public ApplicationUser? Follower { get; set; }

        public string FollowedId { get; set; } = string.Empty;
        public ApplicationUser? Followed { get; set; }

        public DateTime FollowedAt { get; set; } = DateTime.UtcNow;
    }
}
