
    public class Home
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public Guid OwnerId { get; set; }
        public User Owner { get; set; }
    }
    