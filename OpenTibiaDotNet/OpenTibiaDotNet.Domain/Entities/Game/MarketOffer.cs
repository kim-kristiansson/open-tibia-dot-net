namespace OpenTibiaDotNet.Domain.Entities.Game;

public class MarketOffer
{
    public uint Id { get; set; }

    public int PlayerId { get; set; }
    public Player? Player { get; set; }

    public bool Sale { get; set; }
    public ushort ItemType { get; set; }
    public ushort Amount { get; set; }

    public ulong Created { get; set; }
    public bool Anonymous { get; set; }
    public uint Price { get; set; }
}