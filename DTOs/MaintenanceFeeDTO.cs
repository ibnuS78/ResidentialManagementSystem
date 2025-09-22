
    public class MaintenanceFeeDTO
    {
        public Guid Id { get; set; }
        public Guid HomeId { get; set; }
        public DateTime Month { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
    }
    