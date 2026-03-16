using backend.Data;
using backend.Domain;
using backend.Dto.user;
using backend.Mappers;
using backend.Services.Users;
using Microsoft.EntityFrameworkCore;

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

  public async Task<bool> DeleteUserAsync(Guid id)
  {
    // need concurrency processing
    User? user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);

    if(user is null)
    {
      throw new KeyNotFoundException("User Not Found");
    }
    try
    {
        await _context.SaveChangesAsync();
        return true;
    }
    catch (DbUpdateConcurrencyException)
    {
        return false;
    }
  }

  public async Task<IEnumerable<User>> GetAllUSerAsync()
  {
    throw new NotImplementedException();
  }

  public async Task<User> GetUserByIdAsync(Guid id)
  {
    User? user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id) ?? throw new KeyNotFoundException("User Not Found");
    return user;
  }

  public async Task<User> UpdateUserAsync(User user)
  {
    throw new NotImplementedException();
  }
}