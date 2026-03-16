namespace backend.Dto.user;

public class UserDTO(string fullName, string address, string gender, string phoneNumber, string email,
string account)
{
  public Guid Id { get; set; }
  public string FullName { get; set; } = fullName;
  public string Address { get; set; } = address;
  public string Gender { get; set; } = gender;
  public string PhoneNumber { get; set; } = phoneNumber;
  public string Email { get; set; } = email;
  public string Account { get; set; } = account;
  public string Password { get; set; } = string.Empty;
  public string RefreshToken { get; set; } = string.Empty;
}