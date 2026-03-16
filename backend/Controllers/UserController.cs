
using backend.Domain;
using backend.Mappers;
using backend.Requests.Users;
using backend.Responses.Users;
using backend.Services.Users;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("api/users")]
public class UserController(IUserService userService) : ControllerBase
{
  private readonly IUserService _userService = userService;

  [HttpPost]
  public async Task<ActionResult<CreateUserResponse>> CreateAsync(CreateUserRequest createUserRequest)
  {
    User user = UserMapper.ToDomain(createUserRequest);
    user.Id = new Guid();
    return UserMapper.ToCreateUserResponse(
      await _userService.CreateUserAsync(user)
    );
  }
}