
namespace backend.Domain;
public class User {
  public Guid Id { get; set; }
  public string FullName { get; set; } = string.Empty;
  public string Address { get; set; } = string.Empty;
  public string Gender { get; set; } = string.Empty;
  public string PhoneNumber { get; set; } = string.Empty;
  public string Email { get; set; } = string.Empty;
  public string Account { get; set; } = string.Empty;
  public string Password { get; set; } = string.Empty;
  public string RefreshToken { get; set; } = string.Empty;

  public ICollection<Wallet>? Wallets { get; set; }
  public ICollection<ManagementWallet>? ManagementWallets  {get; set; }
}