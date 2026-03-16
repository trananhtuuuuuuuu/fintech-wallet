namespace backend.Responses.Users;
public class CreateUserResponse(string fullName,
  string address,
  string gender,
  string phoneNumber,
  string email,
  string account,
  string refreshToken)
{
  public string FullName { get; set; } = fullName;
  public string Address { get; set; } = address;
  public string Gender { get; set; } = gender;
  public string PhoneNumber { get; set; } = phoneNumber;
  public string Email { get; set; } = email;
  public string Account { get; set; } = account;
  public string RefreshToken { get; set; } = refreshToken;
}