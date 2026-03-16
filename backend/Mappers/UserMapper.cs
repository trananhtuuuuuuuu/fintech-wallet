using backend.Domain;
using backend.Requests.Users;
using backend.Responses.Users;
namespace backend.Mappers;

public class UserMapper
{
  public static User ToDomain(CreateUserRequest createUserRequest)
  {
    return new User(
      createUserRequest.FullName,
      createUserRequest.Address,
      createUserRequest.Gender,
      createUserRequest.PhoneNumber,
      createUserRequest.Email,
      createUserRequest.Account,
      createUserRequest.Password
    );
  }

  public static CreateUserResponse ToDTO(User user)
  {
    return new CreateUserResponse(
      user.FullName,
      user.Address,
      user.Gender,
      user.PhoneNumber,
      user.Email,
      user.Account,
      user.RefreshToken
    );
  }

}



/*

public User(string FullName, 
  string Address, 
  string Gender, 
  string PhoneNumber, 
  string Email, 
  string Account, 
  string Password)
  
*/