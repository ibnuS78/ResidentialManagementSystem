
    public interface IFeeService
    {
        Task<IEnumerable<MaintenanceFeeDTO>> GetFeesAsync();
        Task<bool> PayFeeAsync(Guid feeId, string evidencePath);
    }
    