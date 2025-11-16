namespace OpenTibiaDotNet.Domain.Entities.Game;

public class PlayerStorage
{
    public int PlayerId { get; set; }
    public Player? Player { get; set; }

    public uint Key { get; set; }
    public int Value { get; set; }
}