
    public class PaymentDTO
    {
        public Guid Id { get; set; }
        public Guid FeeId { get; set; }
        public Guid UploadedBy { get; set; }
        public DateTime UploadDate { get; set; }
        public string EvidencePath { get; set; }
        public bool Verified { get; set; }
        public Guid? VerifiedBy { get; set; }
    }
    