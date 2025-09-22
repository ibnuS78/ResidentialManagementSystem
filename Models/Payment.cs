
    public class Payment
    {
        public Guid Id { get; set; }
        public Guid FeeId { get; set; }
        public MaintenanceFee Fee { get; set; }
        public Guid UploadedBy { get; set; }
        public User UploadedByUser { get; set; }
        public DateTime UploadDate { get; set; }
        public string EvidencePath { get; set; }
        public bool Verified { get; set; }
        public Guid? VerifiedBy { get; set; }
        public User VerifiedByUser { get; set; }
    }
    