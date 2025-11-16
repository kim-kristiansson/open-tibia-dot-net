namespace OpenTibiaDotNet.Domain.Entities.Web;

public class WebShopLog
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public int PlayerId { get; set; }

    public int Type { get; set; }
    public int ItemId { get; set; }
    public int Count { get; set; }
    public int Points { get; set; }

    public int Time { get; set; }
}