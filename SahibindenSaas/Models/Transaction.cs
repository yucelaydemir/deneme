namespace SahibindenSaas.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string TransactionId { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Currency { get; set; } = "TRY";
        public string Status { get; set; } = "pending";
        public string TransactionType { get; set; } = string.Empty; // featured, promotion, subscription, package
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? CompletedAt { get; set; }

        public string UserId { get; set; } = string.Empty;
        public ApplicationUser? User { get; set; }

        public int? ListingId { get; set; }
        public Listing? Listing { get; set; }

        public int? PackageId { get; set; }
        public Package? Package { get; set; }

        public string? PaymentMethod { get; set; } // stripe, paytr, iyzico
        public string? StripePaymentIntentId { get; set; }
        public string? PayTROrderId { get; set; }
        public string? IyzicoPaymentId { get; set; }
        public string? Notes { get; set; }
    }
}
