namespace SahibindenSaas.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string TransactionId { get; set; } = string.Empty; // Stripe/iyzico ID
        public decimal Amount { get; set; }
        public string Currency { get; set; } = "TRY";
        public string Status { get; set; } = string.Empty; // pending, completed, failed, refunded
        public string TransactionType { get; set; } = string.Empty; // featured, promotion, subscription
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? CompletedAt { get; set; }

        // User
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser? User { get; set; }

        // Listing
        public int? ListingId { get; set; }
        public Listing? Listing { get; set; }

        // Payment Details
        public string? PaymentMethod { get; set; } // stripe, iyzico
        public string? StripePaymentIntentId { get; set; }
        public string? IyzicoPaymentId { get; set; }
    }
}
