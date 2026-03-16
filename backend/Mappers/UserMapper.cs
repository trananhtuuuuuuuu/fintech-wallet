using backend.Domain;
using backend.Dto.user;
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

  public static CreateUserResponse ToCreateUserResponse(User user)
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

  public static UserDTO ToDTO(User user)
  {
    return new UserDTO(
      user.FullName,
      user.Address,
      user.Gender,
      user.PhoneNumber,
      user.Email,
      user.Account
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