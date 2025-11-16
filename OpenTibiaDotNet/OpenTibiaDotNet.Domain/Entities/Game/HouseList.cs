namespace OpenTibiaDotNet.Domain.Entities.Game;

public class HouseList
{
    public int HouseId { get; set; }
    public House? House { get; set; }

    public int ListId { get; set; }
    public string List { get; set; } = string.Empty;
}