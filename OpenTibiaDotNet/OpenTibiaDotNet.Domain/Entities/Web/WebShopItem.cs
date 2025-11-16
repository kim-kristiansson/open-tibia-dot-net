namespace OpenTibiaDotNet.Domain.Entities.Web;

public class WebShopItem
{
    public int Id { get; set; }
    public int Type { get; set; }
    public int? ItemId { get; set; }
    public int Count { get; set; } = 1;
    public string Description { get; set; } = string.Empty;
    public int Points { get; set; } = 10;
}