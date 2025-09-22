
    public interface IPaymentService
    {
        Task<IEnumerable<PaymentDTO>> GetPaymentsAsync();
        Task<bool> VerifyPaymentAsync(Guid paymentId);
    }
    