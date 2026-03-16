using backend.Data;
using backend.Domain;
using backend.Services.Users;

namespace backend.Services.Users;
public class UserService(WalletDbContext context) : IUserService
{

  private readonly WalletDbContext _context = context;

  public async Task<User> CreateUserAsync(User user)
  {
    await _context.Users.AddAsync(user);
    await _context.SaveChangesAsync();
    return user;
  }

  public Task<bool> DeleteUserAsync(Guid id)
  {
    throw new NotImplementedException();
  }

  public Task<IEnumerable<User>> GetAllUSerAsync()
  {
    throw new NotImplementedException();
  }

  public Task<User> GetUserByIdAsync(Guid id)
  {
    throw new NotImplementedException();
  }

  public Task<User> UpdateUserAsync(User user)
  {
    throw new NotImplementedException();
  }
}