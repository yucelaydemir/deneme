namespace SahibindenSaas.Models
{
    public class Conversation
    {
        public int Id { get; set; }
        public string Participant1Id { get; set; } = string.Empty;
        public ApplicationUser? Participant1 { get; set; }

        public string Participant2Id { get; set; } = string.Empty;
        public ApplicationUser? Participant2 { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastMessageAt { get; set; } = DateTime.UtcNow;

        public ICollection<Message>? Messages { get; set; }
    }
}
