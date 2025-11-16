namespace OpenTibiaDotNet.Domain.Entities.Game;

public class TileStore
{
    public int HouseId { get; set; }
    public House? House { get; set; }

    public byte[] Data { get; set; } = Array.Empty<byte>();
}