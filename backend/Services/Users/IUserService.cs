using backend.Domain;

namespace backend.Services.Users;
public interface IUserService
{
  Task<IEnumerable<User>> GetAllUSerAsync();
  Task<User> GetUserByIdAsync(Guid id);
  Task<User> CreateUserAsync(User user);
  Task<User> UpdateUserAsync(User user);
  Task<bool> DeleteUserAsync(Guid id);
}