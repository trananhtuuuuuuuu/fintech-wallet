//  Id, Name, Amount, Date, BrandName

namespace backend.Domain;

public class ManagementWallet
{
 public Guid Id { get; set; }
 public string Name { get; set; } = string.Empty;
 public Decimal Amount { get; set; }
 public DateTime SavedDate { get; set; } 
 public string BrandName { get; set; } = string.Empty;
 public Guid UserId { get; set; }
 public User? User { get; set; }
}