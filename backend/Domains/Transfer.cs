// Id, Name, OriginalWallet, DestinationWallet, Amount, Date
namespace backend.Domain;
public class Transfer
{
  public Guid Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public Guid OriginalWallet { get; set; }
  public Guid DestinationWallet { get; set; }
  public DateTime TransDate { get; set; }
  public Decimal Amount { get; set; }
}