namespace OpenTibiaDotNet.Domain.Entities.Game;

public class PlayerDepotLockerItem
{
    public int PlayerId { get; set; }
    public Player? Player { get; set; }

    public int Sid { get; set; }
    public int Pid { get; set; }
    public short ItemType { get; set; }
    public short Count { get; set; }
    public byte[] Attributes { get; set; } = Array.Empty<byte>();
}