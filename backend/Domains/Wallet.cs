namespace backend.Domain;
public class Wallet
{
  public Guid Id { get; set; }
  public Decimal Amount { get; set; }
  public Guid UserId { get; set; }
  public User ? User { get; set; } 
}