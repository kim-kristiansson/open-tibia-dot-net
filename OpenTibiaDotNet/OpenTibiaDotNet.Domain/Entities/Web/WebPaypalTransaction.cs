namespace OpenTibiaDotNet.Domain.Entities.Web;

public class WebPaypalTransaction
{
    public int Id { get; set; }
    public string TransactionId { get; set; } = string.Empty; // txn_id
    public string Email { get; set; } = string.Empty;
    public int AccountId { get; set; }
    public int Price { get; set; }
    public int Points { get; set; }
}