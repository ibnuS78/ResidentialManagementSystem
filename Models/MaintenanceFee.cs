
    public class MaintenanceFee
    {
        public Guid Id { get; set; }
        public Guid HomeId { get; set; }
        public Home Home { get; set; }
        public DateTime Month { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; } // Unpaid, Paid, Verified
    }
    