namespace SahibindenSaas.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime SentAt { get; set; } = DateTime.UtcNow;
        public DateTime? ReadAt { get; set; }
        public bool IsRead { get; set; } = false;

        // Users
        public string SenderId { get; set; } = string.Empty;
        public ApplicationUser? Sender { get; set; }

        public string ReceiverId { get; set; } = string.Empty;
        public ApplicationUser? Receiver { get; set; }

        // Listing
        public int? ListingId { get; set; }
        public Listing? Listing { get; set; }

        // Conversation
        public int ConversationId { get; set; }
        public Conversation? Conversation { get; set; }
    }
}
