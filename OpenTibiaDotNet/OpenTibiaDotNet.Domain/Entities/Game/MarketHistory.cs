namespace OpenTibiaDotNet.Domain.Entities.Game;

public class MarketHistory
{
    public uint Id { get; set; }

    public int PlayerId { get; set; }
    public Player? Player { get; set; }

    public bool Sale { get; set; }
    public ushort ItemType { get; set; }
    public ushort Amount { get; set; }

    public uint Price { get; set; }
    public ulong ExpiresAt { get; set; }
    public ulong Inserted { get; set; }
    public byte State { get; set; }
}