
    public interface IUserService
    {
        Task<UserDTO> GetProfileAsync(Guid userId);
        Task<bool> UpdateProfileAsync(UserDTO user);
    }
    