namespace backend.Requests.Users;
public class CreateUserRequest
{
  public string FullName { get; set; } = string.Empty;
  public string Address { get; set; } = string.Empty;
  public string Gender { get; set; } = string.Empty;
  public string PhoneNumber { get; set; } = string.Empty;
  public string Email { get; set; } = string.Empty;
  public string Account { get; set; } = string.Empty;
  public string Password { get; set; } = string.Empty;
}

